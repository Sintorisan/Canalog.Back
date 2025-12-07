using Canalog.Application.Dtos;
using Canalog.Domain.Models;

namespace Canalog.Application.Interfaces;

public interface IEventRepository
{
    Task AddAsync(Event newEvent);
    Task DeleteAsync(object entity);
    Task<Event> GetEventById(Guid eventId);
    Task<IEnumerable<Event>> GetEventsRangeAsync(string userId, DateTime start, DateTime end);
    Task UpdateAsync(object entity);
}
