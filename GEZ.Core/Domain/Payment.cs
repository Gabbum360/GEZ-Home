using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Core.Domain
{
    public class Payment
    {
        public int Id { get;set; }
        public PaymentType PaymentMethod { get;set; }
        public decimal AmountReceived { get; private set; }
        public DateTime Date { get; private set; }
        public enum PaymentType
        {
            Cash,
            Cheque,
            Transfer,
        }
    }
}
