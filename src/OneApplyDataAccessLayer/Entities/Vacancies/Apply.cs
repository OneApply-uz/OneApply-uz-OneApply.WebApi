﻿

using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneApplyDataAccessLayer.Entities.Vacancies;

public class Apply:BaseEntity
{
    [ForeignKey(nameof(Job)), Column("JobId")]
    public int JobId { get; set; }

    [ForeignKey(nameof(User)), Column("UserId")]
    public string UserId { get; set; }


    public Job Job { get; set; } =new Job();
    public User User { get; set; } = new User();
    public ApplyStatus Status { get; set; }
}
