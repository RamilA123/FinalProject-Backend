using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
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

            return View(categories);
        }
    }
}
