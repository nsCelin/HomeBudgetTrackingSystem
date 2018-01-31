using HomeBudgetTrackingSystem.Models;

namespace HomeBudgetTrackingSystem.CrossCutting
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly BudgetContext dataStore;

        public QueryExecutor(BudgetContext dataStore)
        {
            this.dataStore = dataStore;
        }

        public T Execute<T>(IQuery<T> query)
        {
            return query.Execute(dataStore);
        }

        public T Execute<T>(IPagedQuery<T> query, int numberOfItems, int page)
        {
            return query.Execute(dataStore, numberOfItems, page);
        }
    }
}
