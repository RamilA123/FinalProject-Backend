using Microsoft.AspNetCore.Mvc;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;

namespace OrganiDb.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;

        public FooterViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            LayoutVM data = await _layoutService.GetAllDatas();

            return await Task.FromResult(View(data));
        }
    }
}
