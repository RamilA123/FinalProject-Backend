using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
