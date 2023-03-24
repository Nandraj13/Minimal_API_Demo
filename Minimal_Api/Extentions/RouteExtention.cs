using Minimal_Api.AddBooksApi;
using Minimal_Api.GetBookById;
using Minimal_Api.GetBooksApi;

namespace Minimal_Api.Extentions
{
    public static class RouteExtention
    {
        public static void AddRoutes(this WebApplication webApplication)
        {
            AddBooksRoute.setup(webApplication);
            GetBooksRoute.setup(webApplication);
            GetBookByIdRoute.setup(webApplication);
        }
    }
}
