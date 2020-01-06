using System;
using System.Collections.Generic;

namespace TripManagement.Models
{
    public partial class ExpenseInfo
    {
        public Guid ExpenseInfoId { get; set; }
        public int Money { get; set; }
        public string Currency { get; set; }
        public byte? CurrencyCode { get; set; }
        public byte? DebitCreditIndicator { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
