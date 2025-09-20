using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class dbmodafodf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exam",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Exam",
                table: "Lecturers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Lecturers",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ExamId",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId1",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LecturerId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ExamId",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId1",
                table: "Lecturers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ExamId1",
                table: "Students",
                column: "ExamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LecturerId",
                table: "Students",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_ExamId1",
                table: "Lecturers",
                column: "ExamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturers_Exams_ExamId1",
                table: "Lecturers",
                column: "ExamId1",
                principalTable: "Exams",
                principalColumn: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Exams_ExamId1",
                table: "Students",
                column: "ExamId1",
                principalTable: "Exams",
                principalColumn: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Lecturers_LecturerId",
                table: "Students",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Exams_ExamId1",
                table: "Lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Exams_ExamId1",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Lecturers_LecturerId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ExamId1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_LecturerId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Lecturers_ExamId1",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "Lecturers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lecturers",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exam",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exam",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
