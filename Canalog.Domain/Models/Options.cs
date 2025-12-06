using Canalog.Domain.Enums;

namespace Canalog.Domain;

public class Options
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TimeFormat TimeFormat { get; set; }
    public Guid ThemeId { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; }
}
