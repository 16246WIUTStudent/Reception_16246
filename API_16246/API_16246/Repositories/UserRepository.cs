
//Student ID: 00016246

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_16246.Models;
using Microsoft.EntityFrameworkCore;

namespace API_16246.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ReceptionDbContext _context;

        public UserRepository(ReceptionDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            var existingUser = await _context.Users.FindAsync(user.UserId);
            if (existingUser == null) return false;

            existingUser.UserName = user.UserName;
            //existingUser.Password = user.Password;
            existingUser.Role = user.Role;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
