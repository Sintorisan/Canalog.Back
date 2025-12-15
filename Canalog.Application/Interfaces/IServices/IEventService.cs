using Canalog.Application.Dtos;
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IEventService
{
    Task<DayEventsDto> GetDayAsync(User user, DateTimeOffset date);
    Task<WeekEventsResponseDto> GetWeekAsync(User user, DateTimeOffset weekStart);
    Task<EventResponseDto> CreateAsync(EventRequestDto request, User user);
    Task UpdateAsync(UpdateEventRequestDto dto);
    Task DeleteAsync(Guid eventId);
}
