
//Student ID: 00016246

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_16246.Models;
using Microsoft.EntityFrameworkCore;

namespace API_16246.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly ReceptionDbContext _context;

        public GuestRepository(ReceptionDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Guest>> GetAllAsync()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest?> GetByIdAsync(int id)
        {
            return await _context.Guests.FindAsync(id);
        }

        public async Task<Guest> AddAsync(Guest guest)
        {
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();
            return guest;
        }

        public async Task<bool> UpdateAsync(Guest guest)
        {
            var existingGuest = await _context.Guests.FindAsync(guest.GuestId);
            if (existingGuest == null) return false;

            existingGuest.FirstName = guest.FirstName;
            existingGuest.Email = guest.Email;
            existingGuest.Phone = guest.Phone;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest == null) return false;

            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
