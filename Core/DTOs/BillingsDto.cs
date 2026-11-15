namespace Core.DTOs
{
    public class BillingsDto
    {
        public int? BillID { get; set; }
        public int? CustomerID { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime DueBillDate { get; set; }
        public DateTime BillPaidDate { get; set; }
        public string? Status { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
