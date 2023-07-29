namespace BasketballTeam.Data.Models;

using System.ComponentModel.DataAnnotations;
using static Common.EntityValidations;

public class Tournament
{
    public Tournament()
    {
        this.ParticipatingTeams = new HashSet<BasketballTeam>();
    }

    [Key]
    public Guid TournamentId { get; set; }

    [Required]
    [StringLength(TOURNAMENT_NAME_MAX_LENGTH, MinimumLength = TOURNAMENT_NAME_MIN_LENGTH)]
    public string Name { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [Required]
    [StringLength(TOURNAMENT_LOCATION_MAX_LENGTH, MinimumLength = TOURNAMENT_LOCATION_MIN_LENGTH)]
    public string Location { get; set; } = null!;

    [Required]
    [StringLength(TOURNAMENT_DESCRIPTION_MAX_LENGTH, MinimumLength = TOURNAMENT_DESCRIPTION_MIN_LENGTH)]
    public string Description { get; set; } = null!;

    public virtual ICollection<BasketballTeam> ParticipatingTeams { get; set; }
}