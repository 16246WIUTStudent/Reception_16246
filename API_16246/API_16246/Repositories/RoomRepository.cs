using API_16246.Models;

namespace API_16246.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(ReceptionDbContext context) : base(context)
        {
        }
        // Add Room-specific implementations if needed
    }
}
