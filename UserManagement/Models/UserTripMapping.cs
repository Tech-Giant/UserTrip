using System;
using System.Collections.Generic;

namespace TripManagement.Models
{
    public partial class UserTripMapping
    {
        public Guid UserTripId { get; set; }
        public Guid UserId { get; set; }
        public Guid TripId { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
