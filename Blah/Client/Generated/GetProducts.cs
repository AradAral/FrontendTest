using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Blah.Client
{
    public class GetProducts
        : IGetProducts
    {
        public GetProducts(
            IReadOnlyList<IProduct> products)
        {
            Products = products;
        }

        public IReadOnlyList<IProduct> Products { get; }
    }
}
