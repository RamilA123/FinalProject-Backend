using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllAsync();
    }
}
