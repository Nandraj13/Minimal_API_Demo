using MediatR;
using Minimal_Api.Models;

namespace Minimal_Api.AddBooksApi
{
    public class FetchBookStallId<TIn, TOut> : IPipelineBehavior<TIn, TOut> where TIn:Books
    {
        public async Task<TOut> Handle(TIn request, RequestHandlerDelegate<TOut> next, CancellationToken cancellationToken)
        {
            Console.WriteLine("pipeline executed");
            return await next();
        }
    }
}
