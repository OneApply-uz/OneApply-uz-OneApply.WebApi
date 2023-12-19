using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Vacancies;
using OneApplyDataAccessLayer.Interfaces.VacanciesInterfaces;

namespace OneApplyDataAccessLayer.Repositories.VacanciesRepositories;

public class ApplyRepository : Repository<Apply>, IApplyInterface
{
    public ApplyRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
