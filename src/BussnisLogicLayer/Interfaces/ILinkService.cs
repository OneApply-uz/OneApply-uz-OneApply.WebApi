using DTOAccessLayer.Dtos.LinkDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLogicLayer.Interfaces;

public interface ILinkService
{
    Task<List<LinkDto>> GetAllLink();
    Task<LinkDto> GetLinkById(int id);
    Task AddLink (AddLinkDto addlink);
    Task UpdateLink(UpdateLinkDto updatelink);
    Task DeleteLink(int id);
}