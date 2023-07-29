namespace BasketballTeam.Data.Models;

using System.ComponentModel.DataAnnotations;
using static Common.EntityValidations;

public class Coach
{
    public Coach()
    {
        this.Players = new HashSet<Player>();
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

    [Required]
    [StringLength(NATIONALITY_MAX_LENGTH, MinimumLength = NATIONALITY_MIN_LENGTH)]
    public string Nationality { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = null!;
}