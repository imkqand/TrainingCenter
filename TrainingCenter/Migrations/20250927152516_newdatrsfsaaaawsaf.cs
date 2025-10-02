using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsaf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subject_Fondationals",
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
                    table.PrimaryKey("PK_subject_Fondationals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subject_Fondationals_examTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "examTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subject_Fondationals_lectuerTypes_LectuerTypeId",
                        column: x => x.LectuerTypeId,
                        principalTable: "lectuerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_subject_Fondationals_ExamTypeId",
                table: "subject_Fondationals",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_Fondationals_LectuerTypeId",
                table: "subject_Fondationals",
                column: "LectuerTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subject_Fondationals");
        }
    }
}
