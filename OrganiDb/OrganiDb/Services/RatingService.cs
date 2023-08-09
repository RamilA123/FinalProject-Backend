using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class RatingService : IRatingService
    {
        private readonly AppDbContext _context;

        public RatingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rating>> GetAllAsync()
        {
            return await _context.Ratings.Include(m => m.Products).ToListAsync(); 
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Ratings.CountAsync();
        }
    }
    
}
