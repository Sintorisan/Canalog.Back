using Canalog.Domain.Models;

namespace Canalog.Application.Interfaces;

public interface IAiService
{
    Task<Event> GenerateEventAsync();

}
