
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.RoleDtos.AspNetUserRoleDtos;

public class AddAspNetUserRoleDto
{
    [Required(ErrorMessage = "UserId is required")]
    public int UserId { get; set; }

    [Required(ErrorMessage = "RoleId is required")]
    public int RoleId { get; set; }
}
