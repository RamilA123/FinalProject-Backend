using System.ComponentModel.DataAnnotations;

namespace OrganiDb.ViewModels.Account
{
    public class ForgotPasswordVM
    {
        [Required(ErrorMessage = "The email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
