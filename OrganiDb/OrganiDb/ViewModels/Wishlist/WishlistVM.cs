using OrganiDb.Models;
using OrganiDb.ViewModels.Cart;

namespace OrganiDb.ViewModels.Wishlist
{
    public class WishlistVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public List<WishlistDetailVM> Wishlists { get; set; }
    }
}
