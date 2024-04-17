using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Admission_No = table.Column<long>(type: "bigint", nullable: false),
                    Academic_Year = table.Column<string>(type: "longtext", nullable: true),
                    Admission_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Student_Name = table.Column<string>(type: "longtext", nullable: true),
                    Student_Class = table.Column<string>(type: "longtext", nullable: false),
                    Student_Section = table.Column<string>(type: "longtext", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Gender = table.Column<string>(type: "longtext", nullable: false),
                    Guardian_Name = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    City = table.Column<string>(type: "longtext", nullable: false),
                    State = table.Column<string>(type: "longtext", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Photo = table.Column<string>(type: "longtext", nullable: false),
                    Category = table.Column<string>(type: "longtext", nullable: false),
                    Cast = table.Column<string>(type: "longtext", nullable: false),
                    Mother_Name = table.Column<string>(type: "longtext", nullable: false),
                    Father_Name = table.Column<string>(type: "longtext", nullable: false),
                    Last_Name = table.Column<string>(type: "longtext", nullable: false),
                    Gr_No = table.Column<string>(type: "longtext", nullable: false),
                    Adhaar_No = table.Column<string>(type: "longtext", nullable: false),
                    Religion = table.Column<string>(type: "longtext", nullable: false),
                    Student_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
