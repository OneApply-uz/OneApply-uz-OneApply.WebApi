using DTOAccessLayer.Dtos.WorkExperienceDtos;

namespace BussnisLogicLayer.Interfaces
{
    public interface IWorkExperienceService
    {
        Task<List<WorkExperienceDto>> GetAllWorkExperience();
        Task<WorkExperienceDto> GetByWorkId(int id);
        Task AddWorkExperienceAsync(AddWorkExperienceDto addWorkExperience);
        Task UpdateWorkExperience(UpdateWorkExperienceDto updateWorkExperienceDto);
        Task DeleteWorkAsync(int id);
    }
}
