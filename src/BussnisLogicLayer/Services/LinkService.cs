using AutoMapper;
using BussnisLogicLayer.Extended;
using BussnisLogicLayer.Interfaces;
using DTOAccessLayer.Dtos.LinkDtos;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace BussnisLogicLayer.Services;

public class LinkService(IUnitOfWork unitOfWork, IMapper mapper) : ILinkService
{
    private readonly IMapper _mapper = mapper;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    public static bool IsNumber(string input)
    {
        return double.TryParse(input, out _);
    }
    public async Task AddLink(AddLinkDto addlink)
    {
        if (addlink == null) 
        {
            throw new ArgumentNullException("Link is null!");
        }
        if (IsNumber(addlink.Url))
        {
            throw new CustomException("Link or Url can't be null");
        }
        var link = _mapper.Map<Link>(addlink);
        await _unitOfWork.LinkInterface.AddAsync(link);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteLink(int id)
    {
        var link = await _unitOfWork.LinkInterface.GetByIdAsync(id);
        if (link == null)
        {
            throw new ArgumentNullException($"{id} is not a link");
        }
        await _unitOfWork.LinkInterface.DeleteAsync(link);
        await _unitOfWork.SaveAsync();
    }

    public async Task<List<LinkDto>> GetAllLink()
    {
        var link = await _unitOfWork.LinkInterface.GetAllAsync();
        return link.Select(l => _mapper.Map<LinkDto>(l)).ToList();
    }

    public async Task<LinkDto> GetLinkById(int id)
    {
        var link = await _unitOfWork.LinkInterface.GetByIdAsync(id);
        if(link == null)
        {
            throw new ArgumentNullException("Link is null");
        }
        return _mapper.Map<LinkDto>(link);
    }

    public async Task UpdateLink(UpdateLinkDto updatelink)
    {
        if(updatelink == null)
        {
            throw new ArgumentNullException("link is null");
        }
        var link = await _unitOfWork.LinkInterface.GetAllAsync();
        var links = await _unitOfWork.LinkInterface.GetByIdAsync(updatelink.Id);
        if(links == null)
        {
            throw new ArgumentNullException("Link is null");
        }
        var update = _mapper.Map<Link>(links);
        await _unitOfWork.LinkInterface.UpdateAsync(update);
        await _unitOfWork.SaveAsync();
    }
}
