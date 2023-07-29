namespace BasketballTeam.Services;

using Contracts;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ViewModels.AuthViewModels;

public class IdentityService : IIdentityService 
{
    private readonly UserManager<User> userManager;
    private readonly IJwtService jwtService;
    private readonly AppSettings appSettings;

    public IdentityService(UserManager<User> userManager, IJwtService jwtService, IOptions<AppSettings> appSettings)
    {
        this.userManager = userManager;
        this.jwtService = jwtService;
        this.appSettings = appSettings.Value;
    }

    public async Task RegisterAsync(RegisterUserRequestModel model)
    {
        var user = new User()
        {
            Email = model.Email,
            UserName = model.Username
        };

        if (model.Password != model.ConfirmPassword)
        {
            throw new ArgumentException("Passwords do not match!");
        }

        var result = await this.userManager.CreateAsync(user, model.Password);
    }

    public async Task<object> LoginAsync(LoginUserRequestModel model)
    {
        var user = await this.userManager.FindByNameAsync(model.Username);

        if (user == null)
        {
            return "Invalid username or password!";
        }

        var result = await this.userManager.CheckPasswordAsync(user, model.Password);

        if (!result)
        {
            return "Invalid username or password!";
        }

        var encryptedToken = this.jwtService.GenerateJwtToken(user.Id, user.UserName, appSettings.Secret);

        return new LoginResponseModel { Token = encryptedToken };
    }
}