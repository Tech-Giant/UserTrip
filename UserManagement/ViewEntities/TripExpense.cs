using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagement.Models;

namespace TripManagement.ViewEntities
{
    public class TripExpense : ExpenseInfo
    {
        public Guid UserId { get; set; }

        public Guid TripId { get; set; }
    }
}
