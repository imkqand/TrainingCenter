using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subject_Advances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lectuer_type_id = table.Column<int>(type: "int", nullable: true),
                    LectuerTypeId = table.Column<int>(type: "int", nullable: true),
                    examstype = table.Column<int>(type: "int", nullable: true),
                    ExamTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subject_Advances_examTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "examTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subject_Advances_lectuerTypes_LectuerTypeId",
                        column: x => x.LectuerTypeId,
                        principalTable: "lectuerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_subject_Advances_ExamTypeId",
                table: "subject_Advances",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_Advances_LectuerTypeId",
                table: "subject_Advances",
                column: "LectuerTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subject_Advances");
        }
    }
}
