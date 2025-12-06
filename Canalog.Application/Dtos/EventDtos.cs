using Canalog.Domain.Models;

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
    DateTime Start,
    DateTime End,
    string Color
);