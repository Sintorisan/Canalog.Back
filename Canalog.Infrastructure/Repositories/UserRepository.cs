using Canalog.Application.Interfaces;
using Canalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure.Repositories;

public class UserRepository(AppContext context) : IUserRepository
{
    private readonly AppContext _context = context;


    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetUserByIdAsync(string userId)
    {
        return await _context.Users
            .Include(u => u.Options)
                .ThenInclude(o => o.Theme)
                    .ThenInclude(t => t.EventColorScheme)
            .Include(u => u.Options)
                .ThenInclude(o => o.Theme)
                    .ThenInclude(t => t.UiColorScheme)
            .SingleOrDefaultAsync(u => u.Id == userId);
    }
}