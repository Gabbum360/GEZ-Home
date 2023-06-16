using GEZ.ApplicationService.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Customer
    {
        public Customer(){}
        public Customer(string firstName, string surName, string email, string phoneNumber, bool isWhatsApp, CustomerClass customerClass)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            SurName = surName;
            Email = email;
            PhoneNumber = phoneNumber;
            IsWhatsApp = isWhatsApp;
            CustomerClass = customerClass;
        }

        public Guid Id { get; set; }    
        public string FirstName { get; set; } 
        public string SurName { get;set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsWhatsApp { get; private set; }
        public CustomerClass CustomerClass { get; private set; }

        public abstract class Factory
        {
            public  Customer Create(string firstName, string surName, string email, string meansOfPayment, bool isWhatsApp, CustomerClass customerClass)
            {
                return new Customer(firstName, surName, email, meansOfPayment, isWhatsApp, customerClass);
            }
            
        }

       public Customer IsWhatsapp(bool whatsapp)
        {
            var whatsappNumber = this.IsWhatsapp(whatsapp);
            this.IsWhatsApp = whatsapp;
            return whatsappNumber;
        }
        /*public Customer SetCustomerClass(string custClass)
        {
            var result = CustomerClass.GetValues(string  )
        }*/
    }
}
