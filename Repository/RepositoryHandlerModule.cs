using Autofac;
using HomeBudgetTrackingSystem.CrossCutting;
using HomeBudgetTrackingSystem.Models;

namespace HomeBudgetTrackingSystem.Repository
{
    public class RepositoryHandlerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<QueryExecutor>().As<IQueryExecutor>().InstancePerLifetimeScope();
            builder.RegisterType<BudgetContext>().InstancePerLifetimeScope();
        }
    }
}
