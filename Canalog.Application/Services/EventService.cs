using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Application.Mappers;
using Canalog.Domain;
using Canalog.Domain.Models;

namespace Canalog.Application.Services;

public class EventService(IEventRepository eventRepo) : IEventService
{
    private readonly IEventRepository _eventRepo = eventRepo;

    public async Task<DayEventsDto> GetDayAsync(User user, DateTimeOffset date)
    {
        var dateStart = new DateTimeOffset(date.Date, date.Offset);
        var end = dateStart.AddDays(1);

        var events = await _eventRepo.GetEventsRangeAsync(user.Id, dateStart, end);

        return new DayEventsDto(
            dateStart,
            events
                .Select(e => e.MapToDto())
                .ToList()
            );
    }

    public async Task<WeekEventsResponseDto> GetWeekAsync(User user, DateTimeOffset weekStart)
    {
        var weekStartDate = new DateTimeOffset(weekStart.Date, weekStart.Offset);
        var weekEnd = weekStartDate.AddDays(7);

        var events = await _eventRepo.GetEventsRangeAsync(user.Id, weekStartDate, weekEnd);

        var days = events
            .GroupBy(e => new DateTimeOffset(e.Start.Date, e.Start.Offset))
            .Select(g => new DayEventsDto(
                Date: g.Key,
                Events: g.Select(e => e.MapToDto()).ToList()
            ))
            .OrderBy(d => d.Date)
            .ToList();

        return new WeekEventsResponseDto(
            weekStartDate,
            weekEnd,
            days
        );
    }

    public async Task<EventResponseDto> CreateAsync(EventRequestDto request, User user)
    {
        var newEvent = new Event
        {
            Title = request.Title,
            Start = request.Start,
            End = request.End,
            Color = request.Color,
            UserId = user.Id
        };

        await _eventRepo.AddAsync(newEvent);
        return newEvent.MapToDto();
    }

    public async Task DeleteAsync(Guid eventId)
    {
        var entity = await _eventRepo.GetEventById(eventId);
        if (entity == null)
        {
            throw new KeyNotFoundException();
        }

        await _eventRepo.DeleteAsync(entity);
    }

    public async Task UpdateAsync(UpdateEventRequestDto dto)
    {
        var entity = await _eventRepo.GetEventById(dto.Id);
        if (entity == null)
        {
            throw new KeyNotFoundException();
        }

        entity.Title = dto.Title;
        entity.Color = dto.Color;
        entity.Start = dto.Start;
        entity.End = dto.End;

        await _eventRepo.UpdateAsync(entity);
    }
}
