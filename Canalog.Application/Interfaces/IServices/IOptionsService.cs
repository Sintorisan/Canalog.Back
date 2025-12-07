using Canalog.Application.Dtos;
using Canalog.Domain.Models;

namespace Canalog.Application.Interfaces;

public interface IOptionsService
{
    Task<OptionsDto> GetUserOptionsAsync();
    Task<ColorScheme> GetColorSchemeAsync();
    Task UpdateAsync();
}
