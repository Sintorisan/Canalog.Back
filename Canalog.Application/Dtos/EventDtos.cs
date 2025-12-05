namespace Canalog.Application.Dtos;

public record EventRequestDto(
    string Title,
    string Color,
    DateTime Start,
    DateTime End
);

public record EventResponseDto(
    Guid Id,
    string Title,
    int Hour,
    int Minutes,
    string Color
);