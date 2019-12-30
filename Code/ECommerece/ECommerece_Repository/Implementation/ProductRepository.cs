using ECommerece_Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerece_Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        public int GetProductCount()
        {
            return 5;
        }
    }
}
