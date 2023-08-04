using OrganiDb.Models;
using System.ComponentModel.DataAnnotations;

namespace OrganiDb.ViewModels.Account
{
    public class ResetPasswordVM
    {
        public List<Banner> Banners { get; set; }

        public List<BannerInfo> BannerInfos { get; set; }

        public LayoutVM Data { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }

        public string UserId { get; set; }

        public string Token { get; set; }
    }
}
