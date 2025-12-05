using Canalog.Application.Dtos;

namespace Canalog.Application.Interfaces;

public interface IOptionsService
{
    Task<OptionsDto> GetUserOptionsAsync();
    Task UpdateAsync();
}
