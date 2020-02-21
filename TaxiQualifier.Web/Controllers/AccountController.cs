using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TaxiQualifier.Web.Helpers;
using TaxiQualifier.Web.Models;

namespace TaxiQualifier.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper) //constructor
        {
            _userHelper = userHelper;
        }

        public IActionResult Login() //GET SINTAXIS
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) //POST SINTAXIS
        {
            if (ModelState.IsValid) //ModelState => it means the model of login accomplish requirements
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Failed to login.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
