using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class nesmm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuorses_Lecturers_LecturersId",
                table: "Cuorses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuorses_Students_StudentId",
                table: "Cuorses");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Lecturers_LecturerId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Students_StudentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Exams_ExamId1",
                table: "Lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Exams_ExamId1",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Lecturers_LecturerId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "GradeExamStudents");

            migrationBuilder.DropIndex(
                name: "IX_Students_ExamId1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_LecturerId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Lecturers_ExamId1",
                table: "Lecturers");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LecturerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_StudentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Cuorses_LecturersId",
                table: "Cuorses");

            migrationBuilder.DropIndex(
                name: "IX_Cuorses_StudentId",
                table: "Cuorses");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "LecturersId",
                table: "Cuorses",
                newName: "CuoresHouers");

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Greades",
                table: "Students",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExamName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "LecturersName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    ExamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Greades",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LecturersName",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "CuoresHouers",
                table: "Cuorses",
                newName: "LecturersId");

            migrationBuilder.AddColumn<int>(
                name: "CourseCode",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "CourseCode",
                table: "Lecturers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExamId1",
                table: "Lecturers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExamName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LecturerId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GradeExamStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeExamStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradeExamStudents_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId");
                    table.ForeignKey(
                        name: "FK_GradeExamStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LecturerId",
                table: "Employees",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StudentId",
                table: "Employees",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuorses_LecturersId",
                table: "Cuorses",
                column: "LecturersId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuorses_StudentId",
                table: "Cuorses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeExamStudents_ExamId",
                table: "GradeExamStudents",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeExamStudents_StudentId",
                table: "GradeExamStudents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuorses_Lecturers_LecturersId",
                table: "Cuorses",
                column: "LecturersId",
                principalTable: "Lecturers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuorses_Students_StudentId",
                table: "Cuorses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Lecturers_LecturerId",
                table: "Employees",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Students_StudentId",
                table: "Employees",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

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
    }
}
