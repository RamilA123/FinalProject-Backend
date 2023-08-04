using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IBannerInfoService
    {
        Task<List<BannerInfo>> GetAllAsync();
    }
}
