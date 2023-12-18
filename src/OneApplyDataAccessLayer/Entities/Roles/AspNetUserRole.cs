using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace OneApplyDataAccessLayer.Entities.Roles;

public class AspNetUserRole : BaseEntity
{
    [Required]
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }

    [Required]
    [ForeignKey(nameof(Role))]
    public int RoleId { get; set; }

    public User User { get; set; } = new User();
    public AspNetRole Role { get; set; } = new AspNetRole();





}
