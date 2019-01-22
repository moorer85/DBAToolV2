using Microsoft.EntityFrameworkCore.Migrations;

namespace DBATool.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_Statuses_StatusId",
                table: "Servers");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Servers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_Statuses_StatusId",
                table: "Servers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servers_Statuses_StatusId",
                table: "Servers");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Servers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Servers_Statuses_StatusId",
                table: "Servers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
