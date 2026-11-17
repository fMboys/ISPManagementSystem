namespace Core.DTOs
{
    public class InvoicePDFDto
    {
        public string? CompanyName { get; set; }
        public string? ComplaintNumber { get; set; }
        public string? FileName { get; set; }
        public string? PackageName { get; set; }
        public decimal? LateFee { get; set; }
        public string? Logopath { get; set; }
        public string? QRpath { get; set; }
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? CNIC { get; set; }
        public string? Package { get; set; }
        public decimal? Amount { get; set; }
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
    }
}
