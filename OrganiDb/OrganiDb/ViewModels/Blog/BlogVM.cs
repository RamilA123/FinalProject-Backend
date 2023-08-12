using OrganiDb.Helpers;
using OrganiDb.Models;

namespace OrganiDb.ViewModels.Blog
{
    public class BlogVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public Pagination<Blog_> PaginatedBlogs { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
