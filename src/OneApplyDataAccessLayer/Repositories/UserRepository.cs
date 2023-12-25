using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneApplyDataAccessLayer.Repositories;

public class UserRepository : Repository<User>, IUserInterface
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
