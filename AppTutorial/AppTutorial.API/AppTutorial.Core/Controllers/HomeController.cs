namespace BasketballTeam.API.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HomeController : ApiController
{
    //[Authorize]
    public IActionResult Get()
    {
        return Ok("API is working");
    }
}