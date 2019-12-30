using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerece_BAL.Interfaces
{
    public interface IPaymentService
    {
        void Checkout();

        void Success();

        void Error();
    }
}
