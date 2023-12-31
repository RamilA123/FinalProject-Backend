﻿using Microsoft.AspNetCore.Mvc;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels;

namespace OrganiDb.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;
       

        public HeaderViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            LayoutVM data = await _layoutService.GetAllDatasAsync();

            return await Task.FromResult(View(data));
        }
    }
}
