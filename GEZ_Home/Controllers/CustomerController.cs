using GEZ.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GEZ_Home.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CustomerController: ControllerBase
    {
        private readonly GezDatabaseContext _context;
        private readonly ILogger _logger; 
        public CustomerController(GezDatabaseContext context, ILogger logger)
        {
            _context = context; 
            _logger = logger;
        }

        /*public async Task<GetCustomer> Get(string firstName)
        {
            var cust = await _context.Customers.Select(d => d.FirstName == firstName).FirstOrDefaultAsync();
            return cust;
        }*/

    }
}
