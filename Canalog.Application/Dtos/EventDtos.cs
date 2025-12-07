using Canalog.Domain.Enums;
using Canalog.Domain.Models;

namespace Canalog.Application.Dtos;

public record EventRequestDto(
    string Title,
    EventColor Color,
    DateTime Start,
    DateTime End
);

public record UpdateEventRequestDto(
    Guid EventId,
    string Title,
    EventColor Color,
    DateTime Start,
    DateTime End
);

public record EventResponseDto(
    Guid Id,
    string Title,
    DateTime Start,
    DateTime End,
    EventColor Color
);