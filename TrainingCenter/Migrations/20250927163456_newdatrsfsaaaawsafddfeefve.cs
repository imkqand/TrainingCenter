using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsafddfeefve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseFoundationals",
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
                    table.PrimaryKey("PK_courseFoundationals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseFoundationals_courseCodes_CourseCodeId",
                        column: x => x.CourseCodeId,
                        principalTable: "courseCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseFoundationals_studentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalTable: "studentCourses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseFoundationals_subjectTypes_SubjectTypeId",
                        column: x => x.SubjectTypeId,
                        principalTable: "subjectTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseFoundationals_CourseCodeId",
                table: "courseFoundationals",
                column: "CourseCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_courseFoundationals_StudentCourseId",
                table: "courseFoundationals",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_courseFoundationals_SubjectTypeId",
                table: "courseFoundationals",
                column: "SubjectTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseFoundationals");
        }
    }
}
