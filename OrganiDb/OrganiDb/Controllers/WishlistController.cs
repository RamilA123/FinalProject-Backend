using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
