

using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.SkillDtos;
using DTOAccessLayer.Dtos.UserDtos;
using DTOAccessLayer.Dtos.VacanceDtos.JobDtos;
using DTOAccessLayer.Dtos.WorkExperienceDtos;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.StyledXmlParser.Jsoup.Nodes;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Entities.Resumes;
using Document = iText.Layout.Document;

namespace BussnisLogicLayer.Services
{
    public class PdfService : IPdfService
    {
        public byte[] GeneratePdf(SkillDto skilldto)
        {
            using (var memoryStream = new MemoryStream())
            {
                var writer = new PdfWriter(memoryStream);
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    document.Add(new Paragraph($"Skillls Namee: {skilldto.Name}"));
                }
                return memoryStream.ToArray();
            }
        }
    }
}