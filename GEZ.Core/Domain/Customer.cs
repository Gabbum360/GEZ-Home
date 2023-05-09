using Microsoft.EntityFrameworkCore;

namespace GEZ.Core.Domain
{
    public class Customer
    {
        public Customer() { }

        public Customer(Guid id, string firstname, string surname, string email, Payment meansPayment, Contract contractType)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.SurName = surname;
            this.Email = email; 
            this.MeansPayment = meansPayment;
            this.ContractType = contractType;
        }
        public Guid Id { get; set; }    
        public string FirstName { get; set; } 
        public string SurName { get;set; }
        public string Email { get; set; }   
        public Payment MeansPayment { get; }
        public Contract ContractType { get;}
        public List<Customer> ListCustomers { get; }   

        public static class CustomerFactory
        {
            public static Customer Create(Guid id, string firstname, string surname, string email, Payment meansPayment, Contract contractType)
            {
                return new Customer(id, firstname, surname, email, meansPayment, contractType);
            }
        }

        public Payment GeneratePaymentType(Payment payment)
        {
            var paymentType = new Payment();
            var result = paymentType.PaymentMethod;
            if (result == Payment.PaymentType.Cash)
                return paymentType;
            else if (result == Payment.PaymentType.Transfer)
                return paymentType;
            return payment;
        }
    }
}
