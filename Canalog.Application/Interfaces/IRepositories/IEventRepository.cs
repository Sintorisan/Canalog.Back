using Canalog.Application.Dtos;
using Canalog.Domain.Models;

namespace Canalog.Application.Interfaces;

public interface IEventRepository
{
    Task<IEnumerable<Event>> GetEventsFromSpanAsync(DateTime date);
}
