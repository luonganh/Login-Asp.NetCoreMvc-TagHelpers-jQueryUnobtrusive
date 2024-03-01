using Asp.NetCore.Services.Identity;
using Asp.NetCore.Services.Models.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Asp.NetCore.Web.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IIdentityService _identityService;
        public AccountController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

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
            if (await _identityService.LoginAsync(ModelState, model) == false)
            {
                return View(model);
            }
            return Redirect(model.ReturnUrl);
        }
    }
}
