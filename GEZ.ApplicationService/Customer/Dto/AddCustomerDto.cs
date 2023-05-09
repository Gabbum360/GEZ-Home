using GEZ.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.ApplicationService.Customer.Dto
{
    public class AddCustomerDto
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public Payment paymentType { get; }
        public Contract contractType { get; }
    }
}
