using System.ComponentModel.DataAnnotations.Schema;
using TestingMVC.Models;

namespace TestingMVC.ViewModel
{
    public class InstuctorAddithListOfDeptAndCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
        public int CrsId { get; set; }

        public List<Department> Departments { get; set; }
        public List<Course> Courses { get; set; }



    }
}
