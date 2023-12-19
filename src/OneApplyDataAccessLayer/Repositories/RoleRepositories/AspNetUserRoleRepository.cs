using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Roles;
using OneApplyDataAccessLayer.Interfaces.RolesInterfaces;

namespace OneApplyDataAccessLayer.Repositories.RoleRepositories;

public class AspNetUserRoleRepository : Repository<AspNetUserRole>, IAspNetUserRoleInterface
{
    public AspNetUserRoleRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
