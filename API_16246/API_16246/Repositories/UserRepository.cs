using API_16246.Models;

namespace API_16246.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ReceptionDbContext context) : base(context)
        {
        }
        // Implement User-specific methods here if needed
    }
}
