using Canalog.Domain.Enums;

namespace Canalog.Domain.Models;

public class Event
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public EventColor Color { get; set; }

    public required User User { get; set; }
    public Guid UserId { get; set; }
}
