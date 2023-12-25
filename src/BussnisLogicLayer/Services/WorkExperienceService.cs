using AutoMapper;
using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.WorkExperienceDtos;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace BussnisLogicLayer.Services
{
    public class WorkExperienceService(IUnitOfWork unitOfWork, IMapper mapper) : IWorkExperienceService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IMapper _mapper = mapper;
       
        public async Task AddWorkExperienceAsync(AddWorkExperienceDto addWorkExperience)
        {
            if (addWorkExperience == null)
            {
                throw new ArgumentNullException("Work is null!");
            }
            var work = _mapper.Map<WorkExperience>(addWorkExperience);
            await _unitOfWork.WorkExperienceInterface.AddAsync(work);
            await _unitOfWork.SaveAsync();
        }
        public async Task DeleteWorkAsync(int id)
        {
            var work = await _unitOfWork.WorkExperienceInterface.GetByIdAsync(id);
            if (work is null)
            {
                throw new ArgumentNullException("WorkExperience is null here");

            }
            await _unitOfWork.WorkExperienceInterface.DeleteAsync(work);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<WorkExperienceDto>> GetAllWorkExperience()
        {
            var work = await _unitOfWork.WorkExperienceInterface.GetAllAsync();
            return work.Select(e => _mapper.Map<WorkExperienceDto>(e)).ToList();
        }

        public async Task<WorkExperienceDto> GetByWorkId(int id)
        {
            var  work = await _unitOfWork.WorkExperienceInterface.GetByIdAsync(id);
            if (work == null)
            {
                throw new ArgumentNullException("Work is null");
            }
            return _mapper.Map<WorkExperienceDto>(work);
        }

        public async Task UpdateWorkExperience(UpdateWorkExperienceDto updateWorkExperienceDto)
        {
            if (updateWorkExperienceDto == null)
            {
                throw new ArgumentNullException("Work is null");
            }
            var works = await _unitOfWork.WorkExperienceInterface.GetAllAsync();
            var workExperince = await _unitOfWork.WorkExperienceInterface.GetByIdAsync(updateWorkExperienceDto.Id);
            if (workExperince == null)
            {
                throw new ArgumentNullException("Work is null");
            }
            var update = _mapper.Map<WorkExperience>(updateWorkExperienceDto);
            if (!update.IsValidWorkExperience())
            {
                throw new CustomException("Invalid");
            }
            if (update.IsExistWorkExperience(works))
            {
                throw new CustomException("User is already exist");
            }
            await _unitOfWork.WorkExperienceInterface.UpdateAsync(workExperince);
            await _unitOfWork.SaveAsync();
        }
    }
}