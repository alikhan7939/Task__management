using Microsoft.AspNetCore.Mvc;

namespace Task__management.Application.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }
    }
}
