using Canalog.Application.Interfaces;
using Canalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure.Repositories;

public class OptionsRepository(EventDbContext context) : IOptionsRepository
{
    private readonly EventDbContext _context = context;


    public async Task<Theme?> GetDefaultTheme()
    {
        const string defaultTheme = "Silk Waves";

        return await _context.Themes
            .Include(t => t.UiColorScheme)
            .Include(t => t.EventColorScheme)
            .FirstOrDefaultAsync(t => t.Name == defaultTheme);
    }
    public async Task<Theme?> GetAnyTheme()
    {
        return await _context.Themes.FirstOrDefaultAsync();
    }


    public async Task<Theme?> GetThemeByIdAsync(Guid themeId)
    {
        return await _context.Themes
            .Include(t => t.UiColorScheme)
            .Include(t => t.EventColorScheme)
            .FirstOrDefaultAsync(t => t.Id == themeId);
    }

    public async Task<List<Theme>> GetAllThemesAsync()
    {
        return await _context.Themes
            .Include(t => t.UiColorScheme)
            .Include(t => t.EventColorScheme)
            .ToListAsync();
    }

    public async Task UpdateUserThemeAsync(string userId, Guid themeId)
    {
        var options = await _context.Options
            .FirstOrDefaultAsync(o => o.UserId == userId);

        if (options is null)
        {
            throw new InvalidOperationException($"Options not found for user {userId}");
        }

        options.ThemeId = themeId;
        await _context.SaveChangesAsync();
    }
}