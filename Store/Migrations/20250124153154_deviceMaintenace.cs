using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class deviceMaintenace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Categories_CategoryId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Platforms_PlatformId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DeviceMaintenance_DeviceMaintenanceId",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceMaintenance",
                table: "DeviceMaintenance");

            migrationBuilder.RenameTable(
                name: "DeviceMaintenance",
                newName: "DeviceMaintenances");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceMaintenance_PlatformId",
                table: "DeviceMaintenances",
                newName: "IX_DeviceMaintenances_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceMaintenance_CategoryId",
                table: "DeviceMaintenances",
                newName: "IX_DeviceMaintenances_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeviceMaintenances",
                table: "DeviceMaintenances",
                column: "DeviceMaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenances_Categories_CategoryId",
                table: "DeviceMaintenances",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenances_Platforms_PlatformId",
                table: "DeviceMaintenances",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_DeviceMaintenances_DeviceMaintenanceId",
                table: "InvoiceItems",
                column: "DeviceMaintenanceId",
                principalTable: "DeviceMaintenances",
                principalColumn: "DeviceMaintenanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenances_Categories_CategoryId",
                table: "DeviceMaintenances");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenances_Platforms_PlatformId",
                table: "DeviceMaintenances");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DeviceMaintenances_DeviceMaintenanceId",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceMaintenances",
                table: "DeviceMaintenances");

            migrationBuilder.RenameTable(
                name: "DeviceMaintenances",
                newName: "DeviceMaintenance");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceMaintenances_PlatformId",
                table: "DeviceMaintenance",
                newName: "IX_DeviceMaintenance_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceMaintenances_CategoryId",
                table: "DeviceMaintenance",
                newName: "IX_DeviceMaintenance_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeviceMaintenance",
                table: "DeviceMaintenance",
                column: "DeviceMaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Categories_CategoryId",
                table: "DeviceMaintenance",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Platforms_PlatformId",
                table: "DeviceMaintenance",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_DeviceMaintenance_DeviceMaintenanceId",
                table: "InvoiceItems",
                column: "DeviceMaintenanceId",
                principalTable: "DeviceMaintenance",
                principalColumn: "DeviceMaintenanceId");
        }
    }
}
