﻿namespace TestingMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }

        public bool isTest1 { get; set; } = false;
        public bool isTest2 { get; set; } = true;


    }
}
