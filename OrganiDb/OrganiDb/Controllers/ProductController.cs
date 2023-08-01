using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
