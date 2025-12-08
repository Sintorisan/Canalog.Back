using Canalog.Application.Dtos;
using Canalog.Domain.Models;

namespace Canalog.Application.Interfaces;

public interface IOptionsService
{
    Task<OptionsResponseDto> GetUserOptionsAsync();
    Task<EventColorScheme> GetColorSchemeAsync();
    Task UpdateAsync();
}
