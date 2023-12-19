
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.SkillDtos;

public class AddSkillDto
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name length must be between 1 and 100 characters", MinimumLength = 1)]
    public string Name { get; set; }

    [Required(ErrorMessage = "UserId is required")]
    public int UserId { get; set; }
}
