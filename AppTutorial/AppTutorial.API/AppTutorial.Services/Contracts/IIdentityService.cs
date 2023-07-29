namespace BasketballTeam.Services.Contracts;

using ViewModels.AuthViewModels;

public interface IIdentityService
{
    Task RegisterAsync(RegisterUserRequestModel model);

    Task<object> LoginAsync(LoginUserRequestModel model);

}