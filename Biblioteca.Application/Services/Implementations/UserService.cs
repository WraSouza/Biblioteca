using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Biblioteca.Core.Entities;
using Biblioteca.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Services.Implementations
{
    public class UserService : IUsuarioService
    {
        private readonly BibliotecaDbContext _dbContext;
        public UserService(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(CreateUserInputModel model)
        {
            var user = new Usuario(model.Nome, model.Email);

            _dbContext?.Usuarios?.Add(user);

            return user.Id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
