using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;
using OrganiDb.ViewModels.Cart;
using OrganiDb.ViewModels.Wishlist;
using System.Security.Claims;
using System.Text.Json;

namespace OrganiDb.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessorService;
        private readonly IAccountService _accountService;
        private readonly ISocialMediaService _socialMediaService;

        public LayoutService(AppDbContext context, IHttpContextAccessor accessorService, 
                                                   IAccountService accountService, 
                                                   ISocialMediaService socialMediaService)
        {
            _context = context;
            _accessorService = accessorService;
            _accountService = accountService;
            _socialMediaService = socialMediaService;
        }

        public async Task<LayoutVM> GetAllDatasAsync()
        {
            List<BasketVM> existedproducts = new List<BasketVM>();
            List<WishlistViewModel> existedWishlistproducts = new List<WishlistViewModel>();

            Dictionary<string, string> settingDatas = _context.Settings.AsEnumerable().ToDictionary(m => m.Key, m => m.Value);

            if (_accessorService.HttpContext.Request.Cookies["basket"] != null)
            {
                existedproducts = JsonSerializer.Deserialize<List<BasketVM>>(_accessorService.HttpContext?.Request.Cookies["basket"]);
            }

            if (_accessorService.HttpContext.Request.Cookies["wishlist"] != null)
            {
                existedWishlistproducts = JsonSerializer.Deserialize<List<WishlistViewModel>>(_accessorService.HttpContext?.Request.Cookies["wishlist"]);
            }

            int basketCount = existedproducts.Sum(m => m.Count);
            int wishlistCount = existedWishlistproducts.Sum(m => m.Count);

            List<SocialMedia> socialMedias = await _socialMediaService.GetAllAsync();

            string userId = _accessorService.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            AppUser user = await _accountService.FindByIdAsync(userId);

            LayoutVM data = new()
            {
                SettingDatas = settingDatas,
                User = user,
                BasketCount = basketCount,
                SocialMedias = socialMedias,
                WishlistCount = wishlistCount,
            };

            return data;
        }
    }
}
