using System.ComponentModel.DataAnnotations.Schema;
using Canalog.Domain.Models;

namespace Canalog.Domain;

public class User
{
    public string Id { get; set; } = string.Empty;
    public string GoogleId { get; set; } = string.Empty;
    [ForeignKey("Options")]
    public Guid OptionsId { get; set; }
    public Options Options { get; set; } = null!;
    public List<Event> Events { get; set; } = new();
}
