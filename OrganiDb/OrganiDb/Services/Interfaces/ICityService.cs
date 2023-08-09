using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
    }
}
