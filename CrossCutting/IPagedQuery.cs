using HomeBudgetTrackingSystem.Models;

namespace HomeBudgetTrackingSystem.CrossCutting
{
    public interface IPagedQuery<out T>
    {
        T Execute(BudgetContext data, int numberOfItems, int page);

        bool NextPageHasData();
    }
}
