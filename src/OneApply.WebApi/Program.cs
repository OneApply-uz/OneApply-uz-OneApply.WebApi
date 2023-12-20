
using AutoMapper;
using BussnisLogicLayer.Interfaces;
using BussnisLogicLayer.Services;
using DTOAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;
using OneApplyDataAccessLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OneApplyDbWithIdentity")));
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseNpgsql(builder.Configuration.GetConnectionString("OneApplyDbWithIdentity")));


// Add Identity

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Add repositories and services
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ICertificateInterface, CertificateRepository>();
builder.Services.AddTransient<IEducationInterface, EducationRepository>();
builder.Services.AddTransient<ILanguageInterface, LanguageRepository>();
builder.Services.AddTransient<IProjectInterface, ProjectRepository>();
builder.Services.AddTransient<ISkillInterface, SkillRepository>();
builder.Services.AddTransient<ILinkInterface, LinkRepository>();

builder.Services.AddTransient<ICertificateService, CertificateService>();
builder.Services.AddTransient<IWorkExperienceInterface, WorkExparinceRepository>();

// Add AutoMapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication(); // Add this line to enable authentication

app.MapControllers();

app.Run();
