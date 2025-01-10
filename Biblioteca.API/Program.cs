using Biblioteca.Application.Commands.BookCommands;
using Biblioteca.Core.DTOs;
using Biblioteca.Core.Repositories;
using Biblioteca.Infrastructure.Persistence;
using Biblioteca.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("BibliotecaCs");

builder.Services.AddDbContext<BibliotecaDbContext>(options =>
options.UseSqlServer(connectionString));
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILoanRepository, LoanRepository>();
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
