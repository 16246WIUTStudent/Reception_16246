
//Student ID: 00016246

using System.Collections.Generic;
using System.Threading.Tasks;
using API_16246.Models;

namespace API_16246.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllAsync();
        Task<Room?> GetByIdAsync(int id);
        Task<Room> AddAsync(Room room);
        Task<bool> UpdateAsync(Room room);
        Task<bool> DeleteAsync(int id);
    }
}
