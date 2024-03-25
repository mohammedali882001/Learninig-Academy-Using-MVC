using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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
                   // IdentityResult roleResult = await userManager.AddToRoleAsync(user,"Admin");
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
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim("Institute","ITI"));
                       //await  signInManager.SignInWithClaimsAsync(applicationUserDB,loginViewModel.RememberMe, claims);   
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

        [Authorize]
        public IActionResult Test()
        {
            string name = User.Identity.Name;
            Claim claim =  User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            //Claim claim2 = User.Claims.FirstOrDefault(c => c.Type == "Institute");
            bool HasRoe = User.IsInRole("Admin");

            return Content(name + "   " + claim.Value);// + "  "+ claim2.Value);
        }
    
    }
}
