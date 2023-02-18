using Microsoft.EntityFrameworkCore.Migrations;

namespace RugsPride.Migrations
{
    public partial class Rating : Migration       //Add-Migration Rating
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Rug",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Rug");
        }
    }
}
