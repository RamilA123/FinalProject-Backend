using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<Blog_>> GetAllAsync();
        Task<List<Blog_>> GetPaginatedDatasAsync(int page,int take);
        Task<int> GetCountAsync();
        Task<List<Blog_>> SearchByBlogsAsync(string searchText);
        Task<List<Blog_>> SortByAscendingTitleAsync();
        Task<List<Blog_>> SortByDescendingTitleAsync();
    }
}
