using Canalog.Domain.Enums;

namespace Canalog.Application.Dtos;

public record EventRequestDto(
    string Title,
    EventColor Color,
    DateTime Start,
    DateTime End
);

public record UpdateEventRequestDto(
    Guid Id,
    string Title,
    EventColor Color,
    DateTime Start,
    DateTime End
);

public record WeekEventsResponseDto(
    DateTime WeekStart,
    DateTime WeekEnd,
    List<DayEventsDto> Days
);

public record DayEventsDto(
    DateTime Date,
    List<EventResponseDto> Events
);

public record EventResponseDto(
    Guid Id,
    string Title,
    DateTime Start,
    DateTime End,
    EventColor Color
);