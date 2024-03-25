using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestingMVC.Models
{
    public class Context :  IdentityDbContext<ApplicationUser>
    {

       // public Context() : base() { }
        public Context(DbContextOptions<Context> options):base(options) 
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }

        public DbSet<Course> Courses { get; set; }


        public DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=.\MSSQLSERVER1;Initial Catalog=MvcCrsTesting;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        //    // Configure primary key for IdentityUserLogin
        //    modelBuilder.Entity<IdentityUserLogin<string>>()
        //        .HasKey(l => new { l.LoginProvider, l.ProviderKey });
        //    // Seed Departments
        //    modelBuilder.Entity<Department>().HasData(
        //        new Department { Id = 1, Name = "Engineering", ManagerName = "John Doe" },
        //        new Department { Id = 2, Name = "Marketing", ManagerName = "Jane Smith" },
        //        new Department { Id = 3, Name = "Finance", ManagerName = "Alice Johnson" },
        //        new Department { Id = 4, Name = "Human Resources", ManagerName = "Bob Thompson" },
        //        new Department { Id = 5, Name = "Information Technology", ManagerName = "Sarah Brown" },
        //        new Department { Id = 6, Name = "Operations", ManagerName = "Michael Davis" },
        //        new Department { Id = 7, Name = "Sales", ManagerName = "Emily Wilson" },
        //        new Department { Id = 8, Name = "Customer Service", ManagerName = "Daniel Martinez" },
        //        new Department { Id = 9, Name = "Research and Development", ManagerName = "Olivia Garcia" },
        //        new Department { Id = 10, Name = "Quality Assurance", ManagerName = "William Hernandez" },
        //        new Department { Id = 11, Name = "Dept11", ManagerName = "Mohammed Ali" }

        //    );

        //    // Seed Instructors
        //    modelBuilder.Entity<Instructor>().HasData(
        //        new Instructor { Id = 1,CrsId = 1, Image="messi.jpg", Name = "Michael Johnson", Salary = 75000, Address = "123 Main St, Anytown", DeptId = 1 },
        //        new Instructor { Id = 2,CrsId = 2, Image="messi.jpg", Name = "Emily Davis", Salary = 80000, Address = "456 Elm St, Othertown", DeptId = 2 },
        //        new Instructor { Id = 3,CrsId = 3, Image="messi.jpg", Name = "David Smith", Salary = 70000, Address = "789 Oak St, Another town", DeptId = 3 },
        //        new Instructor { Id = 4,CrsId = 4, Image="messi.jpg", Name = "Sarah Johnson", Salary = 85000, Address = "321 Maple St, Somewhere", DeptId = 4 },
        //        new Instructor { Id = 5,CrsId = 5, Image="messi.jpg", Name = "John Brown", Salary = 72000, Address = "567 Pine St, Nowhere", DeptId = 5 },
        //        new Instructor { Id = 6,CrsId = 6, Image="messi.jpg", Name = "Jessica White", Salary = 78000, Address = "890 Cedar St, Elsewhere", DeptId = 6 },
        //        new Instructor { Id = 7,CrsId = 7, Image="messi.jpg", Name = "Robert Lee", Salary = 82000, Address = "432 Walnut St, Anywhere", DeptId = 7 },
        //        new Instructor { Id = 8,CrsId = 8, Image="messi.jpg", Name = "Amanda Miller", Salary = 73000, Address = "654 Oak St, Everywhere", DeptId = 8 },
        //        new Instructor { Id = 9,CrsId = 9, Image="messi.jpg", Name = "James Garcia", Salary = 79000, Address = "987 Elm St, Uptown", DeptId = 9 },
        //        new Instructor { Id =10, CrsId = 10,Image ="messi.jpg", Name = "Melissa Hernandez", Salary = 76000, Address = "321 Oak St, Downtown", DeptId = 10 }
        //    );

        //    // Seed Trainees
        //    modelBuilder.Entity<Trainee>().HasData(
        //        new Trainee { Id = 1,Image="messi.jpg", Name = "Sophia Miller", Grade = 85, Address = "111 Oak St, Anytown", DeptId = 1 },
        //        new Trainee { Id = 2,Image="messi.jpg", Name = "Liam Davis", Grade = 78, Address = "222 Pine St, Othertown", DeptId = 2 },
        //        new Trainee { Id = 3,Image="messi.jpg", Name = "Ethan Wilson", Grade = 90, Address = "333 Maple St, Another town", DeptId = 3 },
        //        new Trainee { Id = 4,Image="messi.jpg", Name = "Isabella Martinez", Grade = 72, Address = "444 Cedar St, Somewhere", DeptId = 4 },
        //        new Trainee { Id = 5,Image="messi.jpg", Name = "Mason Taylor", Grade = 88, Address = "555 Walnut St, Nowhere", DeptId = 5 },
        //        new Trainee { Id = 6,Image="messi.jpg", Name = "Ava Thomas", Grade = 79, Address = "666 Pine St, Elsewhere", DeptId = 6 },
        //        new Trainee { Id = 7,Image="messi.jpg", Name = "Noah Garcia", Grade = 93, Address = "777 Elm St, Anywhere", DeptId = 7 },
        //        new Trainee { Id = 8,Image="messi.jpg", Name = "Emma Hernandez", Grade = 76, Address = "888 Cedar St, Everywhere", DeptId = 8 },
        //        new Trainee { Id = 9,Image="messi.jpg", Name = "Oliver Adams", Grade = 84, Address = "999 Walnut St, Uptown", DeptId = 9 },
        //        new Trainee { Id =10,Image="messi.jpg", Name = "Charlotte Phillips", Grade = 81, Address = "1010 Oak St, Downtown", DeptId = 10 }
        //    );

        //    // Seed Courses
        //    modelBuilder.Entity<Course>().HasData(
        //        new Course { Id = 1, Name = "Introduction to Programming", Degree = 90, MinDegee = 70, Hours = 40, DeptId = 1 },
        //        new Course { Id = 2, Name = "Marketing Fundamentals", Degree = 95, MinDegee = 75, Hours = 50, DeptId = 2 },
        //        new Course { Id = 3, Name = "Financial Management", Degree = 85, MinDegee = 60, Hours = 45, DeptId = 3 },
        //        new Course { Id = 4, Name = "Human Resource Management", Degree = 88, MinDegee = 65, Hours = 55, DeptId = 4 },
        //        new Course { Id = 5, Name = "Database Management", Degree = 92, MinDegee = 68, Hours = 42, DeptId = 5 },
        //        new Course { Id = 6, Name = "Operations Management", Degree = 87, MinDegee = 62, Hours = 48, DeptId = 6 },
        //        new Course { Id = 7, Name = "Sales Techniques", Degree = 94, MinDegee = 77, Hours = 53, DeptId = 7 },
        //        new Course { Id = 8, Name = "Customer Service Excellence", Degree = 89, MinDegee = 73, Hours = 47, DeptId = 8 },
        //        new Course { Id = 9, Name = "Research Methods", Degree = 91, MinDegee = 69, Hours = 43, DeptId = 9 },
        //        new Course { Id = 10, Name = "Quality Management", Degree = 86, MinDegee = 64, Hours = 51, DeptId = 10 }
        //    );

        //    // Seed CrsResults
        //    modelBuilder.Entity<CrsResult>().HasData(
        //        new CrsResult { Id = 1, Degree = 88, CrsId = 1, TraineeId = 1 },
        //        new CrsResult { Id = 2, Degree = 79, CrsId = 2, TraineeId = 2 },
        //        new CrsResult { Id = 3, Degree = 91, CrsId = 3, TraineeId = 3 },
        //        new CrsResult { Id = 4, Degree = 81, CrsId = 4, TraineeId = 4 },
        //        new CrsResult { Id = 5, Degree = 87, CrsId = 5, TraineeId = 5 },
        //        new CrsResult { Id = 6, Degree = 82, CrsId = 6, TraineeId = 6 },
        //        new CrsResult { Id = 7, Degree = 90, CrsId = 7, TraineeId = 7 },
        //        new CrsResult { Id = 8, Degree = 75, CrsId = 8, TraineeId = 8 },
        //        new CrsResult { Id = 9, Degree = 83, CrsId = 9, TraineeId = 9 },
        //        new CrsResult { Id = 10, Degree = 80, CrsId = 10, TraineeId = 10 }
        //    );
        }


    }
}
