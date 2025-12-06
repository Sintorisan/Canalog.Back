using Canalog.Application.Interfaces;
using Canalog.Domain.Models;

namespace Canalog.Infrastructure.Repositories;

public class EventRepository : IEventRepository
{
    public Task<IEnumerable<Event>> GetEventsFromSpanAsync(DateTime endDate)
    {
        var today = DateTime.Now;
        throw new NotImplementedException();
    }
}