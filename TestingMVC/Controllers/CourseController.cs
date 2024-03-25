using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestingMVC.Models;
using TestingMVC.Repo;
using TestingMVC.ViewModel;

namespace TestingMVC.Controllers
{
    public class CourseController : Controller
    {
       // Context context = new Context();
       // Course/ShowAllCourses
       ICourseRepo courseRepo;
        IDepartmentRepo departmentRepo;
        public CourseController(ICourseRepo _courseRepo , IDepartmentRepo _departmentRepo)
        {
            courseRepo = _courseRepo;
            departmentRepo = _departmentRepo;
        }

        [Authorize]
        public IActionResult ShowAllCourses(string search)
        {
            if (search == null)
            {
                List<Course> courses = courseRepo.GetAll(); //context.Courses.Where(c=>c.isDeleted==false).Include(c => c.Department).ToList();
                return View("ShowAllCourses", courses);
            }
            else
            {
                List<Course> courses = courseRepo.GetAllWithSearch(search);//context.Courses.Include(c => c.Department).Where(c => c.Name .Contains(search) && c.isDeleted==false).ToList();
                return View("ShowAllCourses", courses);
            }

        }



        //AddNew
        public IActionResult AddNew()
        {
            AddNewCourseWithLDepartment addNewCourseWithLDepartment = new AddNewCourseWithLDepartment();
            addNewCourseWithLDepartment.Departments = departmentRepo.GetAll(); // context.Departments.ToList();
            return View("AddNew", addNewCourseWithLDepartment);
        }

        //SaveNew
        public IActionResult SaveNew(AddNewCourseWithLDepartment AddCoursNodel)
        {
            Course course = new Course();
            if (ModelState.IsValid== true)
            {
                
                course.Id = AddCoursNodel.Id;
                course.Name = AddCoursNodel.Name;
                course.Degree = AddCoursNodel.Degree;
                course.MinDegee=AddCoursNodel.MinDegee;
                course.DeptId=AddCoursNodel.DeptId;
                try {
                    courseRepo.Insert(course);   //context.Courses.Add(course);
                    courseRepo.Save();          //context.SaveChanges();
                    return RedirectToAction("ShowAllCourses");
                }
                catch(Exception ex)
                {
                    // ModelState.AddModelError("DeptId","Plz Select Department");
                    ModelState.AddModelError("Erorr" , ex.InnerException.Message);
                    AddCoursNodel.Departments = departmentRepo.GetAll();  //context.Departments.ToList();
                    return View("AddNew", AddCoursNodel);
                }

                
            }
            else
            {
                AddCoursNodel.Departments = departmentRepo.GetAll();//context.Departments.ToList();
                return View("AddNew", AddCoursNodel);

            }

            
        }

        ////Delete
        ///
        public IActionResult Delete(int id)
        {
            Course course = courseRepo.GetById(id);// context.Courses.FirstOrDefault(c => c.Id == id); 
            return View("Delete", course);
        }

        public IActionResult SaveDelete(Course course)
        {
            Course coursToDelete = courseRepo.GetById(course.Id);// context.Courses.FirstOrDefault(c => c.Id == course.Id);
            if (coursToDelete != null)
            {
                coursToDelete.isDeleted= true;
                courseRepo.Delete(coursToDelete.Id);//courseRepo.Update(coursToDelete);//context.Courses.Update(coursToDelete);
                courseRepo.Save();//context.SaveChanges();
                
            }
            return RedirectToAction("ShowAllCourses");

        }


        ///edit Course
        ///
        public IActionResult Edit(int id)
        {
            Course crs = courseRepo.GetById(id);//context.Courses.Include(c=>c.Department).FirstOrDefault(c => c.Id == id);
            if (crs == null)
                return NotFound("Instructor Not Found");
            AddNewCourseWithLDepartment crsVM = new AddNewCourseWithLDepartment();
            crsVM.Id         = crs.Id;
            crsVM.Name       = crs.Name;
            crsVM.Degree     = crs.Degree;
            crsVM.MinDegee   = crs.MinDegee;
            crsVM.Hours      = crs.Hours;
            crsVM.DeptId     = crs.DeptId;
            crsVM.Departments = departmentRepo.GetAll(); //context.Departments.ToList();
            return View("Edit", crsVM);
        }

        public IActionResult SaveEdit(AddNewCourseWithLDepartment crsVM)
        {
            if (ModelState.IsValid == true)
            {
                Course crs = courseRepo.GetById(crsVM.Id);//context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == crsVM.Id);
                crs.Id = crsVM.Id;
                crs.Name = crsVM.Name;
                crs.Degree = crsVM.Degree;
                crs.MinDegee = crsVM.MinDegee;
                crs.Hours = crsVM.Hours;
                crs.DeptId = crsVM.DeptId;
                courseRepo.Save();//context.SaveChanges();

                return RedirectToAction("ShowAllCourses");
            }
            // instructorMV.Courses = context.Courses.ToList();
            else
            {
                crsVM.Departments = departmentRepo.GetAll();//context.Departments.ToList();
                return View("Edit", crsVM);
            }
            

        }

        /////task 6
        ///
        public IActionResult GetCoursesInDept(int deptId)
        {
            List<Course> courses = courseRepo.GetCoursesInDept(deptId); //context.Courses.Where(c=>c.DeptId== deptId).ToList();  
            return Json(courses);
        }


        public IActionResult CourseDetails(int id)
        {
            Course course = courseRepo.GetById(id); //context.Courses.SingleOrDefault(c => c.Id == id);
            return PartialView("CourseDetails",course);
        }


        /////
        ///
        public IActionResult CheckMin(int MinDegee, int Degree)
        {
            if (MinDegee < Degree)
                return Json(true);
            else
                return Json(false);
        }

        public IActionResult CheckHours(int Hours)
        {
            if (Hours %3==0)
                return Json(true);
            else
                return Json(false);
        }
    }
}
