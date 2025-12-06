using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Application.Mappers;

namespace Canalog.Application.Services;

public class EventService(IEventRepository eventRepo, IOptionsService optService) : IEventService
{
    private readonly IEventRepository _eventRepo = eventRepo;
    private readonly IOptionsService _optService = optService;

    public Task<EventResponseDto> CreateAsync(EventRequestDto request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<EventResponseDto>> GetTodaysEventAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EventResponseDto>> GetWeekEventAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
