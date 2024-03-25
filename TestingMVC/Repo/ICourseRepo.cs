using TestingMVC.Models;

namespace TestingMVC.Repo
{
    public interface ICourseRepo
    {
        public List<Course> GetAll();
        public Course GetById(int id);
        public void Insert(Course obj);
        public void Update(Course obj);
        public void Delete(int id);
        public void Save();

        public List<Course> GetAllWithSearch(string search);
        public List<Course> GetCoursesInDept(int deptId);


    }
}