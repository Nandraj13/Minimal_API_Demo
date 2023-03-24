using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Minimal_Api.Models;

namespace Minimal_Api.GetBookById
{
    public static class GetBookByIdRoute
    {
        public static void setup(WebApplication webApplication)
        {
            webApplication.MapGet("/Book/{id}",(int id, [FromServices]  IMediator mediator) =>{
                Books books= new Books();
                books.Id = id;
                var GetBookByIdQuery= books.Adapt<GetBookByIdQuery>();
                var result = mediator.Send(GetBookByIdQuery);
                return result;
            });
        }
    }
}
