using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneApplyDataAccessLayer.Entities.Resumes;

public class Education : BaseEntity
{
    [Required, MinLength(3), MaxLength(500)]
    public string Name { get; set; } = string.Empty;

    public LevelOfDegreeType LevelOfDegree { get; set; }

    [MinLength(3), MaxLength(500)]
    public string Specialty { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool Present { get; set; }

    [ForeignKey(nameof(User)), Column("UserId")]
    public int UserId { get; set; }

    // Add navigation property to User
    public User User { get; set; }
}