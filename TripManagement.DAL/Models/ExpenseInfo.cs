using System;

namespace TripManagement.DAL.Models
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
        public virtual TripDetails TripInfo { get; set; }
        public virtual User UserInfo { get; set; }

        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
