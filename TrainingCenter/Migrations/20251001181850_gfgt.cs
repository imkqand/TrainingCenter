using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class gfgt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingCenterCourses_Lecturess_LecturesId",
                table: "trainingCenterCourses");

            migrationBuilder.AlterColumn<int>(
                name: "LecturesId",
                table: "trainingCenterCourses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingCenterCourses_Lecturess_LecturesId",
                table: "trainingCenterCourses",
                column: "LecturesId",
                principalTable: "Lecturess",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingCenterCourses_Lecturess_LecturesId",
                table: "trainingCenterCourses");

            migrationBuilder.AlterColumn<int>(
                name: "LecturesId",
                table: "trainingCenterCourses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingCenterCourses_Lecturess_LecturesId",
                table: "trainingCenterCourses",
                column: "LecturesId",
                principalTable: "Lecturess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
