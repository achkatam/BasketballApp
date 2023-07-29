namespace BasketballTeam.Data.Models;

using System.ComponentModel.DataAnnotations;
using static Common.EntityValidations;

public class BasketballTeam
{
    public BasketballTeam()
    {
        this.TeamPlayers = new HashSet<TeamPlayer>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(TEAM_NAME_MAX_LENGTH, MinimumLength = TEAM_NAME_MIN_LENGTH)]
    public string Name { get; set; } = null!;
    public string? LogoUrl { get; set; }

    [StringLength(TEAM_LOCATION_MAX_LENGTH, MinimumLength = TEAM_LOCATION_MIN_LENGTH)]
    public string Location { get; set; } = null!;

    [Range(typeof(DateTime), "12/21/1891", "{0:MM/dd/yyyy}")]
    public DateTime YearFounded { get; set; }
    public int TrophiesCount { get; set; }

    public virtual ICollection<TeamPlayer> TeamPlayers { get; set; } = null!;
}