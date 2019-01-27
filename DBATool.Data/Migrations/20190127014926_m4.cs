using Microsoft.EntityFrameworkCore.Migrations;

namespace DBATool.Data.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Databases_Employees_BackupDBAId",
                table: "Databases");

            migrationBuilder.DropForeignKey(
                name: "FK_Databases_Employees_DatabaseOwnerId",
                table: "Databases");

            migrationBuilder.DropForeignKey(
                name: "FK_Databases_Employees_PrimaryDBAId",
                table: "Databases");

            migrationBuilder.DropIndex(
                name: "IX_Databases_BackupDBAId",
                table: "Databases");

            migrationBuilder.DropIndex(
                name: "IX_Databases_DatabaseOwnerId",
                table: "Databases");

            migrationBuilder.DropIndex(
                name: "IX_Databases_PrimaryDBAId",
                table: "Databases");

            migrationBuilder.DropColumn(
                name: "BackupDBAId",
                table: "Databases");

            migrationBuilder.DropColumn(
                name: "DatabaseOwnerId",
                table: "Databases");

            migrationBuilder.DropColumn(
                name: "PrimaryDBAId",
                table: "Databases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BackupDBAId",
                table: "Databases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DatabaseOwnerId",
                table: "Databases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryDBAId",
                table: "Databases",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Databases_BackupDBAId",
                table: "Databases",
                column: "BackupDBAId");

            migrationBuilder.CreateIndex(
                name: "IX_Databases_DatabaseOwnerId",
                table: "Databases",
                column: "DatabaseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Databases_PrimaryDBAId",
                table: "Databases",
                column: "PrimaryDBAId");

            migrationBuilder.AddForeignKey(
                name: "FK_Databases_Employees_BackupDBAId",
                table: "Databases",
                column: "BackupDBAId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Databases_Employees_DatabaseOwnerId",
                table: "Databases",
                column: "DatabaseOwnerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Databases_Employees_PrimaryDBAId",
                table: "Databases",
                column: "PrimaryDBAId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
