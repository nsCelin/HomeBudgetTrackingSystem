using Autofac;
using Autofac.Extensions.DependencyInjection;
using HomeBudgetTrackingSystem.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HomeBudgetTrackingSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            /*services.AddDbContext<BudgetContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("BudgetConnection")
        )); */

            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterModule(new RepositoryHandlerModule());
            //builder.RegisterType<QueryExecutor>().As<IQueryExecutor>(); //Either we can register all classes here
            ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(ApplicationContainer); 
        }

        public IContainer ApplicationContainer { get; private set; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime appLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            appLifetime.ApplicationStopped.Register(() => ApplicationContainer.Dispose());
        }
    }
}
