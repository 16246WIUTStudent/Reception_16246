
//Student ID: 00016246

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_16246.Models;
using Microsoft.EntityFrameworkCore;

namespace API_16246.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ReceptionDbContext _context;

        public RoomRepository(ReceptionDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room?> GetByIdAsync(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task<Room> AddAsync(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<bool> UpdateAsync(Room room)
        {
            var existingRoom = await _context.Rooms.FindAsync(room.RoomId);
            if (existingRoom == null) return false;

            existingRoom.RoomNumber = room.RoomNumber;
            existingRoom.RoomType = room.RoomType;
            existingRoom.PricePerNight = room.PricePerNight;
            existingRoom.Availability = room.Availability;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null) return false;

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
