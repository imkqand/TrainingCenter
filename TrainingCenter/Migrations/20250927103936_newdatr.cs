using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeFoundationalCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeAdvancedCourse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trainingCenterCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    CuorsesCuorseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainingCenterCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainingCenterCourses_Cuorses_CuorsesCuorseId",
                        column: x => x.CuorsesCuorseId,
                        principalTable: "Cuorses",
                        principalColumn: "CuorseId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_trainingCenterCourses_CuorsesCuorseId",
                table: "trainingCenterCourses",
                column: "CuorsesCuorseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseCodes");

            migrationBuilder.DropTable(
                name: "trainingCenterCourses");
        }
    }
}
