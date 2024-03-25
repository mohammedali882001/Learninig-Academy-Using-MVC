using TestingMVC.Models;

namespace TestingMVC.ViewModel
{
    public class CoursesViewModel
    {
        public List<Course> Courses { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Search { get; set; }
    }
}
