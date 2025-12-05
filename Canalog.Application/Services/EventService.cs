using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;

namespace Canalog.Application.Services;

public class EventService : IEventService
{
    public Task<EventResponseDto> CreateAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EventResponseDto>> GetTodaysEventAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync()
    {
        throw new NotImplementedException();
    }
}
