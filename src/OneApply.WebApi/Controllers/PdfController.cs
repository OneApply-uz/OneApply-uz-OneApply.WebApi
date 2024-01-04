using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.SkillDtos;
using DTOAccessLayer.Dtos.UserDtos;
using DTOAccessLayer.Dtos.VacanceDtos.JobDtos;
using DTOAccessLayer.Dtos.WorkExperienceDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneApplyDataAccessLayer.Entities;

namespace OneApply.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfController(IPdfService pdfService) : ControllerBase
    {
        private readonly IPdfService _pdfService = pdfService;

        [HttpPost("generate")]
        public IActionResult GeneratePdf(
             [FromBody] SkillDto skillDto)
        {
            if (skillDto == null)
            {
                return BadRequest("User infofjgrmation is missing.");
            }
            var pdfBytes = _pdfService.GeneratePdf(skillDto);
            return new FileStreamResult(new MemoryStream(pdfBytes), "application/pdf")
            {
                FileDownloadName = "UserInfo.pdf"
            };
        }
    }
}