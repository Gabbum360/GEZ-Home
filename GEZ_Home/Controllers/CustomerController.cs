using GEZ.Core.Domain;
using GEZ.Core.ViewModels;
using GEZ.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GEZ_Home.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private GezDatabaseContext _gezCustomerDb;
        public CustomerController(GezDatabaseContext context)
        {
            _gezCustomerDb = context;
        }

        [HttpPost("new-customer")]
        public async Task<Customer> AddCustomer([FromBody] AddCustomer model)
        {
            var customer = new Customer();
            customer.FirstName = model.FirstName;
            customer.SurName = model.SurName;
            customer.Email = model.Email;
            customer.MeansOfPayment = model.MeansOfPayment;

            _gezCustomerDb.Add(customer);
            await _gezCustomerDb.SaveChangesAsync();
            return customer;
        }

        [HttpGet("list-all-available-Customers")]
        public async Task<List<Customer>> GetRegisteredCustomers([FromBody] GetCustomers model)
        {
            List<Customer> customers = new List<Customer>();
            var customersFromDb = await _gezCustomerDb.Customers.ToListAsync();
            /*foreach (var customer in customersFromDb)
            {
                Console.WriteLine(customers);
            }*/
            return customersFromDb;   
        }

        /*public async Task<Customer> GetByName(Guid id, [FromBody]GetCustomers model)
        {
            var idAvailable = await _gezCustomerDb.Customers.Where(x => x.Id == id).ToListAsync();
            foreach (var item in idAvailable)
            {
                Console.WriteLine("this Customer is - " + model.FirstName);
            }
            return 
        }*/
    }
}