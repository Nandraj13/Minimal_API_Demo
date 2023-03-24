using MediatR;
using Minimal_Api.AddBooksApi;
using Minimal_Api.Extentions;
using Minimal_Api.GetBookById;
using Minimal_Api.GetBooksApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IPipelineBehavior<,>),typeof(FetchBookStallId<,>));
builder.Services.AddScoped(typeof(IPipelineBehavior<,>),typeof(FetchBookById<,>));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddBooksCommand).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetBookByIdQuery).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetBooksQuery).Assembly));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.AddRoutes();
app.Run();


