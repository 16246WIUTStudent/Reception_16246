
//Student ID: 00016246

using System.Collections.Generic;
using System.Threading.Tasks;
using API_16246.Models;

namespace API_16246.Repositories
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetAllAsync();
        Task<Reservation?> GetByIdAsync(int id);
        Task<Reservation> AddAsync(Reservation reservation);
        Task<bool> UpdateAsync(Reservation reservation);
        Task<bool> DeleteAsync(int id);
    }
}
