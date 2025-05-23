
using Microsoft.AspNetCore.Mvc;

namespace PawVerse.Controllers   // đổi theo namespace thật
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            // TODO: lấy cart từ session / database
            return View(); // cart.html Razor
        }
    }
}