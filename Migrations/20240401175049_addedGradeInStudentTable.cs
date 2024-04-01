using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem_WebApiDB.Migrations
{
    /// <inheritdoc />
    public partial class addedGradeInStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "student",
                type: "int",
                nullable: true,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "student");
        }
    }
}
