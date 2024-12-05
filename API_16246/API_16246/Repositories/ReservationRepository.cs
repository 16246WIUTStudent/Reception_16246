
//Student ID: 00016246

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_16246.Models;
using Microsoft.EntityFrameworkCore;

namespace API_16246.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ReceptionDbContext _context;

        public ReservationRepository(ReceptionDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await _context.Reservations.ToListAsync();
        }

        public async Task<Reservation?> GetByIdAsync(int id)
        {
            return await _context.Reservations.FindAsync(id);
        }

        public async Task<Reservation> AddAsync(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            return reservation;
        }

        public async Task<bool> UpdateAsync(Reservation reservation)
        {
            var existingReservation = await _context.Reservations.FindAsync(reservation.ReservationId);
            if (existingReservation == null) return false;

            existingReservation.RoomId = reservation.RoomId;
            existingReservation.GuestId = reservation.GuestId;
            existingReservation.CheckInDate = reservation.CheckInDate;
            existingReservation.CheckOutDate = reservation.CheckOutDate;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null) return false;

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
