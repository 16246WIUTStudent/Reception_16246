using API_16246.Models;

namespace API_16246.Repositories
{
    public class GuestRepository : Repository<Guest>, IGuestRepository
    {
        public GuestRepository(ReceptionDbContext context) : base(context)
        {
        }
        // Implement Guest-specific methods here if needed
    }
}
