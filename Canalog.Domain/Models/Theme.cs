using Canalog.Domain.Models;

namespace Canalog.Domain;

public class Theme
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Background { get; set; } = string.Empty;

    public Guid UiColorSchemeId { get; set; }
    public UiColorScheme UiColorScheme { get; set; } = new();

    public Guid EventColorSchemeId { get; set; }
    public EventColorScheme EventColorScheme { get; set; } = new();
}

