using FlowerApp.Auth;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FlowerApp.Controllers
{
    //controller class for account
    [Authorize]
    //using base class Controller
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        //constructor for AccountController
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //disables authentication 
        [AllowAnonymous]
        // LOGIN
        public IActionResult Login(string returnUrl)
        {
            //url for login
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        //for data storage
        [HttpPost]

        //disables authentication 
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                //user has a username and a password
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                //the username and password are correct
                if (result.Succeeded)
                {
                    //redirect to home page
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");
                    //else remain in this page
                    return Redirect(loginViewModel.ReturnUrl);
                }
            }
            //message for username or password not found
            ModelState.AddModelError("", "Username/password not found");
            //remain in login page
            return View(loginViewModel);
        }

        //Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        //for data storage 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                //create username
                var user = new ApplicationUser() { UserName = loginViewModel.UserName };
                var result = await _userManager.CreateAsync(user, loginViewModel.Password);

                //successful registration redirects us to the home page
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            //message for adding an username that already exist
            ModelState.AddModelError("", "This Username already exist!");
            return View(loginViewModel);
        }


        //for data storage
        [HttpPost]
        //LOGOUT
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //redirect to the home page
            return RedirectToAction("Index", "Home");
        }
    }
}
