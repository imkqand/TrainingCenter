using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsafddfeefvettefrsfddbd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_trainingCenterCourses_CourseId",
                table: "trainingCenterCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingCenterCourses_courses_CourseId",
                table: "trainingCenterCourses",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingCenterCourses_courses_CourseId",
                table: "trainingCenterCourses");

            migrationBuilder.DropIndex(
                name: "IX_trainingCenterCourses_CourseId",
                table: "trainingCenterCourses");
        }
    }
}
