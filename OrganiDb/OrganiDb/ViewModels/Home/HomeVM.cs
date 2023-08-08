using OrganiDb.Models;

namespace OrganiDb.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Assistance> Assistances { get; set; }
        public List<Category> Categories  { get; set; }
        public IEnumerable<Product> Products  { get; set; }
        public List<Brand> Brands { get; set; }
        public IEnumerable<Customer> Customers  { get; set; }
        public List<Blog_> Blogs { get; set; }
        public Discount Discount  { get; set; }
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
     
    }
}
