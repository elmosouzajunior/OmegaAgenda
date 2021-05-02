using Microsoft.EntityFrameworkCore.Migrations;

namespace OmegaAgenda.Migrations
{
    public partial class Entities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceName",
                table: "Service",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceName",
                table: "Service");
        }
    }
}
