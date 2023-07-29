namespace BasketballTeam.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Enums;
using static Common.EntityValidations;

public class Player
{
    public Player()
    {
        this.TeamPlayers = new HashSet<TeamPlayer>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(FIRSTNAME_MAX_LENGTH, MinimumLength = FIRSTNAME_MIN_LENGTH)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(LASTNAME_MAX_LENGTH, MinimumLength = LASTNAME_MIN_LENGTH)]
    public string LastName { get; set; } = null!;
    public string FullName => $"{FirstName} {LastName}";
    
    [Range(NUMBER_MIN_VALUE, NUMBER_MAX_VALUE)]
    public int Number { get; set; }

    [Range(AGE_MIN_VALUE, AGE_MAX_VALUE)]
    public int Age { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    [Required]
    [StringLength(NATIONALITY_MAX_LENGTH, MinimumLength = NATIONALITY_MIN_LENGTH)]
    public string Nationality { get; set; } = null!;

    public PlayerPosition Position { get; set; }
    public PersonalTrophies Trophies { get; set; }
    
    public int TrophiesCount { get; set; }

    [ForeignKey(nameof(Coach))]
    public Guid CoachId { get; set; }
    public virtual Coach Coach { get; set; } = null!;

    public virtual ICollection<TeamPlayer> TeamPlayers { get; set; } = null!;
}