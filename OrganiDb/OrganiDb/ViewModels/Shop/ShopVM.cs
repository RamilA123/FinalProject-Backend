using OrganiDb.Helpers;
using OrganiDb.Models;

namespace OrganiDb.ViewModels.Shop
{
    public class ShopVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public Pagination<Product> PaginatedProducts { get; set; }
        public List<Category> Categories  { get; set; }
        public IEnumerable<Rating> Ratings  { get; set; }
        public List<Tag> Tags  { get; set; }
        public List<Brand> Brands  { get; set; }
    }
}
