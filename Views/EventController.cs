using Microsoft.AspNetCore.Mvc;

namespace CSSApp.Views
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
