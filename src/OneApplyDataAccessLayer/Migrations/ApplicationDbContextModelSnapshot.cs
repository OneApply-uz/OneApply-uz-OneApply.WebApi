﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneApplyDataAccessLayer.Data;

#nullable disable

namespace OneApplyDataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(555)
                        .HasColumnType("nvarchar(555)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(555)
                        .HasColumnType("nvarchar(555)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LevelOfDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Present")
                        .HasColumnType("bit");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Lavel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CompanyUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("EmploymentType")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WorkExperience");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Vacancies.Apply", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("JobId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Apply");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Vacancies.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("EmploymentType")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("SalaryMax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalaryMin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Certificate", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Certificates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Education", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Language", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Languages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Link", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Project", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.Skill", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Resumes.WorkExperience", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Vacancies.Apply", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.Vacancies.Job", "Job")
                        .WithMany("Applies")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Applies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Vacancies.Job", b =>
                {
                    b.HasOne("OneApplyDataAccessLayer.Entities.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.User", b =>
                {
                    b.Navigation("Applies");

                    b.Navigation("Certificates");

                    b.Navigation("Educations");

                    b.Navigation("Jobs");

                    b.Navigation("Languages");

                    b.Navigation("Links");

                    b.Navigation("Projects");

                    b.Navigation("Skills");

                    b.Navigation("WorkExperiences");
                });

            modelBuilder.Entity("OneApplyDataAccessLayer.Entities.Vacancies.Job", b =>
                {
                    b.Navigation("Applies");
                });
#pragma warning restore 612, 618
        }
    }
}
