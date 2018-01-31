using HomeBudgetTrackingSystem.CrossCutting;
using HomeBudgetTrackingSystem.DTO;
using HomeBudgetTrackingSystem.Models;

namespace HomeBudgetTrackingSystem.Query
{
    public class CreateExpenditure : IQuery<Expense>
    {
        private readonly Expenditure Expenditure;

        public CreateExpenditure(Expenditure expenditure)
        {
            Expenditure = expenditure;
        }

        public Expense Execute(BudgetContext data)
        {
            var expenses = new Expense { ExpenseDollars = 1.5M };
            data.Expenses.Add(expenses);
            data.SaveChanges();

            return expenses;
        }
    }
}
