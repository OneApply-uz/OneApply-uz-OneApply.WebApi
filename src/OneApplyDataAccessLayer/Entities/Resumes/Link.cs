﻿using OneApplyDataAccessLayer.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneApplyDataAccessLayer.Entities.Resumes;

public class Link:BaseEntity
{
    [Required, MinLength(1), MaxLength(500)]
    public string Url { get; set; } = string.Empty;
    
    public LinkType  Type { get; set; }

    [ForeignKey(nameof(Url)), Column("UserId")]
    public string  UserId { get; set; }

    public User User { get; set; }

}
