using Canalog.Domain.Enums;

namespace Canalog.Application.Dtos;

public record EventRequestDto(
    string Title,
    EventColor Color,
    DateTimeOffset Start,
    DateTimeOffset End
);

public record UpdateEventRequestDto(
    Guid Id,
    string Title,
    EventColor Color,
    DateTimeOffset Start,
    DateTimeOffset End
);

public record WeekEventsResponseDto(
    DateTimeOffset WeekStart,
    DateTimeOffset WeekEnd,
    List<DayEventsDto> Days
);

public record DayEventsDto(
    DateTimeOffset Date,
    List<EventResponseDto> Events
);

public record EventResponseDto(
    Guid Id,
    string Title,
    DateTimeOffset Start,
    DateTimeOffset End,
    EventColor Color
);