
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IOptionsRepository
{
    Task<Theme?> GetAnyTheme();
    Task<Theme?> GetDefaultTheme();
    Task<Theme?> GetThemeByIdAsync(Guid themeId);
    Task<List<Theme>> GetAllThemesAsync();
    Task UpdateUserThemeAsync(string userId, Guid themeId);
}
