using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class AssistanceService : IAssistanceService
    {
        private readonly AppDbContext _context;

        public AssistanceService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Assistance>> GetAllAsync()
        {
            return await _context.Assistances.ToListAsync();
        }
    }
}
