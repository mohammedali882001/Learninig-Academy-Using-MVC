﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestingMVC.Models;

#nullable disable

namespace TestingMVC.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240314235112_filldatabase5")]
    partial class filldatabase5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestingMVC.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("MinDegee")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Degree = 90,
                            DeptId = 1,
                            Hours = 40,
                            MinDegee = 70,
                            Name = "Introduction to Programming"
                        },
                        new
                        {
                            Id = 2,
                            Degree = 95,
                            DeptId = 2,
                            Hours = 50,
                            MinDegee = 75,
                            Name = "Marketing Fundamentals"
                        },
                        new
                        {
                            Id = 3,
                            Degree = 85,
                            DeptId = 3,
                            Hours = 45,
                            MinDegee = 60,
                            Name = "Financial Management"
                        },
                        new
                        {
                            Id = 4,
                            Degree = 88,
                            DeptId = 4,
                            Hours = 55,
                            MinDegee = 65,
                            Name = "Human Resource Management"
                        },
                        new
                        {
                            Id = 5,
                            Degree = 92,
                            DeptId = 5,
                            Hours = 42,
                            MinDegee = 68,
                            Name = "Database Management"
                        },
                        new
                        {
                            Id = 6,
                            Degree = 87,
                            DeptId = 6,
                            Hours = 48,
                            MinDegee = 62,
                            Name = "Operations Management"
                        },
                        new
                        {
                            Id = 7,
                            Degree = 94,
                            DeptId = 7,
                            Hours = 53,
                            MinDegee = 77,
                            Name = "Sales Techniques"
                        },
                        new
                        {
                            Id = 8,
                            Degree = 89,
                            DeptId = 8,
                            Hours = 47,
                            MinDegee = 73,
                            Name = "Customer Service Excellence"
                        },
                        new
                        {
                            Id = 9,
                            Degree = 91,
                            DeptId = 9,
                            Hours = 43,
                            MinDegee = 69,
                            Name = "Research Methods"
                        },
                        new
                        {
                            Id = 10,
                            Degree = 86,
                            DeptId = 10,
                            Hours = 51,
                            MinDegee = 64,
                            Name = "Quality Management"
                        });
                });

            modelBuilder.Entity("TestingMVC.Models.CrsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.HasIndex("TraineeId");

                    b.ToTable("CrsResults");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CrsId = 1,
                            Degree = 88,
                            TraineeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CrsId = 2,
                            Degree = 79,
                            TraineeId = 2
                        },
                        new
                        {
                            Id = 3,
                            CrsId = 3,
                            Degree = 91,
                            TraineeId = 3
                        },
                        new
                        {
                            Id = 4,
                            CrsId = 4,
                            Degree = 81,
                            TraineeId = 4
                        },
                        new
                        {
                            Id = 5,
                            CrsId = 5,
                            Degree = 87,
                            TraineeId = 5
                        },
                        new
                        {
                            Id = 6,
                            CrsId = 6,
                            Degree = 82,
                            TraineeId = 6
                        },
                        new
                        {
                            Id = 7,
                            CrsId = 7,
                            Degree = 90,
                            TraineeId = 7
                        },
                        new
                        {
                            Id = 8,
                            CrsId = 8,
                            Degree = 75,
                            TraineeId = 8
                        },
                        new
                        {
                            Id = 9,
                            CrsId = 9,
                            Degree = 83,
                            TraineeId = 9
                        },
                        new
                        {
                            Id = 10,
                            CrsId = 10,
                            Degree = 80,
                            TraineeId = 10
                        });
                });

            modelBuilder.Entity("TestingMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManagerName = "John Doe",
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = 2,
                            ManagerName = "Jane Smith",
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 3,
                            ManagerName = "Alice Johnson",
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 4,
                            ManagerName = "Bob Thompson",
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 5,
                            ManagerName = "Sarah Brown",
                            Name = "Information Technology"
                        },
                        new
                        {
                            Id = 6,
                            ManagerName = "Michael Davis",
                            Name = "Operations"
                        },
                        new
                        {
                            Id = 7,
                            ManagerName = "Emily Wilson",
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 8,
                            ManagerName = "Daniel Martinez",
                            Name = "Customer Service"
                        },
                        new
                        {
                            Id = 9,
                            ManagerName = "Olivia Garcia",
                            Name = "Research and Development"
                        },
                        new
                        {
                            Id = 10,
                            ManagerName = "William Hernandez",
                            Name = "Quality Assurance"
                        },
                        new
                        {
                            Id = 11,
                            ManagerName = "Mohammed Ali",
                            Name = "Dept11"
                        });
                });

            modelBuilder.Entity("TestingMVC.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.HasIndex("DeptId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Anytown",
                            CrsId = 1,
                            DeptId = 1,
                            Image = "messi.jpg",
                            Name = "Michael Johnson",
                            Salary = 75000.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St, Othertown",
                            CrsId = 2,
                            DeptId = 2,
                            Image = "messi.jpg",
                            Name = "Emily Davis",
                            Salary = 80000.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak St, Another town",
                            CrsId = 3,
                            DeptId = 3,
                            Image = "messi.jpg",
                            Name = "David Smith",
                            Salary = 70000.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "321 Maple St, Somewhere",
                            CrsId = 4,
                            DeptId = 4,
                            Image = "messi.jpg",
                            Name = "Sarah Johnson",
                            Salary = 85000.0
                        },
                        new
                        {
                            Id = 5,
                            Address = "567 Pine St, Nowhere",
                            CrsId = 5,
                            DeptId = 5,
                            Image = "messi.jpg",
                            Name = "John Brown",
                            Salary = 72000.0
                        },
                        new
                        {
                            Id = 6,
                            Address = "890 Cedar St, Elsewhere",
                            CrsId = 6,
                            DeptId = 6,
                            Image = "messi.jpg",
                            Name = "Jessica White",
                            Salary = 78000.0
                        },
                        new
                        {
                            Id = 7,
                            Address = "432 Walnut St, Anywhere",
                            CrsId = 7,
                            DeptId = 7,
                            Image = "messi.jpg",
                            Name = "Robert Lee",
                            Salary = 82000.0
                        },
                        new
                        {
                            Id = 8,
                            Address = "654 Oak St, Everywhere",
                            CrsId = 8,
                            DeptId = 8,
                            Image = "messi.jpg",
                            Name = "Amanda Miller",
                            Salary = 73000.0
                        },
                        new
                        {
                            Id = 9,
                            Address = "987 Elm St, Uptown",
                            CrsId = 9,
                            DeptId = 9,
                            Image = "messi.jpg",
                            Name = "James Garcia",
                            Salary = 79000.0
                        },
                        new
                        {
                            Id = 10,
                            Address = "321 Oak St, Downtown",
                            CrsId = 10,
                            DeptId = 10,
                            Image = "messi.jpg",
                            Name = "Melissa Hernandez",
                            Salary = 76000.0
                        });
                });

            modelBuilder.Entity("TestingMVC.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Trainees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "111 Oak St, Anytown",
                            DeptId = 1,
                            Grade = 85,
                            Image = "messi.jpg",
                            Name = "Sophia Miller"
                        },
                        new
                        {
                            Id = 2,
                            Address = "222 Pine St, Othertown",
                            DeptId = 2,
                            Grade = 78,
                            Image = "messi.jpg",
                            Name = "Liam Davis"
                        },
                        new
                        {
                            Id = 3,
                            Address = "333 Maple St, Another town",
                            DeptId = 3,
                            Grade = 90,
                            Image = "messi.jpg",
                            Name = "Ethan Wilson"
                        },
                        new
                        {
                            Id = 4,
                            Address = "444 Cedar St, Somewhere",
                            DeptId = 4,
                            Grade = 72,
                            Image = "messi.jpg",
                            Name = "Isabella Martinez"
                        },
                        new
                        {
                            Id = 5,
                            Address = "555 Walnut St, Nowhere",
                            DeptId = 5,
                            Grade = 88,
                            Image = "messi.jpg",
                            Name = "Mason Taylor"
                        },
                        new
                        {
                            Id = 6,
                            Address = "666 Pine St, Elsewhere",
                            DeptId = 6,
                            Grade = 79,
                            Image = "messi.jpg",
                            Name = "Ava Thomas"
                        },
                        new
                        {
                            Id = 7,
                            Address = "777 Elm St, Anywhere",
                            DeptId = 7,
                            Grade = 93,
                            Image = "messi.jpg",
                            Name = "Noah Garcia"
                        },
                        new
                        {
                            Id = 8,
                            Address = "888 Cedar St, Everywhere",
                            DeptId = 8,
                            Grade = 76,
                            Image = "messi.jpg",
                            Name = "Emma Hernandez"
                        },
                        new
                        {
                            Id = 9,
                            Address = "999 Walnut St, Uptown",
                            DeptId = 9,
                            Grade = 84,
                            Image = "messi.jpg",
                            Name = "Oliver Adams"
                        },
                        new
                        {
                            Id = 10,
                            Address = "1010 Oak St, Downtown",
                            DeptId = 10,
                            Grade = 81,
                            Image = "messi.jpg",
                            Name = "Charlotte Phillips"
                        });
                });

            modelBuilder.Entity("TestingMVC.Models.Course", b =>
                {
                    b.HasOne("TestingMVC.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TestingMVC.Models.CrsResult", b =>
                {
                    b.HasOne("TestingMVC.Models.Course", "Course")
                        .WithMany("CrsResults")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingMVC.Models.Trainee", "Trainee")
                        .WithMany("CrsResults")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("TestingMVC.Models.Instructor", b =>
                {
                    b.HasOne("TestingMVC.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingMVC.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TestingMVC.Models.Trainee", b =>
                {
                    b.HasOne("TestingMVC.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TestingMVC.Models.Course", b =>
                {
                    b.Navigation("CrsResults");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("TestingMVC.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("TestingMVC.Models.Trainee", b =>
                {
                    b.Navigation("CrsResults");
                });
#pragma warning restore 612, 618
        }
    }
}
