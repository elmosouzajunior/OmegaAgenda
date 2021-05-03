using Microsoft.EntityFrameworkCore.Migrations;

namespace OmegaAgenda.Migrations
{
    public partial class ForeignKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Customer_CustomerNameId",
                table: "Scheduling");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Professional_ProfessionalId",
                table: "Scheduling");

            migrationBuilder.DropIndex(
                name: "IX_Scheduling_CustomerNameId",
                table: "Scheduling");

            migrationBuilder.DropColumn(
                name: "CustomerNameId",
                table: "Scheduling");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalId",
                table: "Scheduling",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Scheduling",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Scheduling_CustomerId",
                table: "Scheduling",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Customer_CustomerId",
                table: "Scheduling",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Professional_ProfessionalId",
                table: "Scheduling",
                column: "ProfessionalId",
                principalTable: "Professional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Customer_CustomerId",
                table: "Scheduling");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduling_Professional_ProfessionalId",
                table: "Scheduling");

            migrationBuilder.DropIndex(
                name: "IX_Scheduling_CustomerId",
                table: "Scheduling");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Scheduling");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalId",
                table: "Scheduling",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CustomerNameId",
                table: "Scheduling",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scheduling_CustomerNameId",
                table: "Scheduling",
                column: "CustomerNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Customer_CustomerNameId",
                table: "Scheduling",
                column: "CustomerNameId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduling_Professional_ProfessionalId",
                table: "Scheduling",
                column: "ProfessionalId",
                principalTable: "Professional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
