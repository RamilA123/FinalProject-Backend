using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ISocialMediaService
    {
        Task<List<SocialMedia>> GetAllAsync();
    }
}
