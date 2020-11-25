using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blah.Server.Schema
{
    public class Query
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Title = "MacBook Pro 2020", Price = 5000000 },
                new Product { Id = 2, Title = "Surface Book 3", Price = 6000000 },
                new Product { Id = 3, Title = "iPhone 11", Price = 3000000 },
            };
        }
    }
}
