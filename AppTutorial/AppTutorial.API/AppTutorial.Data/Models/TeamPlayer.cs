namespace BasketballTeam.Data.Models;

using System.ComponentModel.DataAnnotations.Schema;

public class TeamPlayer
{
    [ForeignKey(nameof(BasketballTeam))]
    public Guid TeamId { get; set; }
    public virtual BasketballTeam Team { get; set; } = null!;

    [ForeignKey(nameof(Player))]
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; set; } = null!;
}