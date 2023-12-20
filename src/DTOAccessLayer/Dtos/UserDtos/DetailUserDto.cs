

using DTOAccessLayer.Dtos.CertificateDtos;
using DTOAccessLayer.Dtos.EducationDtos;
using DTOAccessLayer.Dtos.LanguageDtos;
using DTOAccessLayer.Dtos.LinkDtos;
using DTOAccessLayer.Dtos.ProjectDtos;
using DTOAccessLayer.Dtos.SkillDtos;
using DTOAccessLayer.Dtos.WorkExperienceDtos;

namespace DTOAccessLayer.Dtos.UserDtos;

public class DetailUserDto:UserDto
{
    public ICollection<CertificateDto> CertificateDtos { get; set; } = new List<CertificateDto>();
    public ICollection<EducationDto> EducationDtos { get; set; } = new List<EducationDto>();
    public ICollection<LanguageDto> LanguageDtos { get; set; } = new List<LanguageDto>();
    public ICollection<LinkDto> LinkDtos { get; set; } = new List<LinkDto>();
    public ICollection<ProjectDto> ProjectDtos { get; set; } = new List<ProjectDto>();
    public ICollection<SkillDto> SkillDtos { get; set; } = new List<SkillDto>();
    public ICollection<WorkExperienceDto> WorkExperienceDtos { get; set; } = new List<WorkExperienceDto>();

}
