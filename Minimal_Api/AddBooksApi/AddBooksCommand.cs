using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Minimal_Api.Models;

namespace Minimal_Api.AddBooksApi
{
    public class AddBooksCommand:Books,IRequest<AddBooksResponseDto>
    {
        public Books book=new Books();
        public AddBooksCommand(Books book)
        {
            this.book = book;
        }
    }
    public class AddBooksHandler : IRequestHandler<AddBooksCommand,AddBooksResponseDto>
    {
        public AddBooksHandler()
        {

        }
        public async Task<AddBooksResponseDto> Handle(AddBooksCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"recieved data for saving: Id-{request.book.Id}, Author-{request.book.Author}, Title-{request.book.Description}, Description-{request.book.Description}");
            return new AddBooksResponseDto { Success= true};
        }
    }
}
