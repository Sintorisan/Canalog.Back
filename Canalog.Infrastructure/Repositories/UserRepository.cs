using Canalog.Application.Interfaces;
using Canalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure.Repositories;

public class UserRepository(AppContext context) : IUserRepository
{
    private readonly AppContext _context = context;

    public async Task<User?> GetUserByIdAsync(string userId)
    {
        return await _context.Users
            .Include(u => u.Options)
            .SingleOrDefaultAsync(u => u.Id == userId);
    }
}