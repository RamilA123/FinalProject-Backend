using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.Include(m => m.Position).ToListAsync();
        }
    }
}
