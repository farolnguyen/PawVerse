using Microsoft.AspNetCore.Mvc;

namespace PawVerse.Controllers   // đổi theo namespace thật
{
    public class ProductController : Controller
    {
        /// GET /Product  (hoặc /Product/Index)
        public IActionResult Index()
        {
            // TODO: lấy danh sách sản phẩm (hiện chưa có CSDL, cứ trả View rỗng)
            return View();           // tự tìm Views/Product/Index.cshtml
        }

        /// GET /Product/Info/5     (chi-tiết)
        public IActionResult Info(int id)
        {
            // TODO: lấy Product theo id
            // if (product == null) return NotFound();
            ViewData["Id"] = id;     // demo
            return View();           // Views/Product/Info.cshtml
        }
    }
}
