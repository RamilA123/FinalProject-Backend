using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class BannerInfoService : IBannerInfoService
    {
        private readonly AppDbContext _context;

        public BannerInfoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<BannerInfo>> GetAllAsync()
        {
            return await _context.BannerInfos.ToListAsync();
        }
    }
}
