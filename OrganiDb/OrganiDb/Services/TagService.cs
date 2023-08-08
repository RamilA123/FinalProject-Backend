using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class TagService : ITagService
    {
        private readonly AppDbContext _context;

        public TagService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Tag>> GetAllAsync()
        {
            return await _context.Tags.Include(m => m.ProductTags).ToListAsync();
        }

    }
}
