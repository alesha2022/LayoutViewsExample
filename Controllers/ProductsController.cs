using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViewsExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        [Route("Products/Details/{id:range(1,3)?}")]
        public ActionResult Details(int? id)
        {
            var products = new[]
            {
                new {ProductId=1,ProductName="IPhone", Cost=80000},
                new {ProductId=2,ProductName="Printer", Cost=7500},
                new {ProductId=3,ProductName="Camera", Cost=14000}

            };

            string prodName = "";
            if (id == null)
            {
                return Content("Please pass the appropriate Product ID");
            }
            else
            {
                foreach (var pro in products)
                {
                    if (pro.ProductId == id)
                    {
                        prodName = pro.ProductName;
                    }
                }
            }
            return Content(prodName);
        }
        [Route("Products/GetProductId/{productName}")]
        public ActionResult GetProductId(string productName)
        {
            var products = new[]
            {
                new {ProductId=1,ProductName="IPhone", Cost=80000},
                new {ProductId=2,ProductName="Printer", Cost=7500},
                new {ProductId=3,ProductName="Camera", Cost=14000}

            };
            int prodID = 0;
            if (productName == null)
            {
                return Content("Pass the appropriate Product Name");
            }

            else
            {
                foreach (var pro in products)
                {
                    if (pro.ProductName == productName)
                    {
                        prodID = pro.ProductId;
                    }
                }
            }
            return Content(prodID.ToString());
        }
    }
}