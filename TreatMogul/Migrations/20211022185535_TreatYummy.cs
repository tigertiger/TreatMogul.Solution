using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatMogul.Migrations
{
    public partial class TreatYummy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Yummy",
                table: "Treats",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yummy",
                table: "Treats");
        }
    }
}
