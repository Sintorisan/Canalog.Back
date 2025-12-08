using Canalog.Application.Interfaces;
using Canalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace Canalog.Infrastructure.Repositories;

public class OptionsRepository(AppContext context) : IOptionsRepository
{
    private readonly AppContext _context = context;


    public async Task<Theme?> GetDefaultTheme()
    {
        const string defaultTheme = "default";

        return await _context.Themes
            .Include(t => t.UiColorScheme)
            .Include(t => t.EventColorScheme)
            .FirstOrDefaultAsync(t => t.Name == defaultTheme);
    }

    public async Task<Theme?> GetThemeByIdAsync(Guid themeId)
    {
        return await _context.Themes
            .Include(t => t.UiColorScheme)
            .Include(t => t.EventColorScheme)
            .FirstOrDefaultAsync(t => t.Id == themeId);
    }
}