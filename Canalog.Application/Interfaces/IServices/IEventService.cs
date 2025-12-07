using Canalog.Application.Dtos;
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IEventService
{
    Task<IEnumerable<EventResponseDto>> GetTodaysEventAsync(User user);
    Task<IEnumerable<EventResponseDto>> GetWeekEventAsync(User user, DateTime start);
    Task<EventResponseDto> CreateAsync(EventRequestDto request, User user);
    Task UpdateAsync(UpdateEventRequestDto dto);
    Task DeleteAsync(Guid eventId);
}
