using MediatR;

namespace Minimal_Api.GetBooksApi
{
    public class GetBooksRoute
    {
        public static void setup(WebApplication webApplication)
        {
            webApplication.MapGet("/Books", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetBooksQuery());
                return result;
            });
        }
    }
}
