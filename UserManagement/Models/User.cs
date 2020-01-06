using System;
using System.Collections.Generic;

namespace TripManagement.Models
{
    public partial class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserProof { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
