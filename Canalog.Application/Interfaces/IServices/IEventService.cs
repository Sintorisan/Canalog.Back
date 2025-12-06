using Canalog.Application.Dtos;

namespace Canalog.Application.Interfaces;

public interface IEventService
{
    Task<IEnumerable<EventResponseDto>> GetTodaysEventAsync(Guid userId);
    Task<IEnumerable<EventResponseDto>> GetWeekEventAsync(Guid userId);
    Task<EventResponseDto> CreateAsync(EventRequestDto request);
    Task UpdateAsync(Guid eventId);
    Task DeleteAsync(Guid eventId);
}
