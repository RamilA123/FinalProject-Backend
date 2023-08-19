using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            IEnumerable<Product> products = await _productService.GetPaginatedDatasAsync(page, take);

            int productCount = await _productService.GetCountAsync();

            int totalPage = (int)Math.Ceiling((decimal)productCount / take);

            Pagination<Product> paginatedBlogs = new(products, page, totalPage);

            List<Tag> tags = await _tagService.GetAllAsync();

            return View(paginatedBlogs);

        }
    }
}
