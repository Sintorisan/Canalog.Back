using Canalog.Application.Dtos;
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IEventService
{
    Task<IEnumerable<EventResponseDto>> GetTodaysEventAsync(User user);
    Task<IEnumerable<EventResponseDto>> GetWeekEventAsync(User user);
    Task<EventResponseDto> CreateAsync(EventRequestDto request);
    Task UpdateAsync(Guid eventId, EventRequestDto dto);
    Task DeleteAsync(Guid eventId);
}
