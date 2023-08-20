using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Brand;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IProductService _productService;

        public BrandController(IBrandService brandService, IProductService productService)
        {
            _brandService = brandService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
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

            return View(brands);
        }
    }
}
