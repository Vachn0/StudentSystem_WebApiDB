using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem_WebApiDB.Migrations
{
    /// <inheritdoc />
    public partial class updatedStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LectorStudent");

            migrationBuilder.CreateIndex(
                name: "IX_student_LectorID",
                table: "student",
                column: "LectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_student_lector_LectorID",
                table: "student",
                column: "LectorID",
                principalTable: "lector",
                principalColumn: "LectorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_student_lector_LectorID",
                table: "student");

            migrationBuilder.DropIndex(
                name: "IX_student_LectorID",
                table: "student");

            migrationBuilder.CreateTable(
                name: "LectorStudent",
                columns: table => new
                {
                    LectorID = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectorStudent", x => new { x.LectorID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_LectorStudent_lector_LectorID",
                        column: x => x.LectorID,
                        principalTable: "lector",
                        principalColumn: "LectorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LectorStudent_student_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LectorStudent_StudentsStudentID",
                table: "LectorStudent",
                column: "StudentsStudentID");
        }
    }
}
