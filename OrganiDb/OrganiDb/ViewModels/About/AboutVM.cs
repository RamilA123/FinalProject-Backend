using OrganiDb.Models;

namespace OrganiDb.ViewModels.About
{
    public class AboutVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public List<TeamFarmer> TeamFarmers { get; set; }
        public TeamFarmerHeader TeamFarmerHeader { get; set; }
        public List<TeamFarmerSocialMedia> TeamFarmerSocialMedias { get; set; }
    }
}
