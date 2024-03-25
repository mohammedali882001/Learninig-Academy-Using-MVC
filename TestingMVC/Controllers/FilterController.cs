using Microsoft.AspNetCore.Mvc;
using TestingMVC.Filter;

namespace TestingMVC.Controllers
{
    public class FilterController : Controller
    {
        [HandleError]
        public IActionResult Index()
        {
            throw new NotImplementedException();
        }
    }
}
