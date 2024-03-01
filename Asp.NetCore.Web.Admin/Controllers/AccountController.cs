using Asp.NetCore.Services.Models.Identity;
using Asp.NetCore.Shared.Models;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost("/login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return Redirect(model.ReturnUrl);
        }
    }
}
