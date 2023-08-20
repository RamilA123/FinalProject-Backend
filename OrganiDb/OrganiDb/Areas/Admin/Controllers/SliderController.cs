using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Slider;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> Index()
        {
            List<SliderVM> sliders = new();

            IEnumerable<Slider> dbSliders = await _sliderService.GetAllAsync();

            foreach (Slider slider in dbSliders)
            {
                sliders.Add(new SliderVM
                {
                    Id = slider.Id,
                    Image = slider.Image,
                    Status = slider.Status,
                    Logo = slider.Logo,
                    Text = slider.Text,
                    Title= slider.Title,
                    Description = slider.Description,
                });
            }

            return View(sliders);
        }
    }
}
