using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Address
    {
        public Address() { }

        public Address(string street, string houseNo, string city, string country)
        {
            this.Street = street;
            this.City = city;
            this.Country = country;
            this.HouseNo = houseNo;
        }

        public int Id { get; set; } = 001;
        public string Street { get; set; }
        public string HouseNo { get; private set; } 
        public string City { get; set; }   
        public string Country { get; set; }

        public abstract class AddressFactory
        {
            public Address CreateCustomer(string street, string houseNo, string city, string country)
            {
                return new Address(street, houseNo, city, country);
            }
        }

        /*public Address GenerateHouseNo(string house)
        {
            var 
        }*/
    }
}
