using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsafddfeefvette : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseAdvan = table.Column<int>(type: "int", nullable: true),
                    CourseAdvanceId = table.Column<int>(type: "int", nullable: true),
                    CourseFound = table.Column<int>(type: "int", nullable: true),
                    CourseFoundationalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courses_courseAdvances_CourseAdvanceId",
                        column: x => x.CourseAdvanceId,
                        principalTable: "courseAdvances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courses_courseFoundationals_CourseFoundationalId",
                        column: x => x.CourseFoundationalId,
                        principalTable: "courseFoundationals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseAdvanceId",
                table: "courses",
                column: "CourseAdvanceId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseFoundationalId",
                table: "courses",
                column: "CourseFoundationalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
