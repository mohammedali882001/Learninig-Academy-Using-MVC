using Microsoft.AspNetCore.Mvc;
using TestingMVC.Models;
using System.Text.Json.Serialization;

namespace TestingMVC.Controllers
{
    public class StateController : Controller
    {
        //State/SetSession
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Ashraf");
            HttpContext.Session.SetInt32("Age", 28);
            return Content("Setting session Successfully");
        }

        //State/GetSession
        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("Name");
            int? age = HttpContext.Session.GetInt32("Age");
            return Content($"Name : {name} , Age : {age}");
        }

    }
}
