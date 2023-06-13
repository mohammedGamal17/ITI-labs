using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolTest.Migrations
{
    public partial class m5AddStudentsCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    StdId = table.Column<int>(type: "int", nullable: false),
                    CursID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StdId, x.CursID });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CursID",
                        column: x => x.CursID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StdId",
                        column: x => x.StdId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CursID",
                table: "StudentsCourses",
                column: "CursID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");
        }
    }
}
