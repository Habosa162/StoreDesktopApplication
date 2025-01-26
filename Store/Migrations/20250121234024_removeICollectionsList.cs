using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class removeICollectionsList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Branches_BranchId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Branches_BranchId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCards_Branches_BranchId",
                table: "DigitalCards");

            migrationBuilder.DropIndex(
                name: "IX_DigitalCards_BranchId",
                table: "DigitalCards");

            migrationBuilder.DropIndex(
                name: "IX_DeviceMaintenance_BranchId",
                table: "DeviceMaintenance");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BranchId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "DigitalCards");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "DeviceMaintenance");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "DigitalCards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "DeviceMaintenance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DigitalCards_BranchId",
                table: "DigitalCards",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceMaintenance_BranchId",
                table: "DeviceMaintenance",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BranchId",
                table: "Customers",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Branches_BranchId",
                table: "Customers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Branches_BranchId",
                table: "DeviceMaintenance",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCards_Branches_BranchId",
                table: "DigitalCards",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");
        }
    }
}
