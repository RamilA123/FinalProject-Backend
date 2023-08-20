using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiDb.Areas.Admin.ViewModels;
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
using OrganiDb.Helpers;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly ISliderService _sliderService;
        private readonly IBannerService _bannerService;
        private readonly IBannerInfoService _bannerInfoService;
        private readonly IProductService _productService;
        private readonly ITagService _tagService;
        private readonly IBlogService _blogService;
        private readonly IAssistanceService _assistanceService;
        private readonly IAboutService _aboutService;
        private readonly IBrandService _brandService;
        private readonly IDiscountService _discountService;
        private readonly IRatingService _ratingService;

        public DashboardController(ICategoryService categoryService, 
                                   ISliderService sliderService, 
                                   IBannerService bannerService,
                                   IBannerInfoService bannerInfoService,
                                   IProductService productService,
                                   ITagService tagService,
                                   IBlogService blogService,
                                   IAssistanceService assistanceService,
                                   IAboutService aboutService,
                                   IBrandService brandService,
                                   IDiscountService discountService,
                                   IRatingService ratingService)
        {
            _categoryService = categoryService;
            _sliderService = sliderService;
            _bannerService = bannerService;
            _bannerInfoService = bannerInfoService;
            _productService = productService;
            _tagService = tagService;
            _blogService = blogService;
            _assistanceService = assistanceService;
            _aboutService = aboutService;
            _brandService = brandService;
            _discountService = discountService;
            _ratingService = ratingService;
        }

        public async Task<IActionResult> Index()
        {
            List<CategoryVM> categories = new();

            List<Category> dbCategories = await _categoryService.GetAllAsync();

            foreach (Category category in dbCategories)
            {
                categories.Add(new CategoryVM
                {
                    Id = category.Id,
                    Image = category.Image,
                    Name = category.Name,
                    ProductCount = category.Products.Count
                });
            }

            List<SliderVM> sliders = new();

            IEnumerable<Slider> dbSliders = await _sliderService.GetAllAsync();

            foreach (Slider slider in dbSliders)
            {
                sliders.Add(new SliderVM
                {
                    Id = slider.Id,
                    Image = slider.Image,
                    Status = slider.Status,
                    Logo = slider.Logo,
                    Text = slider.Text,
                    Title = slider.Title,
                    Description = slider.Description,
                });
            }

            List<BannerVM> banners = new();

            List<Banner> dbBanners = await _bannerService.GetAllAsync();

            foreach (Banner banner in dbBanners)
            {
                banners.Add(new BannerVM
                {
                    Id = banner.Id,
                    Image = banner.Image,
                });
            }

            List<BannerInfoVM> bannerInfos = new();

            List<BannerInfo> dbBannerInfos = await _bannerInfoService.GetAllAsync();

            foreach (BannerInfo bannerInfo in dbBannerInfos)
            {
                bannerInfos.Add(new BannerInfoVM
                {
                    Id = bannerInfo.Id,
                    Title = bannerInfo.Title,
                    Description = bannerInfo.Description
                });
            }

            List<BlogVM> blogs = new();

            List<Blog_> dbBlogs = await _blogService.GetAllAsync();

            foreach (Blog_ blog in dbBlogs)
            {
                blogs.Add(new BlogVM
                {
                    Id = blog.Id,
                    Image = blog.Image,
                    Title = blog.Title,
                    Description = blog.Description,
                    Date = blog.DateTime,
                    Author = blog.Author.FullName,
                    ReviewCount = blog.BlogReviews.Count,
                });
            }

            List<AssistanceVM> assistances = new();

            IEnumerable<Assistance> dbAssistances = await _assistanceService.GetAllAsync();

            About_ dbAbout = await _aboutService.GetAsync();

            foreach (Assistance assistance in dbAssistances)
            {
                assistances.Add(new AssistanceVM
                {
                    Id = assistance.Id,
                    Image = assistance.Image,
                    Title = assistance.Title,
                    Description = assistance.Description,
                    About = assistance.About.Title,
                });
            }

            AboutVM about = new();

            about.Id = dbAbout.Id;
            about.Title = dbAbout.Title;
            about.Description = dbAbout.Description;

            List<BrandVM> brands = new();

            List<Brand> dbBrands = await _brandService.GetAllAsync();

            foreach (Brand brand in dbBrands)
            {
                brands.Add(new BrandVM
                {
                    Id = brand.Id,
                    Image = brand.Image,
                    Name = brand.Name,
                    ProductCount = brand.Products.Count
                });
            }

            List<DiscountVM> discounts = new();

            List<Discount> dbDiscounts = await _discountService.GetAllAsync();

            foreach (Discount discount in dbDiscounts)
            {
                discounts.Add(new DiscountVM
                {
                    Id = discount.Id,
                    Name = discount.Name,
                    Percent = discount.Percent,
                    Title = discount.Title,
                    TargetTime = discount.TargetTime,
                    ProductCount = discount.Products.Count,
                });
            }

            List<RatingVM> ratings = new();

            IEnumerable<Rating> dbRatings = await _ratingService.GetAllAsync();

            foreach (Rating rating in dbRatings)
            {
                ratings.Add(new RatingVM
                {
                    Id = rating.Id,
                    RatingCount = rating.RatingCount,
                    ProductCount = rating.Products.Count,
                });
            }

            List<TagVM> tags = new();

            List<Tag> dbTags = await _tagService.GetAllAsync();

            foreach (Tag tag in dbTags)
            {
                tags.Add(new TagVM
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    ProductCount = tag.ProductTags.Where(m => m.TagId == tag.Id).Count(),
                });
            }

            List<ProductVM> products = new();

            IEnumerable<Product> dbProducts = await _productService.GetAllAsync();

            foreach (Product product in dbProducts)
            {
                products.Add(new ProductVM
                {
                    Id = product.Id,
                    Image = product.ProductImages.FirstOrDefault(m => m.IsMain).Image,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.ActualPrice,
                    Category = product.Category.Name,
                    Discount = product.Discount.Name,
                    Brand = product.Brand.Name,
                    Rating = product.Rating.RatingCount,
                    Tag = product.ProductTags.FirstOrDefault().Tag.Name,
                });
            }

            DashboardVM dashboard = new()
            {
                Categories = categories,
                Sliders = sliders,
                Banners = banners,
                BannerInfos = bannerInfos,
                Products = products,
                Blogs = blogs,
                Assistances = assistances,
                About = about,
                Brands = brands,
                Discounts = discounts,
                Ratings = ratings,
                Tags = tags
            };

            return View(dashboard);
        }
    }
}
