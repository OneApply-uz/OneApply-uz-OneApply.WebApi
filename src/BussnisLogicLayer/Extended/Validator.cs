

using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Entities.Resumes;

namespace BussnisLogicLayer.Extended;

public static  class Validator
{
    public static bool IsValid(this User user)
        => user != null &&
           !string.IsNullOrEmpty(user.FullName) &&
           !string.IsNullOrEmpty(user.Title) &&
           !string.IsNullOrEmpty(user.About);

    public static bool IsExist(this User user, IEnumerable<User> users)
        => users.Any(u => u.FullName == user.FullName
                     && u.Id!=user.Id);



    public static bool IsValidCertificate(this Certificate certificate)
     => certificate != null &&
        !string.IsNullOrEmpty(certificate.Name) &&
        !string.IsNullOrEmpty(certificate.Url
         ) && certificate.UserId != 0;

    public static bool IsExistCertificate(this Certificate certificate, IEnumerable<Certificate> certificates)
        => certificates.Any(c => c.Name == certificate.Name
                             && c.Id != certificate.Id);
}
