using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ITagService
    {
        Task<List<Tag>> GetAllAsync();
    }
}
