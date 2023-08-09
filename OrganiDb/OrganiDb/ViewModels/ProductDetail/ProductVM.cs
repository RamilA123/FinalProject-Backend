using OrganiDb.Models;

namespace OrganiDb.ViewModels.ProductDetail
{
    public class ProductVM
    {
        public Product Product  { get; set; }
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public List<SocialMedia> SocialMedias  { get; set; }
    }
}
