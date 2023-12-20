using DTOAccessLayer.Dtos.CertificateDtos;
using DTOAccessLayer.Dtos.EducationDtos;
using DTOAccessLayer.Dtos.LanguageDtos;
using DTOAccessLayer.Dtos.LinkDtos;
using DTOAccessLayer.Dtos.ProjectDtos;
using DTOAccessLayer.Dtos.SkillDtos;
using DTOAccessLayer.Dtos.WorkExperienceDtos;
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.UserDtos;

public class UserDto:BaseDto
{
    [Required(ErrorMessage = "FullName is required")]
    [StringLength(100, ErrorMessage = "FullName length must be between 3 and 100 characters", MinimumLength = 3)]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Title is required")]
    [StringLength(200, ErrorMessage = "Title length must be between 3 and 200 characters", MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Location length must be between 3 and 500 characters", MinimumLength = 3)]
    public string Location { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "AvatarUrl length must be between 3 and 500 characters", MinimumLength = 3)]
    public string AvatarUrl { get; set; } = string.Empty;

    [StringLength(1000, ErrorMessage = "About length must be between 10 and 1000 characters", MinimumLength = 10)]
    public string About { get; set; } = string.Empty;


}
