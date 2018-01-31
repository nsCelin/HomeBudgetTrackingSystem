using Microsoft.EntityFrameworkCore;

namespace HomeBudgetTrackingSystem.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext() : base()
        {

        }
        /*public BudgetContext(DbContextOptions<BudgetContext> options) : base(options)
        {

        }*/

        /*Helps in selecting and configuring the data source to be used with a context*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;"); from Google
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=BudgetContextDB;Integrated Security=False;MultipleActiveResultSets=True;");
        }

        /*Allows us to configure the model using ModelBuilder Fluent API.*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
    