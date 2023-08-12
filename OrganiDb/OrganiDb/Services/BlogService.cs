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
    }
}
