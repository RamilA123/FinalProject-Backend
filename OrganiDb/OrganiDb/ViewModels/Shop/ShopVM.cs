using OrganiDb.Models;

namespace OrganiDb.ViewModels.Shop
{
    public class ShopVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public IEnumerable<Product> Products  { get; set; }
    }
}
