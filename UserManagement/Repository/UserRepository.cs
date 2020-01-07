using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TripManagement.Models;

namespace TripManagement.Repository
{
    public class UserRepository : IUserRepository
    {
        utdContext db;
        public UserRepository(utdContext _db)
        {
            db = _db;
        }

        public async Task<List<User>> GetUsers()
        {
            if (db != null)
            {
                return await db.User.ToListAsync();
            }

            return null;
        }

        public async Task<Guid> AddUser(User user)
        {
            if (db != null)
            {
                await db.User.AddAsync(user);
                await db.SaveChangesAsync();

                return user.UserId;
            }

            return Guid.Empty;
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUser(User user)
        {
            if (db != null)
            {
                db.User.Remove(user);
                await db.SaveChangesAsync();
            }
        }

        public Task GetUser(Guid user)
        {
            throw new NotImplementedException();
        }
    }
}
