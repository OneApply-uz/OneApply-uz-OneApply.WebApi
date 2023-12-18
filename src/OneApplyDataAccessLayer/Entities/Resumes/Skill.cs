

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneApplyDataAccessLayer.Entities.Resumes;

public class Skill:BaseEntity
{
    [Required, MinLength(1), MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [ForeignKey(nameof(User)), Column("UserId")]
    public int UserId { get; set; }
    public User User { get; set; }

}

