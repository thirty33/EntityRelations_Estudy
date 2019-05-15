using EntityRelations_EstudyOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations_EstudyOne.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        //Find a User
        // to return the current data from the database, if it exists.
        Task<User> FindByUserAndPassword(string _userName, string _password);
        Task<User> GetById(int id);
    }
}
