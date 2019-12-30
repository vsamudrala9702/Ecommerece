using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerece_DTO
{
    public class OrderDTO
    {
        public int ProductId { set; get; }
        public decimal Amount { set; get; }
        public int PaymentType { set; get; }
    }
}
