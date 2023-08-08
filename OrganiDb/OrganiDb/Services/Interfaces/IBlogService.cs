using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<Blog_>> GetAllAsync();
    }
}
