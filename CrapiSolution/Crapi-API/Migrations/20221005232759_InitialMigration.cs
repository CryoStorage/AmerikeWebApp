using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crapi_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jumps = table.Column<int>(type: "INTEGER", nullable: false),
                    Wins = table.Column<int>(type: "INTEGER", nullable: false),
                    Deaths = table.Column<int>(type: "INTEGER", nullable: false),
                    OrbsCollected = table.Column<int>(type: "INTEGER", nullable: false),
                    OrbsSpent = table.Column<int>(type: "INTEGER", nullable: false),
                    AdsWatched = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayTime = table.Column<long>(type: "INTEGER", nullable: false),
                    AvgPlaySession = table.Column<long>(type: "INTEGER", nullable: false),
                    DistanceClimbed = table.Column<long>(type: "INTEGER", nullable: false),
                    DistanceFallen = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
