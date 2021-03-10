using Microsoft.EntityFrameworkCore.Migrations;

namespace Resarvation.Migrations
{
    public partial class relationApprennt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprenantId",
                table: "Reservations",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ApprenantId",
                table: "Reservations",
                column: "ApprenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_ApprenantId",
                table: "Reservations",
                column: "ApprenantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_ApprenantId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ApprenantId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ApprenantId",
                table: "Reservations");
        }
    }
}
