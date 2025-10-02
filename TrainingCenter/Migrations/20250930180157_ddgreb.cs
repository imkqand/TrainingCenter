using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class ddgreb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LectuerID",
                table: "trainingCenterCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LecturesId",
                table: "trainingCenterCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "trainingCenterCourses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_trainingCenterCourses_LecturesId",
                table: "trainingCenterCourses",
                column: "LecturesId");

            migrationBuilder.CreateIndex(
                name: "IX_trainingCenterCourses_SubjectID",
                table: "trainingCenterCourses",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingCenterCourses_Lecturess_LecturesId",
                table: "trainingCenterCourses",
                column: "LecturesId",
                principalTable: "Lecturess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingCenterCourses_subjects_SubjectID",
                table: "trainingCenterCourses",
                column: "SubjectID",
                principalTable: "subjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingCenterCourses_Lecturess_LecturesId",
                table: "trainingCenterCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingCenterCourses_subjects_SubjectID",
                table: "trainingCenterCourses");

            migrationBuilder.DropIndex(
                name: "IX_trainingCenterCourses_LecturesId",
                table: "trainingCenterCourses");

            migrationBuilder.DropIndex(
                name: "IX_trainingCenterCourses_SubjectID",
                table: "trainingCenterCourses");

            migrationBuilder.DropColumn(
                name: "LectuerID",
                table: "trainingCenterCourses");

            migrationBuilder.DropColumn(
                name: "LecturesId",
                table: "trainingCenterCourses");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "trainingCenterCourses");
        }
    }
}
