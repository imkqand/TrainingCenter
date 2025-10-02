using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdatrsfsaaaaws : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lectuerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LectuerAdvan = table.Column<int>(type: "int", nullable: true),
                    Lectuer_AdvanId = table.Column<int>(type: "int", nullable: false),
                    LectuerFound = table.Column<int>(type: "int", nullable: true),
                    Lectuer_FoundId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectuerTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lectuerTypes_lectuer_Advans_Lectuer_AdvanId",
                        column: x => x.Lectuer_AdvanId,
                        principalTable: "lectuer_Advans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lectuerTypes_lectuer_Founds_Lectuer_FoundId",
                        column: x => x.Lectuer_FoundId,
                        principalTable: "lectuer_Founds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_lectuerTypes_Lectuer_AdvanId",
                table: "lectuerTypes",
                column: "Lectuer_AdvanId");

            migrationBuilder.CreateIndex(
                name: "IX_lectuerTypes_Lectuer_FoundId",
                table: "lectuerTypes",
                column: "Lectuer_FoundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lectuerTypes");
        }
    }
}
