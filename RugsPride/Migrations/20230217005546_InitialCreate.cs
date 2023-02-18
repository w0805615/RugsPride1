using Microsoft.EntityFrameworkCore.Migrations;

namespace RugsPride.Migrations
{
    public partial class InitialCreate : Migration   //Got this file by Adding migration using command: Add-Migration IntialCreate
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rug",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Shape = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rug", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rug");
        }
    }
}
