using System.ComponentModel.DataAnnotations.Schema;

namespace TestingMVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegee { get; set; }
        public int Hours { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<CrsResult> CrsResults { get; set; }

        ////////is Deleted
        ///
        public bool isDeleted { get; set; } = false;

    }
}
