using System;
using System.Collections.Generic;

namespace TripManagement.Models
{
    public partial class UserExpenseInfo
    {
        public Guid UserExpenseInfoId { get; set; }
        public Guid UserId { get; set; }
        public Guid ExpenseInfoId { get; set; }
        public string Note { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
