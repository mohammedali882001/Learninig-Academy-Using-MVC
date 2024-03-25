using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingMVC.Migrations
{
    /// <inheritdoc />
    public partial class filldatabase5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ManagerName", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe", "Engineering" },
                    { 2, "Jane Smith", "Marketing" },
                    { 3, "Alice Johnson", "Finance" },
                    { 4, "Bob Thompson", "Human Resources" },
                    { 5, "Sarah Brown", "Information Technology" },
                    { 6, "Michael Davis", "Operations" },
                    { 7, "Emily Wilson", "Sales" },
                    { 8, "Daniel Martinez", "Customer Service" },
                    { 9, "Olivia Garcia", "Research and Development" },
                    { 10, "William Hernandez", "Quality Assurance" },
                    { 11, "Mohammed Ali", "Dept11" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "DeptId", "Hours", "MinDegee", "Name" },
                values: new object[,]
                {
                    { 1, 90, 1, 40, 70, "Introduction to Programming" },
                    { 2, 95, 2, 50, 75, "Marketing Fundamentals" },
                    { 3, 85, 3, 45, 60, "Financial Management" },
                    { 4, 88, 4, 55, 65, "Human Resource Management" },
                    { 5, 92, 5, 42, 68, "Database Management" },
                    { 6, 87, 6, 48, 62, "Operations Management" },
                    { 7, 94, 7, 53, 77, "Sales Techniques" },
                    { 8, 89, 8, 47, 73, "Customer Service Excellence" },
                    { 9, 91, 9, 43, 69, "Research Methods" },
                    { 10, 86, 10, 51, 64, "Quality Management" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Address", "DeptId", "Grade", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "111 Oak St, Anytown", 1, 85, "messi.jpg", "Sophia Miller" },
                    { 2, "222 Pine St, Othertown", 2, 78, "messi.jpg", "Liam Davis" },
                    { 3, "333 Maple St, Another town", 3, 90, "messi.jpg", "Ethan Wilson" },
                    { 4, "444 Cedar St, Somewhere", 4, 72, "messi.jpg", "Isabella Martinez" },
                    { 5, "555 Walnut St, Nowhere", 5, 88, "messi.jpg", "Mason Taylor" },
                    { 6, "666 Pine St, Elsewhere", 6, 79, "messi.jpg", "Ava Thomas" },
                    { 7, "777 Elm St, Anywhere", 7, 93, "messi.jpg", "Noah Garcia" },
                    { 8, "888 Cedar St, Everywhere", 8, 76, "messi.jpg", "Emma Hernandez" },
                    { 9, "999 Walnut St, Uptown", 9, 84, "messi.jpg", "Oliver Adams" },
                    { 10, "1010 Oak St, Downtown", 10, 81, "messi.jpg", "Charlotte Phillips" }
                });

            migrationBuilder.InsertData(
                table: "CrsResults",
                columns: new[] { "Id", "CrsId", "Degree", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 88, 1 },
                    { 2, 2, 79, 2 },
                    { 3, 3, 91, 3 },
                    { 4, 4, 81, 4 },
                    { 5, 5, 87, 5 },
                    { 6, 6, 82, 6 },
                    { 7, 7, 90, 7 },
                    { 8, 8, 75, 8 },
                    { 9, 9, 83, 9 },
                    { 10, 10, 80, 10 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Address", "CrsId", "DeptId", "Image", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "123 Main St, Anytown", 1, 1, "messi.jpg", "Michael Johnson", 75000.0 },
                    { 2, "456 Elm St, Othertown", 2, 2, "messi.jpg", "Emily Davis", 80000.0 },
                    { 3, "789 Oak St, Another town", 3, 3, "messi.jpg", "David Smith", 70000.0 },
                    { 4, "321 Maple St, Somewhere", 4, 4, "messi.jpg", "Sarah Johnson", 85000.0 },
                    { 5, "567 Pine St, Nowhere", 5, 5, "messi.jpg", "John Brown", 72000.0 },
                    { 6, "890 Cedar St, Elsewhere", 6, 6, "messi.jpg", "Jessica White", 78000.0 },
                    { 7, "432 Walnut St, Anywhere", 7, 7, "messi.jpg", "Robert Lee", 82000.0 },
                    { 8, "654 Oak St, Everywhere", 8, 8, "messi.jpg", "Amanda Miller", 73000.0 },
                    { 9, "987 Elm St, Uptown", 9, 9, "messi.jpg", "James Garcia", 79000.0 },
                    { 10, "321 Oak St, Downtown", 10, 10, "messi.jpg", "Melissa Hernandez", 76000.0 }
                });

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
