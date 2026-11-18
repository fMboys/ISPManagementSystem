namespace Core.DTOs
{
    public class InvoicePDFDto
    {
        public string? CompanyName { get; set; }
        public string? ComplaintNumber { get; set; }
        public string? FileName { get; set; }
        public string? PackageName { get; set; }
        public decimal LateFee { get; set; }
        public string? PathFile { get; set; }
        public string? PathLogo { get; set; }
        public string? PathQR { get; set; }
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? CNIC { get; set; }
        public string? Package { get; set; }
        public decimal Amount { get; set; } = 0.00m;
        public bool? IsActive { get; set; }
        public DateTime? ConnectionDate { get; set; }
        public int? BillID { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime DueBillDate { get; set; }
        public DateTime BillPaidDate { get; set; }
        public string? Status { get; set; }
        public string? IsPrint { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // ------ Finance Accounts Details ------

        public List<string> PaymentMethods { get; set; } = new List<string>() { "EasyPaisa", "Jazz"};
        public string? BankName { get; set; }
        public string? BankAccountTitle { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? EasyPaisaTitle { get; set; }
        public string? EasyPaisaNumber { get; set; }
        public string? JazzCashTitle { get; set; }
        public string? JazzCashNumber { get; set; }
    }
}
