using System.ComponentModel.DataAnnotations;

namespace OrganiDb.ViewModels.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = "The username or email is required")]
        public string UsernameOrEmail { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
