using Canalog.Application.Interfaces;
using Canalog.Domain;

namespace Canalog.Application;

public class UserService(IUserRepository userRepo)
{
    private readonly IUserRepository _userRepo = userRepo;
    public async Task<User?> FindByIdAsync(string userId)
    {
        var user = await _userRepo
            .GetUserByIdAsync(userId);

        return user;
    }
}
