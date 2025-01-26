using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class remov_maintenance_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_DeviceMaintenanceStatus_StatusId",
                table: "DeviceMaintenance");

            migrationBuilder.DropTable(
                name: "DeviceMaintenanceStatus");

            migrationBuilder.DropIndex(
                name: "IX_DeviceMaintenance_StatusId",
                table: "DeviceMaintenance");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "DeviceMaintenance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "DeviceMaintenance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeviceMaintenanceStatus",
                columns: table => new
                {
                    DeviceMaintenanceStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceMaintenanceStatus", x => x.DeviceMaintenanceStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceMaintenance_StatusId",
                table: "DeviceMaintenance",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_DeviceMaintenanceStatus_StatusId",
                table: "DeviceMaintenance",
                column: "StatusId",
                principalTable: "DeviceMaintenanceStatus",
                principalColumn: "DeviceMaintenanceStatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
