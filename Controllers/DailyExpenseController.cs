using HomeBudgetTrackingSystem.CrossCutting;
using HomeBudgetTrackingSystem.DTO;
using HomeBudgetTrackingSystem.Models;
using HomeBudgetTrackingSystem.Query;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeBudgetTrackingSystem.Controllers
{
    [Produces("application/json")]
    [Route("api/DailyExpense/{Id}")]
    public class DailyExpenseController : Controller
    {
        private readonly IQueryExecutor queryExecutor;

        public DailyExpenseController(IQueryExecutor queryExecutor)
        {
            this.queryExecutor = queryExecutor;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateExpense(long Id, [FromBody] Expenditure expenditure)
        {
            var findEntity = new FindEntityQuery<Expense>(Id);
            var find = queryExecutor.Execute(findEntity);

            /*if (find == null)
                return NotFound();*/


            var createExpenses = new CreateExpenditure(expenditure);
            var expenses = queryExecutor.Execute(createExpenses);
            return Ok(expenses);
        }

        /*If I write this method, it will result in 500 Error, because this method has id which is confusing 
         with the variable Id declared with Controller*/
        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        [HttpGet("{id2}")]
        public string Get(long id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

    }
}