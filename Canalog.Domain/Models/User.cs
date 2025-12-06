using Canalog.Domain.Models;

namespace Canalog.Domain;

public class User
{
    public string Id { get; set; } = string.Empty;
    public string GoogleId { get; set; } = string.Empty;
    public required Options Options { get; set; }
    public List<Event> Events { get; set; } = new();
}
