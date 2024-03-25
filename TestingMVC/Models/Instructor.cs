﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TestingMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public double Salary { get; set; }
        public string Address { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }

        ////////is Deleted
        ///
        public bool isDeleted { get; set; } = false;

    }
}
