using Canalog.Application.Dtos;
using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IUserService
{
    Task<User> CreateAsync(string userId);
    Task<User?> FindByIdAsync(string userId);
    OptionsResponseDto MapResponse(User user);
}