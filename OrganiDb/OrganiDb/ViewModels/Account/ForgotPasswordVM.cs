using OrganiDb.Models;
using System.ComponentModel.DataAnnotations;

namespace OrganiDb.ViewModels.Account
{
    public class ForgotPasswordVM
    {
        public List<Banner> Banners { get; set; }

        public List<BannerInfo> BannerInfos { get; set; }
     
        public LayoutVM Data { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
