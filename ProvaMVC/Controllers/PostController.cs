using Microsoft.AspNetCore.Mvc;

namespace ProvaMVC.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
