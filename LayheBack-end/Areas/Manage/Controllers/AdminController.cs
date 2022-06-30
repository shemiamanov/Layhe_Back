using Microsoft.AspNetCore.Mvc;

namespace LayheBack_end.Areas.Manage.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
