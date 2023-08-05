using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly AppDbContext _context;

        public SocialMediaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<SocialMedia>> GetAllAsync()
        {
            return await _context.SocialMedias.ToListAsync();
        }
    }
}
