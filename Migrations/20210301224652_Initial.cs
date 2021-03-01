using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackjackAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    DealerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayStyle = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.DealerId);
                });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "DealerId", "Description", "Name", "PlayStyle" },
                values: new object[] { 1, "Just a drifter, rolling wherever the wind takes him", "Tumbleweed Terrence", 4 });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "DealerId", "Description", "Name", "PlayStyle" },
                values: new object[] { 2, "A ruthless rapscallion, chive-talker, onion hip-hop enthusiast", "Randall the Ruthless", 3 });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "DealerId", "Description", "Name", "PlayStyle" },
                values: new object[] { 3, "A poker hand as deadly as her six-shooter", "Kissin' Kate Barlow", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dealers");
        }
    }
}
