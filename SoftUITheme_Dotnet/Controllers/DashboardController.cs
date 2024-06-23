using Microsoft.AspNetCore.Mvc;

namespace SoftUITheme_Dotnet.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
