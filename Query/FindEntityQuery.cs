using HomeBudgetTrackingSystem.CrossCutting;
using HomeBudgetTrackingSystem.Models;

namespace HomeBudgetTrackingSystem.Query
{
    public class FindEntityQuery<T> : IQuery<T> where T:Entity
    {
        private readonly long Id;
        public FindEntityQuery(long id)
        {
            Id = id;
        }

        public T Execute(BudgetContext context)
        {
            return context.Set<T>().Find(Id);
        }
    }
}
