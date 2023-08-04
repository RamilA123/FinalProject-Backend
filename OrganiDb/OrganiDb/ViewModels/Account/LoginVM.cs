using OrganiDb.Models;
using System.ComponentModel.DataAnnotations;

namespace OrganiDb.ViewModels.Account
{
    public class LoginVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }

        [Required(ErrorMessage = "The username or email is required")]
        public string UsernameOrEmail { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
