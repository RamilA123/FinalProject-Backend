using Microsoft.AspNetCore.Mvc;
using OrganiDb.Helpers;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            List<Blog_> blogs = await _blogService.GetPaginatedDatasAsync(page, take);

            int blogCount = await _blogService.GetCountAsync();

            int totalPage = (int)Math.Ceiling((decimal)blogCount / take);

            Pagination<Blog_> paginatedBlogs = new(blogs, page, totalPage);

            return View(paginatedBlogs);
        }
    }
}
