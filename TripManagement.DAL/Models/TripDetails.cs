using System;

namespace TripManagement.DAL.Models
{
    public partial class TripDetails
    {
        public Guid TripId { get; set; }
        public string TripName { get; set; }
        public string TripDetails1 { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
