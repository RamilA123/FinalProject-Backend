using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IRatingService
    {
        Task<IEnumerable<Rating>> GetAllAsync();
    }
}
