using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.ApplicationService.Enums
{
    public enum PaymentType
    {
        Cash = 2,
        BankTransfer = 1,
        Cheque =3,
        Trade = 4

    }
    public enum PaymentPlan
    {
        PayAfterService = 1,
        PayBeforeService = 2,
        PartPayment = 3,
    }
}
