using Ecommerece_BAL.Interfaces;
using Ecommerece_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerece_BAL.Implementation
{
    public class OrderBusiness : IOrderBusiness
    {
        public void PlaceOrder(OrderDTO orderDTO)
        {
            IPaymentService paymentService = null;
            switch (orderDTO.PaymentType)
            {
                case 1:
                    paymentService = new CashOnDelivery();
                    break;
                case 2:
                    paymentService = new PayPalPaymentService();
                    break;
            }

            paymentService.Checkout();

            paymentService.Success();

            // Database 
        }
    }
}
