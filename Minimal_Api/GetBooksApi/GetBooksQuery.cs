using MediatR;
using Minimal_Api.Models;

namespace Minimal_Api.GetBooksApi
{
    public class GetBooksQuery:Books, IRequest<IEnumerable<Books>>
    {
    }
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, IEnumerable<Books>>
    {
        public async Task<IEnumerable<Books>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            return new Books[]
            {
                new Books {Id=2,Author="Nandraj",Description="Great book",Title="Amul Buffalo"},
                new Books {Id=2,Author="Nandraj",Description="Great book",Title="Amul Buffalo"}
            };
        }
    }
}
