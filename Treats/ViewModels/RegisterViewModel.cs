using System.ComponentModel.DataAnnotations;

namespace Treats.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Username")]
    public string Username {get; set;}

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password {get; set;}

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "Your passwords do not match.")]
    public string ConfirmPassword {get; set;}
  }
}