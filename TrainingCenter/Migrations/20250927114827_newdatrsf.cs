using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingCenterCourses_Cuorse_CuorsesCuorseId",
                table: "trainingCenterCourses");

            migrationBuilder.DropTable(
                name: "Cuorse");

            migrationBuilder.DropIndex(
                name: "IX_trainingCenterCourses_CuorsesCuorseId",
                table: "trainingCenterCourses");

            migrationBuilder.DropColumn(
                name: "CuorsesCuorseId",
                table: "trainingCenterCourses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuorsesCuorseId",
                table: "trainingCenterCourses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cuorse",
                columns: table => new
                {
                    CuorseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuoresHouers = table.Column<int>(type: "int", nullable: true),
                    CuorseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuorseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LectuerId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuorse", x => x.CuorseId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_trainingCenterCourses_CuorsesCuorseId",
                table: "trainingCenterCourses",
                column: "CuorsesCuorseId");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingCenterCourses_Cuorse_CuorsesCuorseId",
                table: "trainingCenterCourses",
                column: "CuorsesCuorseId",
                principalTable: "Cuorse",
                principalColumn: "CuorseId");
        }
    }
}
