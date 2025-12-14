using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain.Models;

namespace Canalog.Application.Services;

public class OptionsService(IOptionsRepository optRepo) : IOptionsService
{
    private readonly IOptionsRepository _optRepo = optRepo;

    public Task<EventColorScheme> GetColorSchemeAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OptionsResponseDto> GetUserOptionsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(UpdateThemeRequestDto request, string userId)
    {
        await _optRepo.UpdateUserThemeAsync(userId, request.ThemeId);
    }

    public async Task<List<ThemeListItemDto>> GetAllThemesAsync()
    {
        var themes = await _optRepo.GetAllThemesAsync();
        return themes.Select(t => new ThemeListItemDto(
            t.Id,
            t.Name,
            t.Background
        )).ToList();
    }

}
