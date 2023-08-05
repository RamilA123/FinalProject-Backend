using OrganiDb.Models;

namespace OrganiDb.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
    }
}
