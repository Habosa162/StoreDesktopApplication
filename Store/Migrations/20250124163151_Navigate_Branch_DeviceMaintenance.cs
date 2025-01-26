using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class Navigate_Branch_DeviceMaintenance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "DeviceMaintenances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceMaintenances_BranchId",
                table: "DeviceMaintenances",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenances_Branches_BranchId",
                table: "DeviceMaintenances",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenances_Branches_BranchId",
                table: "DeviceMaintenances");

            migrationBuilder.DropIndex(
                name: "IX_DeviceMaintenances_BranchId",
                table: "DeviceMaintenances");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "DeviceMaintenances");
        }
    }
}
