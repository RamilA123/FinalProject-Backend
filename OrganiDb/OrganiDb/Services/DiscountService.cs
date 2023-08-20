using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly AppDbContext _context;

        public DiscountService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Discount> GetAsync()
        {
            return await _context.Discounts.FirstOrDefaultAsync();
        }

        public async Task<List<Discount>> GetAllAsync()
        {
            return await _context.Discounts.Include(m => m.Products).ToListAsync();
        }
    }
}
