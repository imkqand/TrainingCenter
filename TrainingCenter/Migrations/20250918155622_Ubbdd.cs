using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class Ubbdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LectuerId",
                table: "Cuorses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LecturersId",
                table: "Cuorses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Cuorses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cuorses_LecturersId",
                table: "Cuorses",
                column: "LecturersId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuorses_StudentId",
                table: "Cuorses",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuorses_Lecturers_LecturersId",
                table: "Cuorses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuorses_Students_StudentId",
                table: "Cuorses");

            migrationBuilder.DropIndex(
                name: "IX_Cuorses_LecturersId",
                table: "Cuorses");

            migrationBuilder.DropIndex(
                name: "IX_Cuorses_StudentId",
                table: "Cuorses");

            migrationBuilder.DropColumn(
                name: "LectuerId",
                table: "Cuorses");

            migrationBuilder.DropColumn(
                name: "LecturersId",
                table: "Cuorses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Cuorses");
        }
    }
}
