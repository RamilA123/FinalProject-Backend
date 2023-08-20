using OrganiDb.Areas.Admin.ViewModels.Banner;
using OrganiDb.Areas.Admin.ViewModels.BannerInfo;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Slider;
using OrganiDb.Models;

namespace OrganiDb.Areas.Admin.ViewModels
{
    public class DashboardVM
    {
        public List<CategoryVM> Categories  { get; set; }
        public List<SliderVM> Sliders { get; set; }
        public List<BannerVM> Banners  { get; set; }
        public List<BannerInfoVM> BannerInfos  { get; set; }
        public IEnumerable<Product> Products  { get; set; }
        public List<Blog_>  Blogs { get; set; }
        public IEnumerable<Assistance> Assistances { get; set; }
        public About_ About  { get; set; }
    }
}
