

using AutoMapper;
using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.CertificateDtos;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace BussnisLogicLayer.Services;

public class CertificateService(IUnitOfWork unitOfWork, IMapper mapper) : ICertificateService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task AddAsync(AddCertificateDto entity)
    {

        if (entity is null)
            throw new ArgumentNullException( "Certificate is null");

        var certificate = _mapper.Map<Certificate>(entity);

        if (!certificate.IsValidCertificate())
            throw new CustomException("Certificate is invalid");

        var certificates = await _unitOfWork.CertificateInterface.GetAllAsync();

        if (certificate.IsExistCertificate(certificates))
            throw new CustomException($"{certificate.Name} is already exist");
      
        await _unitOfWork.CertificateInterface.AddAsync(certificate);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var certificate = await _unitOfWork.CertificateInterface.GetByIdAsync(id);
        if (certificate is null)
        {
            throw new ArgumentNullException($"{certificate.Name} is null");
        }
        await _unitOfWork.CertificateInterface.DeleteAsync(certificate);
        await _unitOfWork.SaveAsync();
    }

    public async Task<List<CertificateDto>> GetAllAsync()
    {
        var certificates = await _unitOfWork.CertificateInterface.GetAllAsync();
        return _mapper.Map<List<CertificateDto>>(certificates);
    }

    public async Task<CertificateDto> GetByIdAsync(int id)
    {
        var certificate = await _unitOfWork.CertificateInterface.GetByIdAsync(id);
        return _mapper.Map<CertificateDto>(certificate);
    }

    public async Task UpdateAsync(UpdateCertificateDto entity)
    {
        if (entity is null)
            throw new ArgumentNullException(nameof(entity), "Certificate is null");

        var certificate = _mapper.Map<Certificate>(entity);

        if (!certificate.IsValidCertificate())
            throw new CustomException("Certificate is invalid");

        var certificates = await _unitOfWork.CertificateInterface.GetAllAsync();

        if (certificate.IsExistCertificate(certificates))
            throw new CustomException($"{certificate.Name} is already exist");

        await _unitOfWork.CertificateInterface.AddAsync(certificate);
        await _unitOfWork.SaveAsync();
    }
}
