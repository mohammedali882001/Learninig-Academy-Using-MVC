using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using TestingMVC.Models;

namespace TestingMVC.ViewModel
{
    public class UniqueAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            //Context context = new Context();
            Context context = validationContext.GetService<Context>();

            string name = value.ToString();
            AddNewCourseWithLDepartment CrsFromRequest = validationContext.ObjectInstance as AddNewCourseWithLDepartment;
           // Debug.WriteLine(CrsFromRequest.DeptId);
            Course CrcFromDb=context.Courses
                .FirstOrDefault(c => c.Name == name && c.Id!= CrsFromRequest.Id && c.DeptId == CrsFromRequest.DeptId);//&& c.DeptId== CrsFromRequest.DeptId
            if (CrcFromDb == null)
            {
                //value valid
                return ValidationResult.Success;
            }

            return new ValidationResult("Name Already Found");
        }
    }
}
