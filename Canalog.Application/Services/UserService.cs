using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain;

namespace Canalog.Application;

public class UserService(IUserRepository userRepo)
{
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<User?> CreateAsync(string userId)
    {
        throw new NotImplementedException();
    }

    private Options DefaultOptions()
    {
        throw new NotImplementedException();
    }

    public async Task<User?> FindByIdAsync(string userId)
    {
        return await _userRepo
            .GetUserByIdAsync(userId);
    }

    public async Task<UserResponseDto> MapResponseAsync(User? user)
    {
        throw new NotImplementedException();
    }
}
