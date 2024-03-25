using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestingMVC.Models;

namespace TestingMVC.ViewModel
{
    public class AddNewCourseWithLDepartment
    {
        public int Id { get; set; }
        [MaxLength(25 ,ErrorMessage ="nameMust be Less Than 25 letter") ]
        [MinLength(3 , ErrorMessage ="Name Must Be More Than 3 Letter") ]
        [Unique(ErrorMessage ="Name Must Be Unique")]
        public string Name { get; set; }

        [Range(50,100 , ErrorMessage ="The Degree Must Be Betwen 50 And 100")]
        public int Degree { get; set; }
        [Remote("CheckMin", "Course"
            , ErrorMessage = "Min must be less than Degree", AdditionalFields = "Degree")]
        public int MinDegee { get; set; }
        [Remote("CheckHours", "Course"
            , ErrorMessage = "Hours must be divided by 3")]
        public int Hours { get; set; }

        public int DeptId { get; set; }
        public List<Department>? Departments { get; set; }
       
    }
}
