using AutoMapper;
using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.UserDtos;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;

namespace BussnisLogicLayer.Services;

public class UserService(IUnitOfWork unitOfWork,
                         IMapper mapper) : IUserService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task AddAsync(AddUserDto dto)
    {
        if (dto is null)
        {
            throw new ArgumentNullException("User is null here");
        }
        var user = _mapper.Map<User>(dto);
        if (!user.IsValid())
        {
            throw new CustomException("User is  invalid");

        }
        var users = await _unitOfWork.UserInterface.GetAllAsync();
        if (user.IsExist(users))
        {
            throw new CustomException($"{user.FullName} is already exist ");
        }

        await _unitOfWork.UserInterface.AddAsync(user);
        await _unitOfWork.SaveAsync();

    }

    public async Task DeleteAsync(int id)
    {
        var user = await _unitOfWork.UserInterface.GetByIdAsync(id);
        if (user is null)
        {
            throw new ArgumentNullException("User is null here");

        }
        await _unitOfWork.UserInterface.DeleteAsync(user);
        await _unitOfWork.SaveAsync();
    }

    public async Task<List<UserDto>> GetAllAsync()
    {
        var users = await _unitOfWork.UserInterface.GetAllAsync();

        return users.Select(u => _mapper.Map<UserDto>(u)).ToList();
    }

    public Task<PagedList<UserDto>> GetAllPagedAsync(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> GetByIdAsync(int id)
    {
        var user = await _unitOfWork.UserInterface.GetByIdAsync(id);
        if (user is null)
        {
            throw new ArgumentNullException("User is null");
        }
        return _mapper.Map<UserDto>(user);
    }

    public async Task UpdateAsync(UpdateUserDto dto)
    {
        if (dto is null)
        {
            throw new ArgumentNullException("User is null");
        }
        var users = await _unitOfWork.UserInterface.GetAllAsync();
        var user = await _unitOfWork.UserInterface.GetByIdAsync(dto.Id);
        if (user is null)
        {
            throw new ArgumentNullException("User is null");
        }
        var updateUser = _mapper.Map<User>(dto);
        if (!updateUser.IsValid())
        {
            throw new CustomException("User is valid");
        }
        if (updateUser.IsExist(users))
        {
            throw new CustomException("User is already exist");
        }
        await _unitOfWork.UserInterface.UpdateAsync(user);
        await _unitOfWork.SaveAsync();
    }

}