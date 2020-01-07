using System;

namespace TripManagement.DAL.Models
{
    public partial class UserTripMapping
    {
        public Guid UserTripId { get; set; }
        public Guid UserId { get; set; }
        public Guid TripId { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
