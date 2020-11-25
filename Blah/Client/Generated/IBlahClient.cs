using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace Blah.Client
{
    public interface IBlahClient
    {
        Task<IOperationResult<IGetProducts>> GetProductsAsync();

        Task<IOperationResult<IGetProducts>> GetProductsAsync(
            CancellationToken cancellationToken);
    }
}
