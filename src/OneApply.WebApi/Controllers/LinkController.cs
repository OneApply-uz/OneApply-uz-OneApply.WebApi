using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using BussnisLogicLayer.Services;
using DTOAccessLayer.Dtos.LinkDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneApplyDataAccessLayer.Data;
using System.Security.Cryptography.Xml;

namespace OneApply.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController(ILinkService linkService, ApplicationDbContext dbContext) : ControllerBase
    {
        private readonly ILinkService _linkService = linkService;
        private readonly ApplicationDbContext _dbContext = dbContext;
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var link = await _linkService.GetAllLink();
                return Ok(link);
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
                var link = _linkService.GetLinkById(id);
                if(link == null)
                {
                    return NotFound("Link is null");
                }
                return Ok(link);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("Add")]

        public async Task<IActionResult> Add(AddLinkDto addlink)
        {
            try
            {
                await _linkService.AddLink(addlink);
                return Ok(addlink);
            }
            catch (ArgumentNullException)
            {
                return NotFound("Link is null");
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

        [HttpPut("UpdateLink")]
        public async Task<IActionResult> UpdateLink(UpdateLinkDto updateLink)
        {
            try
            {
                await _linkService.UpdateLink(updateLink);
                return Ok("Link updated successfully");
            }
            catch (ArgumentNullException)
            {
                return NotFound("Link is null");
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
        [HttpDelete("DeleteLink")]
        public async Task<IActionResult> DeleteLink(int id)
        {
            try
            {
                await _linkService.DeleteLink(id);
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
}