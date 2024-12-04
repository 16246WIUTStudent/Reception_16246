using API_16246.Models;

namespace API_16246.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ReceptionDbContext context) : base(context)
        {
        }
        // Implement Reservation-specific methods here if needed
    }
}
