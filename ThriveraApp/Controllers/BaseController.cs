using Microsoft.AspNetCore.Mvc;

namespace ThriveraApp.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
