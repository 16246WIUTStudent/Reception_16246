
//Student ID: 00016246

using System.Collections.Generic;
using System.Threading.Tasks;
using API_16246.Models;

namespace API_16246.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User> AddAsync(User user);
        Task<bool> UpdateAsync(User user);
        Task<bool> DeleteAsync(int id);
    }
}
