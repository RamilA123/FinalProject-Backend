using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.Include(m => m.Products).ToListAsync();
        }
    }
}
