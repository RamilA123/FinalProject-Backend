using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<Blog_>> GetAllAsync();
        Task<List<Blog_>> GetPaginatedDatasAsync(int page,int take);
        Task<int> GetCountAsync();
    }
}
