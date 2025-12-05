using Canalog.Domain.Models;

namespace Canalog.Domain;

public class Theme
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Background { get; set; } = string.Empty;
    public ColorScheme ColorScheme { get; set; } = new();
}
