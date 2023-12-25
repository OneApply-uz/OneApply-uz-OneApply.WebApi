﻿
using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.WorkExperienceDtos;

public class UpdateWorkExperienceDto:BaseDto
{
    [Required(ErrorMessage = "CompanyName is required")]
    [StringLength(500, ErrorMessage = "CompanyName length must be between 3 and 500 characters", MinimumLength = 3)]
    public string CompanyName { get; set; } = string.Empty;

    [Required(ErrorMessage = "CompanyUrl is required")]
    [StringLength(500, ErrorMessage = "CompanyUrl length must be between 3 and 500 characters", MinimumLength = 3)]
    public string CompanyUrl { get; set; } = string.Empty;

    [Required(ErrorMessage = "Position is required")]
    [StringLength(500, ErrorMessage = "Position length must be between 3 and 500 characters", MinimumLength = 3)]
    public string Position { get; set; } = string.Empty;

    public EmploymentType EmploymentType { get; set; } = 0;

    [Required(ErrorMessage = "Description is required")]
    [StringLength(2000, ErrorMessage = "Description length must be between 3 and 2000 characters", MinimumLength = 3)]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "UserId is required")]

    public int UserId { get; set; }
}
