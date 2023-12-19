﻿

using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DTOAccessLayer.Dtos.VacanceDtos.ApplyDtos;

public class UpdateApplyDto:BaseDto
{
    [Required(ErrorMessage = "JobId is required")]
    public int JobId { get; set; }

    [Required(ErrorMessage = "UserId is required")]
    public int UserId { get; set; }

    public ApplyStatus Status { get; set; }
}
