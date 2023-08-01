using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
