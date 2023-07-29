namespace BasketballTeam.ViewModels.AuthViewModels;

using System.ComponentModel.DataAnnotations;
using static Common.EntityValidations;
public class RegisterUserRequestModel
{
    [Required]
    [StringLength(EMAIL_MAX_LENGTH, MinimumLength = EMAIL_MIN_LENGTH)]
    public string Email { get; set; } = null!;

    [Required]
    [StringLength(USERNAME_MAX_LENGTH, MinimumLength = USERNAME_MIN_LENGTH)]
    public string Username { get; set; } = null!;

    [Required]
    [StringLength(PASSWORD_MAX_LENGTH, MinimumLength = PASSWORD_MIN_LENGTH)]
    public string Password { get; set; } = null!;

    [Required]
    [StringLength(CONFIRM_PASSWORD_MAX_LENGTH, MinimumLength = CONFIRM_PASSWORD_MIN_LENGTH)]
    public string ConfirmPassword { get; set; } = null!;
}