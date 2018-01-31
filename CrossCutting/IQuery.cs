using HomeBudgetTrackingSystem.Models;

namespace HomeBudgetTrackingSystem.CrossCutting
{
    public interface IQuery<out T>
    {
        T Execute (BudgetContext data);
        /*MYU : If 'out T' is not given, then the type of namespace T could not be found in Execute method OR 
          T Execute<T>(BudgetContext data); should be given*/
    }

}
