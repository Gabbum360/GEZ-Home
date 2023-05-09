using GEZ.ApplicationService.Customer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.ApplicationService.Customer.UseCases.Commands
{
    public class RegisterNewCustomerCommand
    {
        public AddCustomerDto addCustomerDto { get; set; }

        /*private readonly GezDatabaseContext<RegisterNewCustomerCommand> _gezDatabaseContext
        public RegisterNewCustomerCommand()
        {
         
        }*/
        public async Task<AddCustomerDto> RegisterCustomer( AddCustomerDto model)
        {
            var customer = new Core.Domain.Customer();
            addCustomerDto.FirstName = model.FirstName;
            addCustomerDto.SurName = model.SurName;
            addCustomerDto.Email = model.Email;
            


        }

    }
}
