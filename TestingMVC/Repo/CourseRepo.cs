using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestingMVC.Models;

namespace TestingMVC.Repo
{
    public class CourseRepo : ICourseRepo
    {
        Context context;


        public CourseRepo(Context _context)
        {
            //context = new Context();
            context = _context;
           
        }
        public List<Course> GetAll()//string includes=null)
        {
            return context.Courses.Where(c => c.isDeleted == false).Include(c => c.Department).ToList();
        }
        public Course GetById(int id)
        {
            return context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == id);
        }
        public void Insert(Course obj)
        {
            context.Add(obj);
        }
        public void Update(Course obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Course Crs = GetById(id);
            Update(Crs);
            //context.Remove(dept);
        }
        public void Save()
        {
            context.SaveChanges();
        }

        ////////////////
        ///
        public List<Course> GetAllWithSearch(string search)
        {
            return context.Courses.Include(c => c.Department).Where(c => c.Name.Contains(search) && c.isDeleted == false).ToList();
        }

        public List<Course> GetCoursesInDept(int deptId)
        {
            return context.Courses.Where(c => c.DeptId == deptId).ToList();
        }

    }
}
