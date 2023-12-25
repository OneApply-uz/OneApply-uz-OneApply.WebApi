﻿using Microsoft.EntityFrameworkCore;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Entities.Vacancies;

namespace OneApplyDataAccessLayer.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext
        (DbContextOptions<ApplicationDbContext> options ) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Certificate>()
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(555);

        modelBuilder.Entity<Certificate>()
            .Property(c => c.Url)
            .IsRequired()
            .HasMaxLength(555);

        modelBuilder.Entity<Certificate>()
            .HasOne(c => c.User)
            .WithMany(u => u.Certificates)
            .HasForeignKey(c => c.UserId);

        modelBuilder.Entity<Education>()
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(500);

        modelBuilder.Entity<Education>()
            .Property(e => e.Specialty)
            .HasMaxLength(500);

        modelBuilder.Entity<Education>()
            .HasOne(e => e.User)
            .WithMany(u => u.Educations)
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<Apply>()
            .HasKey(a => new { a.JobId, a.UserId });

        modelBuilder.Entity<Apply>()
            .HasOne(a => a.Job)
            .WithMany(j => j.Applies)
            .HasForeignKey(a => a.JobId);

        modelBuilder.Entity<Apply>()
            .HasOne(a => a.User)
            .WithMany(u => u.Applies)
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.NoAction); 

        modelBuilder.Entity<Job>()
            .Property(j => j.Title)
            .IsRequired()
            .HasMaxLength(500);

        modelBuilder.Entity<Job>()
            .Property(j => j.Location)
            .HasMaxLength(500);

        modelBuilder.Entity<Job>()
            .Property(j => j.Description)
            .HasMaxLength(2000);

        modelBuilder.Entity<Job>()
            .HasOne(j => j.User)
            .WithMany(u => u.Jobs)
            .HasForeignKey(j => j.UserId);



        base.OnModelCreating(modelBuilder);
    }
}
