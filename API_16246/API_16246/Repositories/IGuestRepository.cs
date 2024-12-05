
//Student ID: 00016246

using System.Collections.Generic;
using System.Threading.Tasks;
using API_16246.Models;

namespace API_16246.Repositories
{
    public interface IGuestRepository
    {
        Task<IEnumerable<Guest>> GetAllAsync();
        Task<Guest?> GetByIdAsync(int id);
        Task<Guest> AddAsync(Guest guest);
        Task<bool> UpdateAsync(Guest guest);
        Task<bool> DeleteAsync(int id);
    }
}
