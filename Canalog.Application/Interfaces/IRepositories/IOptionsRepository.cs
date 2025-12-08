
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IOptionsRepository
{
    Task<Theme?> GetDefaultTheme();
    Task<Theme?> GetThemeByIdAsync(Guid themeId);
}
