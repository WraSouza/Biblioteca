using Biblioteca.Application.Commands.BookCommands;
using Biblioteca.Application.Queries.GetAllBooks;
using Biblioteca.Application.Services.Implementations;
using Biblioteca.Application.Services.Interfaces;
using Biblioteca.Core.DTOs;
using Biblioteca.Core.Repositories;
using Biblioteca.Infrastructure.Persistence;
using Biblioteca.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("BibliotecaCs");

builder.Services.AddDbContext<BibliotecaDbContext>(options =>
options.UseSqlServer(connectionString));
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ILoanService, LoanService>();
builder.Services.AddScoped<IUsuarioService, UserService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(typeof(InsertBookCommand).Assembly); });
builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(typeof(BookDTO).Assembly); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseSwagger(options =>
    //{
    //    options.RouteTemplate = "openapi/{documentName}.json";
    //});
    //app.UseSwaggerUI();
   
}

//app.MapScalarApiReference();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
