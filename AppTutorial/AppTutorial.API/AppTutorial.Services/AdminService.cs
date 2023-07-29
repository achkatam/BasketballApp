namespace BasketballTeam.Services;

using Contracts;
using Data;
using Data.Models;
using Data.Models.Enums;

public class AdminService  : IAdminService
{
    private readonly BasketballTeamDbContext dbContext;

    public AdminService(BasketballTeamDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Player> CreatePlayerAsync(string firstName, string lastName, int age, int number, string position, string imageUrl,
        string teamName)
    {
        throw new NotImplementedException();
    }

    public async Task<Player> UpdatePlayerAsync(Guid playerId, string firstName, string lastName, int age, int number, string position,
        string imageUrl, string teamName)
    {
        throw new NotImplementedException();
    }

    public async Task<Player> DeletePlayerAsync(Guid playerId)
    {
        throw new NotImplementedException();
    }

    public async Task<Player> GetPlayerByIdAsync(Guid playerId)
    {
        throw new NotImplementedException();
    }

    public async Task<Coach> CreateCoachAsync(string firstName, string lastName, int age, string imageUrl, string teamName)
    {
        throw new NotImplementedException();
    }

    public async Task<Coach> UpdateCoachAsync(Guid coachId, string firstName, string lastName, int age, string imageUrl, string teamName)
    {
        throw new NotImplementedException();
    }

    public async Task<Coach> DeleteCoachAsync(Guid coachId)
    {
        throw new NotImplementedException();
    }

    public async Task<Coach> GetCoachByIdAsync(Guid coachId)
    {
        throw new NotImplementedException();
    }

    public async Task<BasketballTeam> CreateTeamAsync(string name, string imageUrl, string coachName)
    {
        throw new NotImplementedException();
    }

    public async Task<BasketballTeam> UpdateTeamAsync(Guid teamId, string name, string imageUrl, string coachName)
    {
        throw new NotImplementedException();
    }

    public async Task<BasketballTeam> DeleteTeamAsync(Guid teamId)
    {
        throw new NotImplementedException();
    }

    public async Task<BasketballTeam> GetTeamByIdAsync(Guid teamId)
    {
        throw new NotImplementedException();
    }

    public async Task<Tournament> CreateTournamentAsync(string name, string imageUrl, string location, DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public async Task<Tournament> UpdateTournamentAsync(Guid tournamentId, string name, string imageUrl, string location, DateTime startDate,
        DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public async Task<Tournament> DeleteTournamentAsync(Guid tournamentId)
    {
        throw new NotImplementedException();
    }

    public async Task<Tournament> GetTournamentByIdAsync(Guid tournamentId)
    {
        throw new NotImplementedException();
    }

    public async Task<Merchandize> CreateMerchandizeAsync(MerchType merchType, decimal price, string? size)
    {
        throw new NotImplementedException();
    }

    public async Task<Merchandize> UpdateMerchandizeAsync(Guid merchId, MerchType merchType, decimal price, string? size)
    {
        throw new NotImplementedException();
    }

    public async Task<Merchandize> DeleteMerchandizeAsync(Guid merchId)
    {
        throw new NotImplementedException();
    }

    public async Task<Merchandize> GetMerchandizeByIdAsync(Guid merchId)
    {
        throw new NotImplementedException();
    }
}