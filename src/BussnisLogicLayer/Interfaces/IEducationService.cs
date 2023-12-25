using DTOAccessLayer.Dtos.EducationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLogicLayer.Interfaces
{
    public interface IEducationService
    {
        Task<List<EducationDto>> GetAllEducationAsync();
        Task<EducationDto> GetByEducationId(int id);
        Task AddEducationAsync(AddEducationDto addEducation);
        Task UpdateEducation(UpdateEducationDto updateEducation);
        Task DeleteEducationAsync(int id);
    }
}
