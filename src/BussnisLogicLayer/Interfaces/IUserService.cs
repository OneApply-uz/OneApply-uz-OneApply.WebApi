

using BussnisLogicLayer.Extended;
using DTOAccessLayer.Dtos.UserDtos;
using OneApplyDataAccessLayer.Entities;

namespace BussnisLogicLayer.Interfaces;

public interface IUserService
{
    Task<PagedList<UserDto>> GetAllPagedAsync(int pageSize, int pageNumber);   
    Task<List<UserDto>> GetAllAsync();
    Task<UserDto> GetByIdAsync(int id);
    Task AddAsync(AddUserDto dto);
    Task DeleteAsync(int id);
    Task UpdateAsync(UpdateUserDto dto);
}
