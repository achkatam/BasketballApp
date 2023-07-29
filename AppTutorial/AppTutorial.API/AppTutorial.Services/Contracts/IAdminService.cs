namespace BasketballTeam.Services.Contracts;

using Data.Models;
using Data.Models.Enums;

public interface IAdminService
{
    // Player CRUD
    Task<Player> CreatePlayerAsync(string firstName, string lastName, int age, int number, string position, string imageUrl, string teamName);
    Task<Player> UpdatePlayerAsync(Guid playerId, string firstName, string lastName, int age, int number, string position, string imageUrl, string teamName);
    Task<Player> DeletePlayerAsync(Guid playerId);
    Task<Player> GetPlayerByIdAsync(Guid playerId);

    // Coach CRUD
    Task<Coach> CreateCoachAsync(string firstName, string lastName, int age, string imageUrl, string teamName);
    Task<Coach> UpdateCoachAsync(Guid coachId, string firstName, string lastName, int age, string imageUrl, string teamName);
    Task<Coach> DeleteCoachAsync(Guid coachId);
    Task<Coach> GetCoachByIdAsync(Guid coachId);

    // Team CRUD
    Task<BasketballTeam> CreateTeamAsync(string name, string imageUrl, string coachName);
    Task<BasketballTeam> UpdateTeamAsync(Guid teamId, string name, string imageUrl, string coachName);
    Task<BasketballTeam> DeleteTeamAsync(Guid teamId);
    Task<BasketballTeam> GetTeamByIdAsync(Guid teamId);

    // Tournament CRUD
    Task<Tournament> CreateTournamentAsync(string name, string imageUrl, string location, DateTime startDate, DateTime endDate);
    Task<Tournament> UpdateTournamentAsync(Guid tournamentId, string name, string imageUrl, string location, DateTime startDate, DateTime endDate);
    Task<Tournament> DeleteTournamentAsync(Guid tournamentId);
    Task<Tournament> GetTournamentByIdAsync(Guid tournamentId);

    // Merchandize CRUD
    Task<Merchandize> CreateMerchandizeAsync(MerchType merchType, decimal price, string? size);
    Task<Merchandize> UpdateMerchandizeAsync(Guid merchId, MerchType merchType, decimal price, string? size);
    Task<Merchandize> DeleteMerchandizeAsync(Guid merchId);
    Task<Merchandize> GetMerchandizeByIdAsync(Guid merchId);
}