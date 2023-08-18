using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetPaginatedDatasAsync(int page,int take);
        Task<Product> GetByIdWithImagesAsync(int? id);
        Task<Product> GetByIdAsync(int? id);
        Task<int> GetCountAsync();
        Task<IEnumerable<Product>> SearchByProductsAsync(string searchText);
        Task<IEnumerable<Product>> FilterByCategoryAsync(int? id);
        Task<IEnumerable<Product>> FilterByPriceAsync(string minumumValue, string maximumValue);
        Task<IEnumerable<Product>> FilterByRatingAsync(int? id);
        Task<IEnumerable<Product>> FilterByTagAsync(int? id);
        Task<IEnumerable<Product>> FilterByBrandAsync(int? id);
        Task<IEnumerable<Product>> SortByDescendingPriceAsync();
        Task<IEnumerable<Product>> SortByAscendingPriceAsync();
        Task<IEnumerable<Product>> SortByAscendingNameAsync();
        Task<IEnumerable<Product>> SortByDescendingNameAsync();

    }
}
