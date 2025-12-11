using Canalog.Application.Dtos;
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IEventService
{
    Task<DayEventsDto> GetDayAsync(User user, DateTime date);
    Task<WeekEventsResponseDto> GetWeekAsync(User user, DateTime weekStart);
    Task<EventResponseDto> CreateAsync(EventRequestDto request, User user);
    Task UpdateAsync(UpdateEventRequestDto dto);
    Task DeleteAsync(Guid eventId);
}
