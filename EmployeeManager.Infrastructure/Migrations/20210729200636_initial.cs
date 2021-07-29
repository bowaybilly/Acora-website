using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManager.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeNumber);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("591d3ba4-420a-43c8-b571-74b27b613dfd"), "Engineering" },
                    { new Guid("87f36f84-c487-471b-bbe0-54fb129b1e31"), "Finance" },
                    { new Guid("317cfb35-436a-419a-bc13-1c58903d76b9"), "Human Resource" },
                    { new Guid("31708bbc-d83a-423e-8252-acc2fda9c3bd"), "Maintainence" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeNumber", "Address", "City", "DateOfBirth", "Department", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "23 Fox lane London SE15 9PL", "London", new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ee7275d-d469-4330-86df-79f6c847107b"), "John", "Doe" },
                    { 2, "23 Fox lane London SE15 9PL", "London", new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e1243e6-a5b8-4db6-b915-74f8200ae681"), "John", "Doe" },
                    { 3, "23 Fox lane London SE15 9PL", "London", new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0f89314-82a2-441b-b38e-553047987667"), "John", "Doe" },
                    { 4, "23 Fox lane London SE15 9PL", "London", new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38782d43-4589-47fd-8b71-28d8ec6c8e67"), "John", "Doe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
