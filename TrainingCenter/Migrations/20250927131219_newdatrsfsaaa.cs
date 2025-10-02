using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "examTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exam_Found = table.Column<int>(type: "int", nullable: true),
                    ExamFoundationalsId = table.Column<int>(type: "int", nullable: true),
                    Exam_Advnv = table.Column<int>(type: "int", nullable: true),
                    ExamAdvancceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_examTypes_ExamAdvancces_ExamAdvancceId",
                        column: x => x.ExamAdvancceId,
                        principalTable: "ExamAdvancces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_examTypes_examFoundationals_ExamFoundationalsId",
                        column: x => x.ExamFoundationalsId,
                        principalTable: "examFoundationals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_examTypes_ExamAdvancceId",
                table: "examTypes",
                column: "ExamAdvancceId");

            migrationBuilder.CreateIndex(
                name: "IX_examTypes_ExamFoundationalsId",
                table: "examTypes",
                column: "ExamFoundationalsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "examTypes");
        }
    }
}
