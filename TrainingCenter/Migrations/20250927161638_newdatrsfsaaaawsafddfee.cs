using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsafddfee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseAdvances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectyapes = table.Column<int>(type: "int", nullable: true),
                    SubjectTypeId = table.Column<int>(type: "int", nullable: true),
                    courseCodes_Id = table.Column<int>(type: "int", nullable: true),
                    CourseCodeId = table.Column<int>(type: "int", nullable: true),
                    stud_course_id = table.Column<int>(type: "int", nullable: false),
                    StudentCourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseAdvances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseAdvances_courseCodes_CourseCodeId",
                        column: x => x.CourseCodeId,
                        principalTable: "courseCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseAdvances_studentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalTable: "studentCourses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseAdvances_subjectTypes_SubjectTypeId",
                        column: x => x.SubjectTypeId,
                        principalTable: "subjectTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseAdvances_CourseCodeId",
                table: "courseAdvances",
                column: "CourseCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_courseAdvances_StudentCourseId",
                table: "courseAdvances",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_courseAdvances_SubjectTypeId",
                table: "courseAdvances",
                column: "SubjectTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseAdvances");
        }
    }
}
