using OrganiDb.Models;
using OrganiDb.Responses;
using OrganiDb.ViewModels.Cart;

namespace OrganiDb.Services.Interfaces
{
    public interface IBasketService
    {
        List<BasketVM> GetAllAsync();
        void AddProduct(List<BasketVM> basket, Product product);
        Task<BasketDeleteResponse> DeleteProduct(int? id);

    }
}
