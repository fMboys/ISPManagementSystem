using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities
{
    [Table("tblCustomers")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public int? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Package { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string? Status { get; set; }
        public DateTime? BillDate { get; set; }
        public DateTime? BillPaidDate { get; set; }
        public DateTime? DueBillDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
