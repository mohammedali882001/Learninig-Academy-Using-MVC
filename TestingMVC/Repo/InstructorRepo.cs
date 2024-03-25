using Microsoft.EntityFrameworkCore;
using TestingMVC.Models;

namespace TestingMVC.Repo
{
    public class InstructorRepo: IInstructorRepo

    {
        Context context;


        public InstructorRepo(Context _context)
        {
            //context = new Context();
            context = _context;
        }
        public List<Instructor> GetAll()//string includes=null)
        {
            return context.Instructors.Where(i => i.isDeleted == false).Include(i => i.Course).Include(i => i.Department).ToList();
        }
        public Instructor GetById(int id)
        {
            return context.Instructors.Include(i => i.Course).Include(i => i.Department).FirstOrDefault(i => i.Id == id);
        }
        public void Insert(Instructor obj)
        {
            context.Add(obj);
        }
        public void Update(Instructor obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Instructor ins = GetById(id);
            Update(ins);
            //context.Remove(dept);
        }
        public void Save()
        {
            context.SaveChanges();
        }

        ////
        ///
        public List<Instructor> GetAllWithSearch(string search)
        {
            return context.Instructors.Where(i => i.Name.Contains(search) && i.isDeleted == false).Include(i => i.Course).Include(i => i.Department).ToList();
        }
    }
}
