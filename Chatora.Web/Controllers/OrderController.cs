using Microsoft.AspNetCore.Mvc;

namespace Chatora.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult OrderIndex()
        {
            return View();
        }
    }
}
