using Canalog.Domain.Enums;
using Canalog.Domain.Models;

namespace Canalog.Application.Dtos;

public record OptionsResponseDto(
    TimeFormat TimeFormat,
    ThemeResponseDto Theme
);

public record ThemeResponseDto(
    string Name,
    string Background,
    EventColorScheme ColorScheme,
    UiColorScheme UiColorScheme
);

public record ThemeListItemDto(
    Guid Id,
    string Name,
    string Background
);

public record UpdateThemeRequestDto(
    Guid ThemeId
);