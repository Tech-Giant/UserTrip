using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagement.Models;
using TripManagement.ViewEntities;

namespace TripManagement.Repository
{
    public interface IExpenseInfoRepository
    {
        Task<List<ExpenseInfo>> GetAllExpenses();

        Task<ExpenseInfo> GetExpense(Guid expenseId);

        Task<int> CreateExpense(TripExpense tripExpense);

        Task UpdateExpense(ExpenseInfo expenseInfo);

        Task DeleteExpense(ExpenseInfo expenseDetails);
    }
}
