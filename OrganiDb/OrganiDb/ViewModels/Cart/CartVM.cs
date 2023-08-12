using OrganiDb.Models;

namespace OrganiDb.ViewModels.Cart
{
    public class CartVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public List<BasketDetailVM> Baskets  { get; set; }
    }
}
