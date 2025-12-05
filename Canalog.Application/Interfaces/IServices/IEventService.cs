using Canalog.Application.Dtos;

namespace Canalog.Application.Interfaces;

public interface IEventService
{
    Task<IEnumerable<EventResponseDto>> GetTodaysEventAsync();
    Task<EventResponseDto> CreateAsync();
    Task UpdateAsync();
    Task DeleteAsync();
}
