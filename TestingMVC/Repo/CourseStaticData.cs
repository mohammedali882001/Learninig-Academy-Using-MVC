using TestingMVC.Models;

namespace TestingMVC.Repo
{
    public class CourseStaticData : ICourseRepo
    {
        List<Course> courses;
        public CourseStaticData()
        { 
            courses = new List<Course>();
            courses.Add(new Course() { Id=1,Name="Messi",Degree=100,MinDegee=50,Hours=15,DeptId=1,isDeleted=false});
            courses.Add(new Course() { Id = 2, Name = "Leo", Degree = 100, MinDegee = 50, Hours = 15, DeptId = 2, isDeleted = false });
            

        }
        void ICourseRepo.Delete(int id)
        {
            courses.Remove(courses[id]);
        }

        List<Course> ICourseRepo.GetAll()
        {
            return courses;
        }

        List<Course> ICourseRepo.GetAllWithSearch(string search)
        {
            return courses;
        }

        Course ICourseRepo.GetById(int id)
        {
            return courses[id]; 
        }

        List<Course> ICourseRepo.GetCoursesInDept(int deptId)
        {
            return courses;
        }

        void ICourseRepo.Insert(Course obj)
        {
            courses.Add((Course)obj);
        }

        void ICourseRepo.Save()
        {
            courses.Sort();
        }

        void ICourseRepo.Update(Course obj)
        {
            courses[obj.Id] = obj;
        }
    }
}
