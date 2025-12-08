using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Application.Mappers;
using Canalog.Domain;
using Canalog.Domain.Models;

namespace Canalog.Application.Services;

public class EventService(IEventRepository eventRepo) : IEventService
{
    private readonly IEventRepository _eventRepo = eventRepo;

    public async Task<IEnumerable<EventResponseDto>> GetTodayAsync(User user)
    {
        var start = DateTime.Today;
        var end = start.AddDays(1);

        var events = await _eventRepo.GetEventsRangeAsync(user.Id, start, end);
        return events.Select(e => e.MapToDto());
    }

    public async Task<IEnumerable<EventResponseDto>> GetRangeAsync(User user, DateTime start)
    {
        var end = start.AddDays(7);

        var events = await _eventRepo.GetEventsRangeAsync(user.Id, start, end);
        return events.Select(e => e.MapToDto());
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
        var entity = await _eventRepo.GetEventById(dto.EventId);
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
