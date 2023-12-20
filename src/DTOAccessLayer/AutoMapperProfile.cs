
using AutoMapper;
using DTOAccessLayer.Dtos.CertificateDtos;
using DTOAccessLayer.Dtos.EducationDtos;
using DTOAccessLayer.Dtos.LanguageDtos;
using DTOAccessLayer.Dtos.LinkDtos;
using DTOAccessLayer.Dtos.ProjectDtos;

using DTOAccessLayer.Dtos.SkillDtos;
using DTOAccessLayer.Dtos.UserDtos;
using DTOAccessLayer.Dtos.VacanceDtos.ApplyDtos;
using DTOAccessLayer.Dtos.VacanceDtos.JobDtos;
using DTOAccessLayer.Dtos.WorkExperienceDtos;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Entities.Vacancies;

namespace DTOAccessLayer;

public class AutoMapperProfile:Profile
{
    public AutoMapperProfile()
    {
        // Add Certificate 1
        CreateMap<Certificate, CertificateDto>().ReverseMap();
        CreateMap<AddCertificateDto, Certificate>();
        CreateMap<UpdateCertificateDto, Certificate>();

        // Add Education 2
        CreateMap<Education, EducationDto>().ReverseMap();
        CreateMap<AddEducationDto, Education>();
        CreateMap<UpdateEducationDto, Education>();
        // Add Language 3
        CreateMap<Language, LanguageDto>().ReverseMap();
        CreateMap<AddLanguageDto, Language>();
        CreateMap<UpdateLanguageDto, Language>();

        //Add Link 4
        CreateMap<Link, LinkDto>().ReverseMap();
        CreateMap<UpdateLinkDto, Link>();
        CreateMap<AddLinkDto, Link>();

        //Add Project 5
        CreateMap<Project, ProjectDto>().ReverseMap();
        CreateMap<AddProjectDto, Project>();
        CreateMap<UpdateProjectDto,  Project>();


        //Add Skill 6
        CreateMap<Skill, SkillDto>().ReverseMap();
        CreateMap<AddSkillDto, Skill>();
        CreateMap<UpdateSkillDto, Skill>();

        // Add User 7
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<AddUserDto, User>();
        CreateMap<UpdateUserDto, User>();
        CreateMap<User, UserDetialDro>().ReverseMap();

        //Add Job 8
        CreateMap<Job, JobDto>().ReverseMap();
        CreateMap<AddJobDto, Job>();
        CreateMap<UpdateJobDto, Job>();
        // Add Apply 9
        CreateMap<Apply, ApplyDto>().ReverseMap();
        CreateMap<AddApplyDto, Apply>();
        CreateMap<UpdateApplyDto, Apply>();
        // Add WorkExperience 10
        CreateMap<WorkExperience , WorkExperienceDto>().ReverseMap();
        CreateMap<AddWorkExperienceDto, WorkExperience>();
        CreateMap<UpdateWorkExperienceDto , WorkExperience>();

    }
}
