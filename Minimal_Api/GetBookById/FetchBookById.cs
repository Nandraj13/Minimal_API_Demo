using MediatR;

namespace Minimal_Api.GetBookById
{
    public class FetchBookById<TIn, TOut> : IPipelineBehavior<TIn, TOut> where TIn : GetBookByIdQuery
    {
        public async Task<TOut> Handle(TIn request, RequestHandlerDelegate<TOut> next, CancellationToken cancellationToken)
        {
            Console.WriteLine("Requested book id is: "+request.Id);
            if(request.Id==2)
            {
                request.Author = "Nandraj";
                request.Title = "Bhadar Tara Vehta Pani";
                request.Description = "Best Gujarati Film Ever";
            }
            else
            {
                request.Author = "null";
                request.Title = "null";
                request.Description = "null";
            }
            return await next();
        }
    }
}
