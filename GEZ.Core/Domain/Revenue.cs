using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Revenue
    {
        public Guid Id { get; set; }
        public Decimal Amount { get; set; } 
       // public string Medium { get; set; }
        public string Description { get; set; }
        public DateTime DateReceived { get; set; }
       // public string Sender { get; set; }
        
    }
}
