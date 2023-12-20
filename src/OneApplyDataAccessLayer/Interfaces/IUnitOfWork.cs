namespace OneApplyDataAccessLayer.Interfaces;

public interface IUnitOfWork : IDisposable
{
    ICertificateInterface CertificateInterface { get; }
    IEducationInterface EducationInterface { get; }
    ILanguageInterface LanguageInterface { get; }
    ILinkInterface LinkInterface { get; }
    IProjectInterface ProjectInterface { get; }
    ISkillInterface SkillInterface { get; }
    IWorkExperienceInterface WorkExperienceInterface { get; }
    IUserInterface UserInterface { get; }
    Task SaveAsync();
}
