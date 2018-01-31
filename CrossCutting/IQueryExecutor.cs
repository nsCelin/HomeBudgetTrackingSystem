namespace HomeBudgetTrackingSystem.CrossCutting
{
    public interface IQueryExecutor
    {
        T Execute<T>(IQuery<T> query);

        T Execute<T>(IPagedQuery<T> query, int numberOfItems, int page);
    }
}
