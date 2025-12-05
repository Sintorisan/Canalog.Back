using Canalog.Domain.Enums;

namespace Canalog.Domain;

public class Options
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TimeFormat TimeFormat { get; set; }
    public Guid ThemeId { get; set; }
}
