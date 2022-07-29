using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedModelView.Models
{
    public class ProductData
    {
        public IEnumerable<Product> ProductsList 
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                    new Product() { Pid=101,Name="img 1",Price = 10.0 },
                    new Product() { Pid=102,Name="img 2",Price = 12.0 },
                    new Product() { Pid=103,Name="img 3",Price = 11.0 },
                    new Product() { Pid=104,Name="img 4",Price = 13.0 }
                };
                return products;
            }
            
        }  
    }
}