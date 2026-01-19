using Microsoft.AspNetCore.Mvc;

namespace FirstEmpty.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            ViewData["Title"] = "Index";
            return View();
        }
        public IActionResult Name()
        {
			ViewData["Title"] = "Name";
			return View();
        }
    }
}
