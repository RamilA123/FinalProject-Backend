using OrganiDb.Models;

namespace OrganiDb.ViewModels.Profile
{
    public class ProfileVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public LayoutVM Data { get; set; }
    }
}
