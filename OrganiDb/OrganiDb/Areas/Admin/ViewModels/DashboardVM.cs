using OrganiDb.Areas.Admin.ViewModels.About;
using OrganiDb.Areas.Admin.ViewModels.Assistance;
using OrganiDb.Areas.Admin.ViewModels.Banner;
using OrganiDb.Areas.Admin.ViewModels.BannerInfo;
using OrganiDb.Areas.Admin.ViewModels.Blog;
using OrganiDb.Areas.Admin.ViewModels.Brand;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Discount;
using OrganiDb.Areas.Admin.ViewModels.Product;
using OrganiDb.Areas.Admin.ViewModels.Rating;
using OrganiDb.Areas.Admin.ViewModels.Slider;
using OrganiDb.Areas.Admin.ViewModels.Tag;
using OrganiDb.Models;

namespace OrganiDb.Areas.Admin.ViewModels
{
    public class DashboardVM
    {
        public List<CategoryVM> Categories  { get; set; }
        public List<SliderVM> Sliders { get; set; }
        public List<BannerVM> Banners  { get; set; }
        public List<BannerInfoVM> BannerInfos  { get; set; }
        public IEnumerable<ProductVM> Products  { get; set; }
        public List<BlogVM>  Blogs { get; set; }
        public IEnumerable<AssistanceVM> Assistances { get; set; }
        public AboutVM About  { get; set; }
        public List<BrandVM> Brands  { get; set; }
        public List<DiscountVM> Discounts  { get; set; }
        public List<RatingVM> Ratings  { get; set; }
        public List<TagVM> Tags { get; set; }
    }
}
