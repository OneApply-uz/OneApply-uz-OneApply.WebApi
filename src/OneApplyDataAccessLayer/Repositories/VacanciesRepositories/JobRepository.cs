using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Vacancies;
using OneApplyDataAccessLayer.Interfaces.VacanciesInterfaces;

namespace OneApplyDataAccessLayer.Repositories.VacanciesRepositories;

public class JobRepository : Repository<Job>, IJobInterface
{
    public JobRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
