using Microsoft.AspNetCore.Mvc;
using OrganiDb.Models;
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
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productService.GetAllAsync();
            List<Tag> tags = await _tagService.GetAllAsync();

            return View(products);
        }
    }
}
