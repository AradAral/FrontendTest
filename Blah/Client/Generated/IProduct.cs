using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Blah.Client
{
    public interface IProduct
    {
        int Id { get; }

        string Title { get; }

        int Price { get; }
    }
}
