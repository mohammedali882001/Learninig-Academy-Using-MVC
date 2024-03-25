using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace TestingMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult AddRole()
        {
            return View("AddRole");
        }

        public async Task<IActionResult> SaveRole(RoleViewModel roleViewModel)
        {
            if (roleViewModel != null)
            {
                IdentityRole identityRole=new IdentityRole() { Name = roleViewModel.Name };
                IdentityResult result=  await roleManager.CreateAsync(identityRole); 
                if (result.Succeeded)
                {
                    return RedirectToAction("ShowAllCourses", "Course");
                }
                foreach (var item in result.Errors)
                  ModelState.AddModelError("", item.Description);
                
            }
            return View("AddRole");
        }
    }
}
