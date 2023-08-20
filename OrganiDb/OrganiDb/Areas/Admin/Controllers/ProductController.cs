using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Product;
using OrganiDb.Helpers;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        private readonly IProductService _productService;
        private readonly ITagService _tagService;

        public ProductController(IProductService productService, ITagService tagService)
        {
            _productService = productService;
            _tagService = tagService;
        }
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            List<ProductVM> products = new();

            IEnumerable<Product> dPproducts = await _productService.GetPaginatedDatasAsync(page, take);

            int productCount = await _productService.GetCountAsync();

            int totalPage = (int)Math.Ceiling((decimal)productCount / take);

            Pagination<Product> paginatedProducts = new(dPproducts, page, totalPage);

            List<Tag> tags = await _tagService.GetAllAsync();

            foreach (Product product in paginatedProducts.Datas)
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
                    HasPrevious = paginatedProducts.HasPrevious,
                    HasNext = paginatedProducts.HasNext,
                    CurrentPage = paginatedProducts.CurrentPage,
                    TotalPage = paginatedProducts.TotalPage
                });
            }

            return View(products);

        }
    }
}
