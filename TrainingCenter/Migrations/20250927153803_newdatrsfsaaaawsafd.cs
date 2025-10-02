using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaawsafd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject_Adv = table.Column<int>(type: "int", nullable: true),
                    Subjects_AdvancesId = table.Column<int>(type: "int", nullable: true),
                    Subjects_fond = table.Column<int>(type: "int", nullable: true),
                    Subject_FondationalsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjectTypes_subject_Advances_Subjects_AdvancesId",
                        column: x => x.Subjects_AdvancesId,
                        principalTable: "subject_Advances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectTypes_subject_Fondationals_Subject_FondationalsId",
                        column: x => x.Subject_FondationalsId,
                        principalTable: "subject_Fondationals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_subjectTypes_Subject_FondationalsId",
                table: "subjectTypes",
                column: "Subject_FondationalsId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectTypes_Subjects_AdvancesId",
                table: "subjectTypes",
                column: "Subjects_AdvancesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subjectTypes");
        }
    }
}
