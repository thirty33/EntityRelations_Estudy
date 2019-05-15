using EntityRelations_EstudyOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations_EstudyOne.Domain.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> ListAsync();
        Task<IEnumerable<User>> GetAll();
        Task<User> ObtainUserByID(int id);
    }
}
