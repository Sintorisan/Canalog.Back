using Canalog.Application.Interfaces;
using Canalog.Domain;

namespace Canalog.Application;

public class UserService(IUserRepository userRepo)
{
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<User?> FindByIdAsync(string userId)
    {
        return await _userRepo
            .GetUserByIdAsync(userId);
    }
}
