using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Blah.Client
{
    public class Product
        : IProduct
    {
        public Product(
            int id, 
            string title, 
            int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; }

        public string Title { get; }

        public int Price { get; }
    }
}
