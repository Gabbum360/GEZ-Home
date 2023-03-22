using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }    
        public string FirstName { get; set; } 
        public string SurName { get;set; }
        public string Email { get; set; }   
        public string MeansOfPayment { get; set; }
    }
}
