using DTOAccessLayer.Dtos.SkillDtos;

namespace BussnisLogicLayer.Interfaces
{
    public interface IPdfService
    {
        byte[] GeneratePdf(SkillDto skilldto);
    }
}
