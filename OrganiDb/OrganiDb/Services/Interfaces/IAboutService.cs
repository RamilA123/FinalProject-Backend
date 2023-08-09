using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IAboutService
    {
        Task<About_> GetAsync();
    }
}
