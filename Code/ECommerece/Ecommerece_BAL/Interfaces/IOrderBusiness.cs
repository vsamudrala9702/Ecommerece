using Ecommerece_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerece_BAL.Interfaces
{
    public interface IOrderBusiness
    {
        void PlaceOrder(OrderDTO orderDTO);
    }
}
