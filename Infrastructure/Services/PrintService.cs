using Core.DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Globalization;

namespace Infrastructure.Services
{
    public static class PrintService
    {
        // Theme colors (change these to match your brand)
        private const string Purple = "#722F83";
        private const string PurpleMid = "#8E4A9E";
        private const string PurpleLight = "#F1E6F5";
        private const string LineGrey = "#BFBFBF";

        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        static string QRPath = Path.Combine(AppContext.BaseDirectory, "Assests", "QR.png");
        static string ABlogoPath = Path.Combine(AppContext.BaseDirectory, "Assests", "ABlogo.png");
        static PrintService()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        /// <summary>Creates the invoice PDF and saves it to filePath.</summary>
        /// <param name="packageName">e.g. "30 Mbps" (shown under Services Detail).</param>
        /// <param name="lateFee">Extra charge if paid after the due date ("Amount After Due Date").</param>
        public static void Generate(
            string filePath,
            CustomerDto customer,
            BillingsDto bill,
            string companyName = "",
            string? companyPhone = null,
            string? logoPath = null,
            string? packageName = null,
            decimal lateFee = 0)
        {
            BuildDocument(customer, bill, companyName, companyPhone, logoPath, packageName, lateFee)
                .GeneratePdf(filePath);
        }

        /// <summary>Same as Generate, but returns the PDF as bytes (for email or API use).</summary>
        public static byte[] GenerateBytes(
            CustomerDto customer,
            BillingsDto bill,
            string companyName = null,
            string? complaintNumber = null,
            string? logoPath = null,
            string? packageName = null,
            decimal lateFee = 0)
        {
            return BuildDocument(customer, bill, companyName, complaintNumber, logoPath, packageName, lateFee)
                .GeneratePdf();
        }

        private static Document BuildDocument(
            CustomerDto customer, BillingsDto bill, string companyName, string? complaintNumber,
            string? logoPath, string? packageName, decimal lateFee)
        {
            string invoiceNo = $"INV-{customer.CustomerID}-{bill.BillID:D6}";
            string billingMonth = bill.BillDate.ToString("MMM-yyyy", Inv);
            decimal amountAfterDue = bill.RemainingAmount + lateFee;
            bool isPaid = bill.Status.Equals("Paid", StringComparison.OrdinalIgnoreCase);
            string statusColor = isPaid ? Colors.Green.Darken2 : Colors.Red.Darken2;
            string package = string.IsNullOrWhiteSpace(packageName) ? "Package Name" : packageName;

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(28);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    // ================= HEADER =================
                    page.Header().Column(h =>
                    {
                        h.Item().Height(8).Background(Purple);

                        h.Item().PaddingTop(10).Row(row =>
                        {
                            logoPath = string.IsNullOrWhiteSpace(logoPath) ? ABlogoPath : logoPath;
                            if (!string.IsNullOrWhiteSpace(logoPath) && File.Exists(logoPath))
                            {
                                row.ConstantItem(70).Height(60).Image(logoPath).FitArea();
                                row.ConstantItem(10);
                            }

                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text(companyName).FontSize(14).Bold();
                                c.Item().Text("Flash Fiber Fast Internet Service").FontSize(9);
                                //c.Item().Text("");
                                //c.Item().Text("");
                                //if (!string.IsNullOrWhiteSpace(complaintNumber))
                                //    c.Item().PaddingTop(2).Text($"Complaint Number: {complaintNumber}").FontSize(8);
                            });

                            row.ConstantItem(210).Column(c =>
                            {
                                c.Item().AlignRight().Text("BILL INVOICE").FontSize(18).Bold();
                                c.Item().Border(1.2f).BorderColor(Colors.Grey.Darken2)
                                    .Padding(4).AlignCenter().Text(invoiceNo).FontSize(16).Bold();
                                c.Item().PaddingTop(6).Text($"Issue Date: {DateTime.Now:dd-MM-yyyy}");
                            });
                        });
                    });

                    // ================= CONTENT =================
                    page.Content().PaddingTop(14).Column(col =>
                    {
                        col.Spacing(14);

                        // --- Customer box + account info ---
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().MinHeight(95).Border(1).BorderColor(Purple).Padding(10).Column(c =>
                            {
                                c.Item().Text(customer.CustomerName.ToUpperInvariant()).Bold().FontSize(11);
                                if (!string.IsNullOrWhiteSpace(customer.Address))
                                    c.Item().PaddingTop(8).Text(customer.Address);
                                if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
                                    c.Item().PaddingTop(4).Text($"Phone: {customer.PhoneNumber}");
                                if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
                                    c.Item().PaddingTop(4).Text($"Customer CNIC: {customer.CNIC}");
                            });

                            row.ConstantItem(14);

                            row.ConstantItem(260).Table(t =>
                            {
                                t.ColumnsDefinition(cd => { cd.RelativeColumn(); cd.RelativeColumn(); });

                                InfoRow(t, "Account ID", customer.CustomerID.ToString());
                                InfoRow(t, "Billing Month", billingMonth);
                                InfoRow(t, "Amount Due", Money(bill.TotalAmount), strong: true);
                                InfoRow(t, "Due Date", FormatDate(bill.DueBillDate), strong: true);
                                if (lateFee > 0)
                                    InfoRow(t, "Amount After Due Date", Money(amountAfterDue));
                                InfoRow(t, "Status", bill.Status, strong: true, valueColor: statusColor);
                            });
                        });

                        // --- Services detail + bill summary ---
                        col.Item().Row(row =>
                        {
                            // Left: services detail
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Element(x => SectionHeader(x, "SERVICES DETAIL"));

                                c.Item().Background(PurpleMid).Padding(4)
                                    .Text("INTERNET BUNDLE").Bold().FontColor(Colors.White);

                                c.Item().Table(t =>
                                {
                                    t.ColumnsDefinition(cd => { cd.RelativeColumn(2); cd.RelativeColumn(1); });
                                    SummaryRow(t, package, customer.Package);
                                    SummaryRow(t, "Charges", Money(bill.Amount));
                                });

                                c.Item().PaddingTop(4).Text($"Billing period starts {bill.BillDate:dd-MM-yyyy}")
                                    .FontSize(9).FontColor(Colors.Grey.Darken1);

                                c.Item().PaddingTop(40).BorderTop(1).BorderColor(Colors.Black).PaddingTop(3).Row(r =>
                                {
                                    r.RelativeItem().Text("Total:").Bold();
                                    r.ConstantItem(110).AlignRight().Text(Money(bill.Amount)).Bold();
                                });

                            });

                            row.ConstantItem(14);

                            // Right: bill summary
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Element(x => SectionHeader(x, "BILL SUMMARY"));

                                c.Item().Table(t =>
                                {
                                    t.ColumnsDefinition(cd => { cd.RelativeColumn(2); cd.RelativeColumn(1); });
                                    SummaryRow(t, "Monthly Charges", Money(bill.Amount));
                                    SummaryRow(t, "Pending Charges", Money(bill.RemainingAmount));
                                    SummaryRow(t, "Paid Amount", Money(bill.PaidAmount));
                                    SummaryRow(t, "Paid On", FormatDate(bill.BillPaidDate), rightIsMoney: false);
                                    SummaryRow(t, "Grand Total (Amount Due)", Money(bill.TotalAmount), bold: true);
                                });
                            });
                        });

                        // --- Notice banner ---
                        col.Item().Background("#F2F2F2").Padding(8).AlignCenter().Text(
                            string.IsNullOrWhiteSpace(complaintNumber)
                                ? "Please pay your bill before the due date to avoid a late fee."
                                : $"For bill payments and complaints, please call {complaintNumber}. Pay before the due date to avoid a late fee.")
                            .Bold().FontSize(9.5f);

                        // --- Advertisment Section ---
                        col.Item().Background("#FFFFFF").Padding(4).AlignCenter().Text($"For advertise here, please contact {complaintNumber}.").Bold().FontSize(6.5f);
                    });

                    // ================= FOOTER: PAYMENT SLIP =================
                    page.Footer().Column(f =>
                    {
                        f.Item().Background(Purple).Padding(4)
                            .Text("FOR PAYMENT USE").Bold().FontColor(Colors.White);

                        // --- Pay online: QR code + account numbers ---

                            f.Item().PaddingTop(8).Row(row =>
                            {
                                row.Spacing(16);

                                row.RelativeItem().Column(c =>
                                    {
                                        c.Item().Text("Pay online / bank transfer").Bold();

                                        c.Item().PaddingTop(4).Table(t =>
                                        {
                                            t.ColumnsDefinition(cd =>
                                            {
                                                cd.RelativeColumn(2);
                                                cd.RelativeColumn(3);
                                                cd.RelativeColumn(3);
                                            });

                                            t.Header(h =>
                                            {
                                                h.Cell().Background(PurpleLight).Padding(3).Text("Method").Bold().FontSize(9);
                                                h.Cell().Background(PurpleLight).Padding(3).Text("Account Title").Bold().FontSize(9);
                                                h.Cell().Background(PurpleLight).Padding(3).Text("Account No.").Bold().FontSize(9);
                                            });
                                                t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).Padding(3).Text("EasyPaisa").FontSize(9);
                                                t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).Padding(3).Text("Abubakar Bin Mujahid").FontSize(9);
                                                t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).Padding(3).Text("03007708041").FontSize(9).Bold();
                                            
                                            t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).Padding(3).Text("JazzCash").FontSize(9);
                                            t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).Padding(3).Text("Abubakar Bin Mujahid").FontSize(9);
                                            t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).Padding(3).Text("03007708041").FontSize(9).Bold();

                                        });
                                });


                                row.ConstantItem(90).Column(c =>
                                {
                                    c.Item().Height(80).Image(Path.Combine(AppContext.BaseDirectory, "Assests", "ABAlfaQR.png")).FitArea();
                                    c.Item().AlignCenter().Text("Scan To Pay").FontSize(5).Bold();
                                });

                                //row.ConstantItem(70).Height(60).Image(QRPath).FitArea();
                                //row.ConstantItem(10);


                            });

                        f.Item().PaddingTop(8).Row(row =>
                        {
                            row.Spacing(22);

                            row.RelativeItem(3).Column(c =>
                            {
                                c.Item().Text($"Customer ID: {customer.CustomerID}");
                                c.Item().Text($"Invoice #: {invoiceNo}");
                                if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
                                    c.Item().Text($"Phone No: {customer.PhoneNumber}");
                            });

                            row.RelativeItem(3).Table(t =>
                            {
                                t.ColumnsDefinition(cd => { cd.RelativeColumn(); cd.RelativeColumn(); });
                                SlipRow(t, "Billing Month:", billingMonth);
                                SlipRow(t, "Due Date:", FormatDate(bill.DueBillDate), bold: true);
                                SlipRow(t, "Total Amount Due:", Money(bill.TotalAmount), bold: true);
                                SlipRow(t, "Payable After Due:", Money(bill.TotalAmount + lateFee));
                            });

                            row.RelativeItem(2).Column(c =>
                            {
                                c.Spacing(1);
                                c.Item().Text("Account No.: _________");
                                c.Item().Text("Amount Paid: _________");
                                c.Item().Text("Signature: ___________");
                            });

                        });
                        f.Item().PaddingTop(4).Row(row =>
                        {
                            row.RelativeItem(2).Column(c => c.Item().BorderTop(0.5f).BorderColor(LineGrey).Padding(3).Text("Software Created by Fahad Mughal").FontSize(5).Bold());
                        });
                    });
                });
            });
        }

        // ================= HELPERS =================
        private static string Money(decimal value) => $"Rs. {value:N2}";

        private static string FormatDate(DateTime? date) => date?.ToString("dd-MM-yyyy") ?? "-";

        private static void SectionHeader(IContainer c, string title) =>
            c.Background(Purple).Padding(6).Text(title).Bold().FontSize(12).FontColor(Colors.White);

        private static void InfoRow(TableDescriptor t, string label, string value,
            bool strong = false, string? valueColor = null)
        {
            t.Cell().Background(Purple).Padding(4).Text(label).Bold().FontColor(Colors.White);

            var v = t.Cell().Background(PurpleLight).Padding(4).Text(value).FontColor(valueColor ?? Colors.Black);
            if (strong) v.Bold();
        }

        private static void SummaryRow(TableDescriptor t, string label, string value,
            bool bold = false, bool rightIsMoney = true)
        {
            var l = t.Cell().BorderBottom(0.5f).BorderColor(LineGrey).PaddingVertical(4).PaddingHorizontal(6).Text(label);
            var r = t.Cell().Background(PurpleLight).BorderBottom(0.5f).BorderColor(LineGrey)
                .PaddingVertical(4).PaddingHorizontal(6).AlignRight().Text(value);

            if (bold) { l.Bold(); r.Bold(); }
        }

        private static void SlipRow(TableDescriptor t, string label, string value, bool bold = false)
        {
            var l = t.Cell().Text(label);
            var r = t.Cell().AlignRight().Text(value);

            if (bold) { l.Bold(); r.Bold(); }
        }
    }

    //public static class PrintService
    //{

    //    static PrintService()
    //    {
    //        QuestPDF.Settings.License = LicenseType.Community;
    //    }

    //    /// <summary>Creates the bill PDF and saves it to filePath.</summary>
    //    public static void Generate(
    //        string filePath,
    //        Customer customer,
    //        Billings bill,
    //        string companyName = "Your Company Name",
    //        string? complaintNumber = null,
    //        string? logoPath = null)
    //    {
    //        BuildDocument(customer, bill, companyName, complaintNumber, logoPath).GeneratePdf(filePath);
    //    }

    //    /// <summary>Creates the bill PDF and returns it as bytes (handy for APIs or email attachments).</summary>
    //    public static byte[] GenerateBytes(
    //        Customer customer,
    //        Billings bill,
    //        string companyName = "Your Company Name",
    //        string? complaintNumber = null,
    //        string? logoPath = null)
    //    {
    //        return BuildDocument(customer, bill, companyName, complaintNumber, logoPath).GeneratePdf();
    //    }

    //    private static Document BuildDocument(
    //        Customer customer, Billings bill, string companyName, string? complaintNumber, string? logoPath)
    //    {
    //        string statusColor = bill.Status.Equals("Paid", StringComparison.OrdinalIgnoreCase)
    //            ? Colors.Green.Darken2
    //            : bill.RemainingAmount > 0 ? Colors.Red.Darken2 : Colors.Orange.Darken2;

    //        return Document.Create(container =>
    //        {
    //            container.Page(page =>
    //            {
    //                page.Size(PageSizes.A4);
    //                page.Margin(40);
    //                page.DefaultTextStyle(x => x.FontSize(11).FontFamily("Lato"));

    //                // ---------- Header ----------
    //                page.Header().PaddingBottom(15).BorderBottom(1).BorderColor(Colors.Grey.Lighten1).Row(row =>
    //                {
    //                    if (!string.IsNullOrWhiteSpace(logoPath) && File.Exists(logoPath))
    //                    {
    //                        row.ConstantItem(60).Height(60).Image(logoPath).FitArea();
    //                        row.ConstantItem(12);
    //                    }

    //                    row.RelativeItem().Column(col =>
    //                    {
    //                        col.Item().Text(companyName).FontSize(20).Bold().FontColor(Colors.Blue.Darken3);
    //                        if (!string.IsNullOrWhiteSpace(complaintNumber))
    //                            col.Item().Text(complaintNumber).FontSize(10).FontColor(Colors.Grey.Darken1);
    //                    });

    //                    row.ConstantItem(170).Column(col =>
    //                    {
    //                        col.Item().AlignRight().Text("BILL").FontSize(26).Bold();
    //                        col.Item().AlignRight().Text($"Bill #: {bill.BillID}");
    //                        col.Item().AlignRight().Text($"Bill Date: {bill.BillDate:dd-MM-yyyy}");
    //                    });
    //                });

    //                // ---------- Content ----------
    //                page.Content().PaddingVertical(20).Column(col =>
    //                {
    //                    col.Spacing(18);

    //                    // Customer + dates
    //                    col.Item().Row(row =>
    //                    {
    //                        row.RelativeItem().Column(c =>
    //                        {
    //                            c.Item().Text("BILLED TO").FontSize(9).Bold().FontColor(Colors.Grey.Darken1);
    //                            c.Item().Text(customer.CustomerName).FontSize(14).Bold();
    //                            if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
    //                                c.Item().Text(customer.PhoneNumber);
    //                            if (!string.IsNullOrWhiteSpace(customer.Address))
    //                                c.Item().Text(customer.Address);
    //                            c.Item().Text($"Customer ID: {customer.CustomerID}").FontSize(9).FontColor(Colors.Grey.Darken1);
    //                        });

    //                        row.ConstantItem(200).Column(c =>
    //                        {
    //                            c.Item().Text("BILL DETAILS").FontSize(9).Bold().FontColor(Colors.Grey.Darken1);
    //                            c.Item().Text(t =>
    //                            {
    //                                t.Span("Due Date: ").SemiBold();
    //                                t.Span(FormatDate(bill.DueBillDate));
    //                            });
    //                            c.Item().Text(t =>
    //                            {
    //                                t.Span("Paid On: ").SemiBold();
    //                                t.Span(FormatDate(bill.BillPaidDate));
    //                            });
    //                            c.Item().Text(t =>
    //                            {
    //                                t.Span("Status: ").SemiBold();
    //                                t.Span(bill.Status).Bold().FontColor(statusColor);
    //                            });
    //                        });
    //                    });

    //                    // Amount table
    //                    col.Item().Table(table =>
    //                    {
    //                        table.ColumnsDefinition(c =>
    //                        {
    //                            c.RelativeColumn(3);
    //                            c.RelativeColumn(1);
    //                        });

    //                        table.Header(h =>
    //                        {
    //                            h.Cell().Element(HeaderCell).Text("Description").Bold();
    //                            h.Cell().Element(HeaderCell).AlignRight().Text("Amount").Bold();
    //                        });

    //                        table.Cell().Element(BodyCell).Text("Total bill amount");
    //                        table.Cell().Element(BodyCell).AlignRight().Text(Money(bill.Amount));

    //                        table.Cell().Element(BodyCell).Text("Amount paid");
    //                        table.Cell().Element(BodyCell).AlignRight().Text(Money(bill.PaidAmount));

    //                        table.Cell().Element(TotalCell).Text("Remaining balance").Bold();
    //                        table.Cell().Element(TotalCell).AlignRight().Text(Money(bill.RemainingAmount)).Bold().FontColor(statusColor);
    //                    });

    //                    // Short note
    //                    col.Item().Text(bill.RemainingAmount > 0
    //                            ? $"Please pay the remaining {Money(bill.RemainingAmount)} by {FormatDate(bill.DueBillDate)}."
    //                            : "This bill has been paid in full. Thank you!")
    //                        .Italic().FontColor(Colors.Grey.Darken2);
    //                });

    //                // ---------- Footer ----------
    //                page.Footer().BorderTop(1).BorderColor(Colors.Grey.Lighten1).PaddingTop(8).Row(row =>
    //                {
    //                    row.RelativeItem().Text($"Generated on {DateTime.Now:dd-MM-yyyy hh:mm tt}")
    //                        .FontSize(9).FontColor(Colors.Grey.Darken1);

    //                    row.RelativeItem().AlignRight().Text(x =>
    //                    {
    //                        x.DefaultTextStyle(s => s.FontSize(9).FontColor(Colors.Grey.Darken1));
    //                        x.Span("Page ");
    //                        x.CurrentPageNumber();
    //                        x.Span(" of ");
    //                        x.TotalPages();
    //                    });
    //                });
    //            });
    //        });
    //    }

    //    // ---------- Helpers ----------
    //    private static string Money(decimal value) => $"Rs. {value:N0}";

    //    private static string FormatDate(DateTime? date) => date?.ToString("dd-MM-yyyy") ?? "-";

    //    private static IContainer HeaderCell(IContainer c) =>
    //        c.Background(Colors.Grey.Lighten3).BorderBottom(1).BorderColor(Colors.Grey.Lighten1).Padding(8);

    //    private static IContainer BodyCell(IContainer c) =>
    //        c.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(8);

    //    private static IContainer TotalCell(IContainer c) =>
    //        c.Background(Colors.Grey.Lighten4).BorderBottom(1).BorderColor(Colors.Grey.Lighten1).Padding(8);
    //}
}
