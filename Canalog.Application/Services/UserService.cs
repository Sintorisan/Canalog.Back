using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain;
using Canalog.Domain.Enums;

namespace Canalog.Application;

public class UserService(IUserRepository userRepo, IOptionsRepository optRepo)
{
    private readonly IUserRepository _userRepo = userRepo;
    private readonly IOptionsRepository _optRepo = optRepo;


    public async Task<User> CreateAsync(string userId)
    {
        var googleId = ExtractGoogleId(userId);
        var defaultOptions = await DefaultOptions(userId);

        var user = new User
        {
            Id = userId,
            GoogleId = googleId,
            Options = defaultOptions
        };

        await _userRepo.AddAsync(user);

        return user;
    }

    private string ExtractGoogleId(string userId)
    {
        // Auth0 Google format: "google-oauth2|123456789"
        if (!userId.StartsWith("google-oauth2|"))
        {
            return string.Empty;
        }

        return userId.Split("|")[1];
    }

    private async Task<Options> DefaultOptions(string userId)
    {
        var defaultTheme = await _optRepo.GetDefaultTheme();
        if (defaultTheme == null)
        {
            defaultTheme = new();
        }

        return new Options
        {
            UserId = userId,
            ThemeId = defaultTheme.Id,
            TimeFormat = TimeFormat.H24
        };
    }

    public async Task<User?> FindByIdAsync(string userId)
    {
        return await _userRepo.GetUserByIdAsync(userId);
    }

    public OptionsResponseDto MapResponse(User user)
    {
        return new OptionsResponseDto(
            user.Options.TimeFormat,
            new ThemeResponseDto(
                user.Options.Theme.Name,
                user.Options.Theme.Background,
                user.Options.Theme.EventColorScheme
            )
        );
    }
}
