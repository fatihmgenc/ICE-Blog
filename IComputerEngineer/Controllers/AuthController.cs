using IComputerEngineer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IComputerEngineer.Controllers
{
    public class AuthController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;

        public AuthController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!string.IsNullOrEmpty(loginViewModel.UserName) && !string.IsNullOrEmpty(loginViewModel.Password))
            {
                await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, false, false);
                return RedirectToAction("Index", "Panel");
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
