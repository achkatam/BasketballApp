namespace BasketballTeam.API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using ViewModels.AuthViewModels;

public class IdentityController : ApiController
{
    private readonly IIdentityService registerService; 

    public IdentityController(IIdentityService registerService)
    {
        this.registerService = registerService;
    }

    [HttpPost]
    [Route(nameof(Register))]
    public async Task<IActionResult> Register(RegisterUserRequestModel model)
    {
        await this.registerService.RegisterAsync(model);

        return Ok($"{model.Username} created successfully!");
    }

    [HttpPost]
    [Route(nameof(Login))]
    public async Task<ActionResult<LoginResponseModel>> Login(LoginUserRequestModel model)
    {
        var result = await this.registerService.LoginAsync(model);

        if (result is string)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
}