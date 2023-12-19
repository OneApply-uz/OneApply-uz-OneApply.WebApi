using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Roles;
using OneApplyDataAccessLayer.Interfaces.RolesInterfaces;

namespace OneApplyDataAccessLayer.Repositories.RoleRepositories;

public class AspNetRoleRepository : Repository<AspNetRole>, IAspNetRolesInterface
{
    public AspNetRoleRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
