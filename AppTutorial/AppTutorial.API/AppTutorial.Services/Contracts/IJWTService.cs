namespace BasketballTeam.Services.Contracts;
public interface IJwtService
{
    string GenerateJwtToken(string userId, string userName, string secret);
}