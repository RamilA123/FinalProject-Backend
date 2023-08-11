using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetPaginatedDatasAsync(int page,int take);
        Task<Product> GetByIdAsync(int? id);
        Task<int> GetCountAsync();
    }
}
