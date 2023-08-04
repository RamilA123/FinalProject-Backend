using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IBannerService
    {
        Task<List<Banner>> GetAllAsync();
    }
}
