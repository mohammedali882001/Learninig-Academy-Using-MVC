using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestingMVC.Models;

namespace TestingMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View("Register");
        }

        public async Task<IActionResult> RegisterSave(RegisterUserViewModel registerUserVM)
        {
            if(ModelState.IsValid==true)
            {
                //save in database
                //UserManager<ApplicationUser> userManager;
                ApplicationUser user = new ApplicationUser() {
                    UserName = registerUserVM.UserName,
                    Address = registerUserVM.Address,
                    PasswordHash = registerUserVM.Password
                
                };
                  IdentityResult result=  await userManager.CreateAsync(user, registerUserVM.Password);
                if(result.Succeeded)
                {
                    //generate cookie
                    await  signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("ShowAllCourses", "Course");

                }
                foreach (var item in result.Errors)
                    ModelState.AddModelError("", item.Description);
             }

            return View("Register",registerUserVM);
        }
    
    ////Login
    ///

        public IActionResult Login()
        {
            return View("Login");
        }

        public async Task< IActionResult> SaveLogin(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid==true)
            {
              ApplicationUser applicationUserDB= await userManager.FindByNameAsync(loginViewModel.Username);
               if (applicationUserDB != null)
                {
                   bool found= await userManager.CheckPasswordAsync(applicationUserDB, loginViewModel.Password);
                    if (found == true)
                    {
                       await signInManager.SignInAsync(applicationUserDB, loginViewModel.RememberMe);
                        return RedirectToAction("ShowAllCourses", "Course");
                    }
                }

                ModelState.AddModelError("", "Invalid Data Please Try Again");
            }
            return View("Login",loginViewModel);
        }
        
        public async Task<IActionResult>LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }


        public IActionResult Test()
        {
            return Content("leo");
        }
    
    }
}
