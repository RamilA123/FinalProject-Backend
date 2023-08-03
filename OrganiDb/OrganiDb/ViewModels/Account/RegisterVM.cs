using System.ComponentModel.DataAnnotations;

namespace OrganiDb.ViewModels.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The surname is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The repeat password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
