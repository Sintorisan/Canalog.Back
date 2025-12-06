using System.Security.Cryptography;
using System.Threading.Tasks;
using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain;
using Canalog.Domain.Enums;
using Canalog.Domain.Models;

namespace Canalog.Application.Mappers;

public static class Mapper
{
    public static EventResponseDto MapToDto(this Event e, ColorScheme colors)
    {
        var color = e.Color switch
        {
            EventColor.Red => colors.Red,
            EventColor.Blue => colors.Blue,
            EventColor.Green => colors.Green,
            EventColor.Purple => colors.Purple,
            EventColor.Yellow => colors.Yellow,
            _ => colors.Red,
        };

        return new EventResponseDto(e.Id, e.Title, e.Start, e.End, color);
    }
}
