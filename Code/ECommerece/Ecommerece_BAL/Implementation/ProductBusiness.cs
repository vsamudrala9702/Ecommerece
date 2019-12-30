using Ecommerece_BAL.Interfaces;
using ECommerece_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerece_BAL.Implementation
{
    public class ProductBusiness : IProductBusiness
    {
        public IProductRepository _iProductRepository { set; get; }
        public ProductBusiness(IProductRepository productRepository)
        {
            _iProductRepository = productRepository;
        }

        public int GetProductCount()
        {
            var notification = Notifications.GetInstance();
            return _iProductRepository.GetProductCount();
        }
    }
}
