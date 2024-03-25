using TestingMVC.Models;

namespace TestingMVC.Repo
{
    public class DepartmentRepo : IDepartmentRepo
    {
        Context context;


        public DepartmentRepo(Context _context)
        {
            //context = new Context();
            context = _context;
        }
        public List<Department> GetAll()
        {
           return context.Departments.ToList();
        }

    }
}
