using EntityRelations_EstudyOne.Domain.Repositories;
using EntityRelations_EstudyOne.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations_EstudyOne.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.Users.ToListAsync();
        }

        //Find a User Item into DB
        public async Task<User> FindByUserAndPassword(string _userName, string _password)
        {
            return await _context.Users.FirstOrDefaultAsync(i => i.Username == _userName && i.Password == _password);
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
