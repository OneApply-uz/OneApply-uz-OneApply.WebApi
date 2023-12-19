using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class UserRepository : Repository<User>, IUserInterface
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
