using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Blah.Client
{
    public interface IGetProducts
    {
        IReadOnlyList<IProduct> Products { get; }
    }
}
