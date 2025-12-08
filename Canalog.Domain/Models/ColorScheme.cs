namespace Canalog.Domain.Models;

public class EventColorScheme
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Red { get; set; } = string.Empty;
    public string Blue { get; set; } = string.Empty;
    public string Green { get; set; } = string.Empty;
    public string Yellow { get; set; } = string.Empty;
    public string Purple { get; set; } = string.Empty;
}