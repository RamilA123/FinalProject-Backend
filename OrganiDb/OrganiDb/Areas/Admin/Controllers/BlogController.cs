using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Blog;
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
            List<BlogVM> blogs = new();

            List<Blog_> dbBlogs = await _blogService.GetPaginatedDatasAsync(page, take);

            int blogCount = await _blogService.GetCountAsync();

            int totalPage = (int)Math.Ceiling((decimal)blogCount / take);

            Pagination<Blog_> paginatedBlogs = new(dbBlogs, page, totalPage);

            foreach (Blog_ blog in paginatedBlogs.Datas)
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
                    HasPrevious = paginatedBlogs.HasPrevious,
                    HasNext = paginatedBlogs.HasNext,
                    CurrentPage = paginatedBlogs.CurrentPage,
                    TotalPage = paginatedBlogs.TotalPage
                });
            }

            return View(blogs);
        }
    }
}
