using MediatR;
using Minimal_Api.Models;

namespace Minimal_Api.AddBooksApi
{
    public class AddBooksRoute
    {

        public static void setup(WebApplication webApplication)
        {
           
            webApplication.MapPost("/AddBook",async (Books book,IMediator m ) =>
            {
                try
                {
                    var result = await m.Send(new AddBooksCommand(book));
                    return result.Success;
                }
                catch (Exception ex){
                    Console.WriteLine(ex);
                }
                return false;
                
            });
        }
    }
}