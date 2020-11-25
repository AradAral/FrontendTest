using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace Blah.Client
{
    public class BlahClient
        : IBlahClient
    {
        private readonly IOperationExecutor _executor;

        public BlahClient(IOperationExecutor executor)
        {
            _executor = executor ?? throw new ArgumentNullException(nameof(executor));
        }

        public Task<IOperationResult<IGetProducts>> GetProductsAsync() =>
            GetProductsAsync(CancellationToken.None);

        public Task<IOperationResult<IGetProducts>> GetProductsAsync(
            CancellationToken cancellationToken)
        {

            return _executor.ExecuteAsync(
                new GetProductsOperation(),
                cancellationToken);
        }
    }
}
