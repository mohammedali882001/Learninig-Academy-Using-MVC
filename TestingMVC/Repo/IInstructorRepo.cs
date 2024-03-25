using TestingMVC.Models;

namespace TestingMVC.Repo
{
    public interface IInstructorRepo
    {
        public List<Instructor> GetAll();
        public Instructor GetById(int id);
        public void Insert(Instructor obj);
        public void Update(Instructor obj);
        public void Delete(int id);
        public void Save();

        public List<Instructor> GetAllWithSearch(string search);
    }
}