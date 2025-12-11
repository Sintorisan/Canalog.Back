using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Application.Mappers;
using Canalog.Domain;
using Canalog.Domain.Models;

namespace Canalog.Application.Services;

public class EventService(IEventRepository eventRepo) : IEventService
{
    private readonly IEventRepository _eventRepo = eventRepo;

    public async Task<DayEventsDto> GetDayAsync(User user, DateTime date)
    {
        date = date.Date;
        var end = date.AddDays(1);

        var events = await _eventRepo.GetEventsRangeAsync(user.Id, date, end);

        return new DayEventsDto(
            date,
            events
                .Select(e => e.MapToDto())
                .ToList()
            );
    }

    public async Task<WeekEventsResponseDto> GetWeekAsync(User user, DateTime weekStart)
    {
        weekStart = weekStart.Date;
        var weekEnd = weekStart.AddDays(7);

        var events = await _eventRepo.GetEventsRangeAsync(user.Id, weekStart, weekEnd);

        var days = events
            .GroupBy(e => e.Start.Date)
            .Select(g => new DayEventsDto(
                Date: g.Key,
                Events: g.Select(e => e.MapToDto()).ToList()
            ))
            .OrderBy(d => d.Date)
            .ToList();

        return new WeekEventsResponseDto(
            weekStart,
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
