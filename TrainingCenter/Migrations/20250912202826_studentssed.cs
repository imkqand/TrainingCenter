using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class studentssed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuorses",
                columns: table => new
                {
                    CuorseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuorseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuorseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuorses", x => x.CuorseId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuorses");
        }
    }
}
