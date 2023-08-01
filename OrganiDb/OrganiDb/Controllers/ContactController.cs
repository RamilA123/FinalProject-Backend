using Microsoft.AspNetCore.Mvc;

namespace OrganiDb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
