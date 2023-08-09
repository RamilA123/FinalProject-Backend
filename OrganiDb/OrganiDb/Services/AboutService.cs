using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class AboutService : IAboutService
    {

        private readonly AppDbContext _context;

        public AboutService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<About_> GetAsync()
        {
            return await _context.Abouts.Include(m => m.Assistances).FirstOrDefaultAsync();
        }
    }
}
