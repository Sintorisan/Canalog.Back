using Canalog.Application.Interfaces;
using Canalog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure.Repositories;

public class EventRepository(AppContext context) : IEventRepository
{
    private readonly AppContext _context = context;

    public async Task AddAsync(Event newEvent)
    {
        await _context.Events.AddAsync(newEvent);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Event>> GetEventsRangeAsync(string userId, DateTime start, DateTime end)
    {
        return await _context.Events
            .Where(e =>
                e.UserId == userId &&
                e.Start >= start &&
                e.Start < end)
            .ToListAsync();
    }
}