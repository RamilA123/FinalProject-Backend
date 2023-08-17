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
        IEnumerable<Product> SearchByProducts(IEnumerable<Product> products, string searchText);
        Task<IEnumerable<Product>> FilterByCategoryAsync(int? id);
        Task<IEnumerable<Product>> FilterByPriceAsync(string minumumValue, string maximumValue);
        Task<IEnumerable<Product>> FilterByRatingAsync(int? id);
        Task<IEnumerable<Product>> FilterByTagAsync(int? id);
        Task<IEnumerable<Product>> FilterByBrandAsync(int? id);
        Task<IEnumerable<Product>> SortByDescendingPrice();
        Task<IEnumerable<Product>> SortByAscendingPrice();
        Task<IEnumerable<Product>> SortByAscendingName();
        Task<IEnumerable<Product>> SortByDescendingName();

    }
}
