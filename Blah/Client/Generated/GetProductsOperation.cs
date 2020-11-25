using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Blah.Client
{
    public class GetProductsOperation
        : IOperation<IGetProducts>
    {
        public string Name => "GetProducts";

        public IDocument Document => Queries.Default;

        public Type ResultType => typeof(IGetProducts);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
