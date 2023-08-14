using OrganiDb.Models;
using OrganiDb.Responses;
using OrganiDb.ViewModels.Cart;
using OrganiDb.ViewModels.Wishlist;

namespace OrganiDb.Services.Interfaces
{
    public interface IWishlistService
    {
        List<WishlistViewModel> GetAllAsync();
        void AddProduct(List<WishlistViewModel> wishlist, Product product);
        Task<BasketDeleteResponse> DeleteProduct(int? id);
    }
}
