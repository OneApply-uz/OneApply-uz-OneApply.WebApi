using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using BussnisLogicLayer.Services;
using DTOAccessLayer.Dtos.WorkExperienceDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;

namespace OneApply.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkExperienceController(IWorkExperienceService workExperienceService, ApplicationDbContext dbContext)
    : ControllerBase
{
    private readonly IWorkExperienceService _workExperienceService = workExperienceService;
    private readonly ApplicationDbContext _dbContext = dbContext;
    [HttpGet("GetAllWork")]
    public async Task<IActionResult> GetAllWork()
    {
        try
        {
            var work = await _workExperienceService.GetAllWorkExperience();
            return Ok(work);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var work = await _workExperienceService.GetByWorkId(id);
            if (work == null)
            {
                return BadRequest("Work Experience can't be null");
            }
            return Ok(work);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPost("AddWork")]
    public async Task<IActionResult> AddWork(AddWorkExperienceDto addWorkExperienceDto)
    {
        try
        {
            await _workExperienceService.AddWorkExperienceAsync(addWorkExperienceDto);
            return Ok("Work experience added successfuly");
        }
        catch (ArgumentNullException)
        {
            return NotFound("Work is null");
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
    [HttpPut("UpdateWork")]
    public async Task<IActionResult> UpdateWork(UpdateWorkExperienceDto updateWorkExperience)
    {

        try
        {
            await _workExperienceService.UpdateWorkExperience(updateWorkExperience);
            await _dbContext.SaveChangesAsync();
            return Ok("Work experience added successfuly");
        }
        catch (ArgumentNullException)
        {
            return NotFound("Work is null");
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
    [HttpDelete("DeleteWork")]
    public async Task<IActionResult> DeleteWork(int id)
    {
        try
        {
            await _workExperienceService.DeleteWorkAsync(id);
            return NoContent();
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