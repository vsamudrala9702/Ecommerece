using Ecommerece_BAL.Implementation;
using Ecommerece_BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerece.Controllers
{
    public class ManageProductsController : Controller
    {
        //public IProductBusiness iProductBusiness { set; get; }
        private readonly IProductBusiness _iProductBusiness;
        private readonly IOrderBusiness _iOrderBusiness;
        private readonly int a = 10;
        private const int b = 10;
        public ManageProductsController(IProductBusiness iProductBusiness, IOrderBusiness iOrderBusiness)
        {
            _iProductBusiness = iProductBusiness;
            _iOrderBusiness = iOrderBusiness;
            a = 20;
        }

        public ActionResult Index()
        {
            //IProductBusiness iproduct = new ProductBusiness();


            var count = _iProductBusiness.GetProductCount();

            return View();
        }
    }
}