﻿using Microsoft.EntityFrameworkCore;

namespace GEZ.Core.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }    
        public string FirstName { get; set; } 
        public string SurName { get;set; }
        public string Email { get; set; }   
        public string MeansOfPayment { get; set; }

        /*public async Task<Customer> CreateCustomerDetails(string firstName, string surName, string email, string meansOfPayment)
        {
            var customer = new Customer();
            customer.FirstName = firstName;
            this.SurName = surName;
            customer.Email = email;
            customer.MeansOfPayment = meansOfPayment;
            return customer;
        }*/

        /*public string GenerateMeansOfPayment(string paymentType)
        {
            var pay = "gezH (${})";
        }*/
    }
}
