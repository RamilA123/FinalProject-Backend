using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;

        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Blog_>> GetAllAsync()
        {
            return await _context.Blogs.Include(m => m.Author).Include(m => m.BlogReviews).ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Blogs.CountAsync();
        }

        public async Task<List<Blog_>> GetPaginatedDatasAsync(int page, int take)
        {
            return await _context.Blogs.Include(m => m.Author).Include(m => m.BlogReviews).Skip((page-1)*take).Take(take).ToListAsync();
        }

        public async Task<List<Blog_>> SearchByBlogsAsync(string searchText)
        {
            List<Blog_> blogs = await GetAllAsync();

            blogs = blogs.Where(m => m.Title.ToLower().Contains(searchText.ToLower())).ToList();

            return blogs;
        }

        public async Task<List<Blog_>> SortByAscendingTitleAsync()
        {
            List<Blog_> blogs = await GetAllAsync();

            blogs = blogs.OrderBy(m => m.Title).ToList();

            return blogs;
        }

        public async Task<List<Blog_>> SortByDescendingTitleAsync()
        {
            List<Blog_> blogs = await GetAllAsync();

            blogs = blogs.OrderByDescending(m => m.Title).ToList();

            return blogs;
        }
    }
}
