using Microsoft.AspNetCore.Mvc;

namespace Somoy.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
