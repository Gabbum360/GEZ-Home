using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Address
    {
        public int Id { get; set; } = 001;
        public string Street { get; set; }
        public string City { get; set; }   
        public string Country { get; set; }
    }
}
