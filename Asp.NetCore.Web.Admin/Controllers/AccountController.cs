using Asp.NetCore.Services.Models.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.Web.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            var model = new LoginViewModel { ReturnUrl = "/" };            
            return View(model);
        }
    }
}
