using Auth.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Web.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public  IActionResult SignUp()
        {
            return View();
        }
    }
}
