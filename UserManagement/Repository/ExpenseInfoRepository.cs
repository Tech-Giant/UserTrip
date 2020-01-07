using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TripManagement.Models;
using TripManagement.ViewEntities;

namespace TripManagement.Repository
{
    public class ExpenseInfoRepository : IExpenseInfoRepository
    {
        utdContext db;
        public ExpenseInfoRepository(utdContext _db)
        {
            db = _db;
        }

        public Task<int> CreateExpense(TripExpense trip)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteExpense(ExpenseInfo expenseDetails)
        {
            if (db != null)
            {
                db.ExpenseInfo.Remove(expenseDetails);
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<ExpenseInfo>> GetAllExpenses()
        {
            if (db != null)
            {
                return await db.ExpenseInfo.ToListAsync();
            }

            return null;
        }

        public Task UpdateExpense(ExpenseInfo expenseInfo)
        {
            throw new NotImplementedException();
        }

        Task<ExpenseInfo> IExpenseInfoRepository.GetExpense(Guid expenseId)
        {
            throw new NotImplementedException();
        }
    }
}
