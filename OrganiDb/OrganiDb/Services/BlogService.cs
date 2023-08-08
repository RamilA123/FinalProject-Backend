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
    }
}
