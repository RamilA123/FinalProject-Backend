using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;
using System.Security.Claims;

namespace OrganiDb.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        private readonly IAccountService _accountService;
        private readonly ISocialMediaService _socialMediaService;

        public LayoutService(AppDbContext context, IHttpContextAccessor accessor, 
                                                   IAccountService accountService, 
                                                   ISocialMediaService socialMediaService)
        {
            _context = context;
            _accessor = accessor;
            _accountService = accountService;
            _socialMediaService = socialMediaService;
        }

        public async Task<LayoutVM> GetAllDatas()
        {
            Dictionary<string, string> settingDatas = _context.Settings.AsEnumerable().ToDictionary(m => m.Key, m => m.Value);

            List<SocialMedia> socialMedias = await _socialMediaService.GetAllAsync();

            string userId = _accessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            AppUser user = await _accountService.FindByIdAsync(userId);

            LayoutVM data = new()
            {
                SettingDatas = settingDatas,
                User = user,
                SocialMedias = socialMedias
            };

            return data;
        }
    }
}
