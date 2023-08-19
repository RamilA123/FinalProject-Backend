using OrganiDb.Models;

namespace OrganiDb.Areas.Admin.ViewModels
{
    public class DashboardVM
    {
        public List<Category> Categories  { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public List<Banner> Banners  { get; set; }
        public List<BannerInfo> BannerInfos  { get; set; }
        public IEnumerable<Product> Products  { get; set; }
    }
}
