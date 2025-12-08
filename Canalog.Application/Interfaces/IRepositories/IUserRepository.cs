using Canalog.Domain;

namespace Canalog.Application.Interfaces;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetUserByIdAsync(string userId);
}
