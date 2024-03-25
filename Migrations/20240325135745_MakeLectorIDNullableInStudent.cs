using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem_WebApiDB.Migrations
{
    /// <inheritdoc />
    public partial class MakeLectorIDNullableInStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "student");

            migrationBuilder.AlterColumn<int>(
                name: "LectorID",
                table: "student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LectorID",
                table: "student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
