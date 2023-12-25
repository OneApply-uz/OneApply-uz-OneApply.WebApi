using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using BussnisLogicLayer.Services;
using DTOAccessLayer.Dtos.EducationDtos;
using Microsoft.AspNetCore.Mvc;
using OneApplyDataAccessLayer.Data;


namespace OneApply.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController(IEducationService educationService, ApplicationDbContext dbContext) : ControllerBase
    {
        private readonly IEducationService _educationService = educationService;
        private readonly ApplicationDbContext _dbContext = dbContext;

        [HttpGet("GetAllEducation")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var educaions = await _educationService.GetAllEducationAsync();
                return Ok(educaions);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var certificate = await _educationService.GetByEducationId(id);
                return Ok(certificate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("AddEducation")]
        public async Task<IActionResult> Add(AddEducationDto addEducation)
        {
            try
            {
                await _educationService.AddEducationAsync(addEducation);
                return Ok("Education added successfully");
            }
            catch (ArgumentNullException)
            {
                return NotFound("Education is null");
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
        [HttpPut("UpdateEducationAsync")]
        public async Task<IActionResult> UpdateEducationAsync(UpdateEducationDto updateEducation)
        {
            try
            {
                await _educationService.UpdateEducation(updateEducation);
                return Ok("Education updated successfully");
            }
            catch (ArgumentNullException)
            {
                return NotFound("Education is null");
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
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _educationService.DeleteEducationAsync(id);
                await _dbContext.SaveChangesAsync();
                return Ok("Education deleted successfully");
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

}