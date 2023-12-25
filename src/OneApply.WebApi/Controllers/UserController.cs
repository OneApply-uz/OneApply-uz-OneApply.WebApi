
using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.UserDtos;
using Microsoft.AspNetCore.Mvc;
using OneApplyDataAccessLayer.Data;

namespace OneApply.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;


    [HttpGet("getAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        try
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("getUserById/{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        try
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost("addUser")]
    public async Task<IActionResult> AddUser(AddUserDto dto)
    {
        try
        {
            await _userService.AddAsync(dto);
            return Ok("User added successfully");
        }
        catch (ArgumentNullException)
        {
            return NotFound("User is null");
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("updateUser")]
    public async Task<IActionResult> UpdateUser(UpdateUserDto dto)
    {
        try
        {
            await _userService.UpdateAsync(dto);
            return Ok("User updated successfully");
        }
        catch (ArgumentNullException)
        {
            return NotFound("User is null");
        }
        catch (CustomException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        try
        {
            await _userService.DeleteAsync(id);
            return NoContent(); // Indicates successful deletion with no specific content to return
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}

