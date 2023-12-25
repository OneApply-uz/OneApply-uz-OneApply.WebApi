

using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class WorkExparinceRepository : Repository<WorkExperience>, IWorkExperienceInterface
{
    public WorkExparinceRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
