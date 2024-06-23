using Microsoft.AspNetCore.Mvc;

namespace SoftUITheme_Dotnet.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
