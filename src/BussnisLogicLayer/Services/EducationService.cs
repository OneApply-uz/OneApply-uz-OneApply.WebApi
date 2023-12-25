using AutoMapper;
using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.EducationDtos;
using DTOAccessLayer.Dtos.UserDtos;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLogicLayer.Services;

public class EducationService(IUnitOfWork unitOfWork, IMapper mapper) : IEducationService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    //for check Education name
    //Agar education nomida raqam bo'lsa xatolik berish uchun !!!
    public static bool IsNumber(string input)
    {
        return double.TryParse(input, out _);
    }
    public async Task AddEducationAsync(AddEducationDto addEducation)
    {
        if (addEducation == null)
        {
            throw new ArgumentNullException("Education name is null!");
        }
        if (IsNumber(addEducation.Name))
        {
            throw new CustomException("Education name can't be number!");
        }
        if (addEducation.EndDate == null || addEducation.StartDate == null)
        {
            throw new ArgumentNullException("EndaDate and Startdate is null");
        }
        var education = _mapper.Map<Education>(addEducation);
        if (!education.IsValid())
        {
            throw new CustomException("Invalid education");
        }
        await _unitOfWork.EducationInterface.AddAsync(education);
        await _unitOfWork.SaveAsync();
    }


    public async Task<List<EducationDto>> GetAllEducationAsync()
    {
        var educations = await _unitOfWork.EducationInterface.GetAllAsync();
        return educations.Select(e => _mapper.Map<EducationDto>(e)).ToList();
    }

    public async Task<EducationDto> GetByEducationId(int id)
    {
        var education = await _unitOfWork.EducationInterface.GetByIdAsync(id);
        if (education == null)
        {
            throw new ArgumentNullException("Education is null");
        }
        return _mapper.Map<EducationDto>(education);
    }

    public async Task UpdateEducation(UpdateEducationDto updateEducation)
    {
        if (updateEducation == null)
        {
            throw new ArgumentNullException("Education is null");
        }
        var educations = await _unitOfWork.EducationInterface.GetAllAsync();
        var education = await _unitOfWork.EducationInterface.GetByIdAsync(updateEducation.Id);
        if (education == null)
        {
            throw new ArgumentNullException("Education is null");
        }
        var update = _mapper.Map<Education>(updateEducation);
        if (!update.IsValid())
        {
            throw new CustomException("Invalid Education");
        }
        await _unitOfWork.EducationInterface.UpdateAsync(update);
        await _unitOfWork.SaveAsync();

    }
    public async Task DeleteEducationAsync(int id)
    {
        var education = await _unitOfWork.UserInterface.GetByIdAsync(id);
        if (education is null)
        {
            throw new ArgumentNullException("User is null here");

        }
        await _unitOfWork.UserInterface.DeleteAsync(education);
        await _unitOfWork.SaveAsync();
    }
}
