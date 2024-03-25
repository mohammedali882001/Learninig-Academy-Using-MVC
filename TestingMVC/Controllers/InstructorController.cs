using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using TestingMVC.Models;
using TestingMVC.Repo;

namespace TestingMVC.Controllers
{
    public class InstructorController : Controller
    {
        // Context context = new Context();
        //Instructor/Index
        IInstructorRepo InstructorRepo;
        ICourseRepo CourseRepo;
        IDepartmentRepo DepartmentRepo;
        public InstructorController(IInstructorRepo _InstructorRepo, ICourseRepo courseRepo, IDepartmentRepo departmentRepo)
        {
            InstructorRepo = _InstructorRepo;
            CourseRepo = courseRepo;
            DepartmentRepo = departmentRepo;
        }
        public IActionResult Index(string search, int page = 1, int pageSize = 5)
        {
            List<Instructor> instructors = InstructorRepo.GetAll(); //context.Instructors.Where(i=>i.isDeleted==false).Include(i => i.Course).Include(i => i.Department).ToList(); 
            if(search==null)
            {
                int totalItems = instructors.Count;
                instructors = instructors.Skip((page - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToList();


                int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

                ViewBag.PageNumber = page;
                ViewBag.TotalPages = totalPages;
                ViewBag.PageSize = pageSize;
                return View("ShowAll", instructors);
            }
            else 
            {
                List<Instructor> instructors2 = InstructorRepo.GetAllWithSearch(search);//context.Instructors.Where(i => i.Name.Contains(search) && i.isDeleted==false).Include(i => i.Course).Include(i => i.Department).ToList(); 

                return View("ShowAll", instructors2);

            }

        }

        //Instructor/Details?id=1
        public IActionResult Details(int id)
        {
            Instructor instructor = InstructorRepo.GetById(id);//context.Instructors.Include(i => i.Course).Include(i => i.Department).FirstOrDefault(i => i.Id == id); 
            return View("Details", instructor);
        }

        public IActionResult AddNew()
        {
            InstuctorAddithListOfDeptAndCourse instructorMV=new InstuctorAddithListOfDeptAndCourse();
            instructorMV.Courses = CourseRepo.GetAll();//context.Courses.ToList();
            instructorMV.Departments = DepartmentRepo.GetAll();//context.Departments.ToList();
            return View("AddNew", instructorMV);
        }

        public IActionResult SaveNew(InstuctorAddithListOfDeptAndCourse instructorMV)
        {
            Instructor ins = new Instructor();
            if (instructorMV.Name != null)
            {
                ins.Name = instructorMV.Name;
                ins.Salary = instructorMV.Salary;
                ins.Address = instructorMV.Address;
                ins.Id = instructorMV.Id;
                ins.Image = instructorMV.Image;
                ins.CrsId = instructorMV.CrsId;
                ins.DeptId = instructorMV.DeptId;
                InstructorRepo.Insert(ins);//context.Instructors.Add(ins);
                InstructorRepo.Save();//context.SaveChanges();

                return RedirectToAction("Index");

            }
            else
            {
                instructorMV.Courses = CourseRepo.GetAll();//context.Courses.ToList();
                instructorMV.Departments = DepartmentRepo.GetAll(); //context.Departments.ToList();
                return View("AddNew", instructorMV);

            }
        }



        //////////////Edit


        public IActionResult Edit(int id)
        {
            Instructor ins = InstructorRepo.GetById(id);//context.Instructors.FirstOrDefault(i => i.Id == id);
            if (ins == null)
                return NotFound("Instructor Not Found");
            InstuctorAddithListOfDeptAndCourse insVM = new InstuctorAddithListOfDeptAndCourse();
            insVM.Id = ins.Id;
            insVM.Name = ins.Name;
            insVM.Address = ins.Address;
            insVM.Salary = ins.Salary;
            insVM.Image = ins.Image;
            insVM.DeptId= ins.DeptId;
            insVM.CrsId= ins.CrsId;
            insVM.Departments = DepartmentRepo.GetAll(); //context.Departments.ToList();
            insVM.Courses = CourseRepo.GetAll(); //context.Courses.ToList();

            return View("Edit", insVM);
        }

        public IActionResult SaveEdit(InstuctorAddithListOfDeptAndCourse instructorMV)
        {
            if(instructorMV.Name != null)
            {
                Instructor ins = InstructorRepo.GetById(instructorMV.Id); //context.Instructors.Include(i => i.Course).FirstOrDefault(i => i.Id == instructorMV.Id);// InstructorBussinesLogic.GetInstructorDetaild(instructorMV.Id);
                ins.Name = instructorMV.Name;
                ins.Salary = instructorMV.Salary;
                ins.Address = instructorMV.Address;
                ins.Id = instructorMV.Id;
                ins.Image = instructorMV.Image;
                ins.CrsId = instructorMV.CrsId;
                ins.DeptId = instructorMV.DeptId;
                //context.Instructors.Update(ins);
                InstructorRepo.Save();//context.SaveChanges();

                return RedirectToAction("Index");
            }
            instructorMV.Courses = CourseRepo.GetAll(); //context.Courses.ToList();
            instructorMV.Departments = DepartmentRepo.GetAll(); //context.Departments.ToList();
            return View("Edit", instructorMV);

        }


        ////delete
        ///
        public IActionResult Delete(int id)
        {
            Instructor instructor = InstructorRepo.GetById(id); //context.Instructors.Include(i => i.Course).FirstOrDefault(i => i.Id == id); ;//InstructorBussinesLogic.GetInstructorDetaild(id);
            return View("Delete",instructor);
        }

        

        public IActionResult SaveDelete(Instructor instructor)
        {

            var instructorToDelete = InstructorRepo.GetById(instructor.Id); //context.Instructors.FirstOrDefault(i => i.Id == instructor.Id);

            if (instructorToDelete != null)
            {
               
                instructorToDelete.isDeleted = true;

                InstructorRepo.Delete(instructorToDelete.Id);//InstructorRepo.Update(instructorToDelete); //context.Update(instructorToDelete);

                InstructorRepo.Save(); //context.SaveChanges();
            }

            return RedirectToAction("Index");
        }






    }
}
