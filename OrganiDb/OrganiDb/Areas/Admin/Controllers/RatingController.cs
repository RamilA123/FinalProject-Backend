using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Rating;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task<IActionResult> Index()
        {
            List<RatingVM> ratings = new();

            IEnumerable<Rating>dbRatings = await _ratingService.GetAllAsync();

            foreach (Rating rating in dbRatings)
            {
                ratings.Add(new RatingVM
                {
                    Id = rating.Id,
                    RatingCount = rating.RatingCount,
                    ProductCount = rating.Products.Count,
                });
            }

            return View(ratings);
        }
    }
}
