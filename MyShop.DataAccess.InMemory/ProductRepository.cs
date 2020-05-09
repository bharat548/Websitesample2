using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Core.Models;

namespace MyShop.DataAccess.InMemory
{
    class ProductRepository
    {
        Objectcache cache = MemoryCache.Default;
        List<Product> products = new List<Product>();
        public ProductRepository()
        {
            products = cache("products") as List<Product>;
            if (products = null)
            {
                products = new List<Product>();

            }
        }

        private List<Product> cache(string v)
        {
            throw new NotImplementedException();
        }
    }
}
