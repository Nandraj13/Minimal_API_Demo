using MediatR;
using Minimal_Api.Models;

namespace Minimal_Api.GetBookById
{
    public class GetBookByIdQuery:Books,IRequest<Books>
    {
    }
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, Books>
    {
        public async Task<Books> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {

            return new Books
            {
                Id = request.Id,
                Author = request.Author,
                Title = request.Title,
                Description = request.Description,
            };
        }
    }
}
