using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IUserRepository
{
    Task<User?> GetUserByIdAsync(string userId);
}
