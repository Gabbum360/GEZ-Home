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
        public string MeansOfPayment { get;set; }
        public decimal MoneyReceived { get;set; }
        public DateTime Date { get;set; }
    }
}
