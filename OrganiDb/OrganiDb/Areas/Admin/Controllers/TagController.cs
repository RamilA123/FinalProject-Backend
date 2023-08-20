using Microsoft.AspNetCore.Mvc;
using OrganiDb.Areas.Admin.ViewModels.Category;
using OrganiDb.Areas.Admin.ViewModels.Tag;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IActionResult> Index()
        {
            List<TagVM> tags = new();

            List<Tag> dbTags = await _tagService.GetAllAsync();


            foreach (Tag tag in dbTags)
            {
                tags.Add(new TagVM
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    ProductCount = tag.ProductTags.Where(m => m.TagId == tag.Id).Count(),
                });
            }

            return View(tags);
        }
    }
}
