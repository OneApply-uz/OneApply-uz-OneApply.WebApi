using BussnisLogicLayer.Extended;
using DTOAccessLayer.Dtos.CertificateDtos;
using DTOAccessLayer.Dtos.UserDtos;


namespace BussnisLogicLayer.Interfaces;

public interface ICertificateService
{
    Task<List<CertificateDto>> GetAllAsync();
    Task<CertificateDto> GetByIdAsync(int id);
    Task AddAsync(AddCertificateDto dto);
    Task DeleteAsync(int id);
    Task UpdateAsync(UpdateCertificateDto dto);
}
