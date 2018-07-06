using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class AddCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Courses",
                table: "Resumes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Courses",
                table: "Resumes");
        }
    }
}
