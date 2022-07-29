using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedModelView.Models;

namespace StronglyTypedModelView.Controllers
{
    public class ProductsController : Controller
    {
        ProductData db = new ProductData();
        // GET: Products
        public ViewResult Index(int Pid)
        {
            //int prodid = 102;
            //will search the product that are matching with your id
            Product prod = db.ProductsList.Single(x => x.Pid == Pid);
            return View(prod);
        }
        public ViewResult Index1()
        {
            List<Product> list = db.ProductsList.ToList();
            return View(list);
        }
    }
}