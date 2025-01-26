using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class AddAllDbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Branches_BranchId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Platform_PlatformId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCard_Platform_PlatformId",
                table: "DigitalCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Branches_BranchId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_DeviceMaintenance_DeviceMaintenanceId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_DigitalCard_DigitalCardtId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Invoice_InvoiceId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItem_Product_ProductId",
                table: "InvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Branches_BranchId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Platform_PlatformId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platform",
                table: "Platform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItem",
                table: "InvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Platform",
                newName: "Platforms");

            migrationBuilder.RenameTable(
                name: "InvoiceItem",
                newName: "InvoiceItems");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Product_PlatformId",
                table: "Products",
                newName: "IX_Products_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BranchId",
                table: "Products",
                newName: "IX_Products_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_ProductId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_InvoiceId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_InvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_DigitalCardtId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_DigitalCardtId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItem_DeviceMaintenanceId",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_DeviceMaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_BranchId",
                table: "Invoices",
                newName: "IX_Invoices_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_BranchId",
                table: "Customers",
                newName: "IX_Customers_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms",
                column: "PlatformId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems",
                column: "InvoiceItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "phoneNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Branches_BranchId",
                table: "Customers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Platforms_PlatformId",
                table: "DeviceMaintenance",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCard_Platforms_PlatformId",
                table: "DigitalCard",
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

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_DigitalCard_DigitalCardtId",
                table: "InvoiceItems",
                column: "DigitalCardtId",
                principalTable: "DigitalCard",
                principalColumn: "DigitalCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Products_ProductId",
                table: "InvoiceItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Branches_BranchId",
                table: "Invoices",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Branches_BranchId",
                table: "Products",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Platforms_PlatformId",
                table: "Products",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Branches_BranchId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Platforms_PlatformId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCard_Platforms_PlatformId",
                table: "DigitalCard");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DeviceMaintenance_DeviceMaintenanceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DigitalCard_DigitalCardtId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Products_ProductId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Branches_BranchId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Branches_BranchId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Platforms_PlatformId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Platforms",
                newName: "Platform");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceItems",
                newName: "InvoiceItem");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Products_PlatformId",
                table: "Product",
                newName: "IX_Product_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BranchId",
                table: "Product",
                newName: "IX_Product_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_BranchId",
                table: "Invoice",
                newName: "IX_Invoice_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_ProductId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_InvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_DigitalCardtId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_DigitalCardtId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_DeviceMaintenanceId",
                table: "InvoiceItem",
                newName: "IX_InvoiceItem_DeviceMaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_BranchId",
                table: "Customer",
                newName: "IX_Customer_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platform",
                table: "Platform",
                column: "PlatformId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItem",
                table: "InvoiceItem",
                column: "InvoiceItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "phoneNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Branches_BranchId",
                table: "Customer",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Platform_PlatformId",
                table: "DeviceMaintenance",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCard_Platform_PlatformId",
                table: "DigitalCard",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Branches_BranchId",
                table: "Invoice",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_DeviceMaintenance_DeviceMaintenanceId",
                table: "InvoiceItem",
                column: "DeviceMaintenanceId",
                principalTable: "DeviceMaintenance",
                principalColumn: "DeviceMaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_DigitalCard_DigitalCardtId",
                table: "InvoiceItem",
                column: "DigitalCardtId",
                principalTable: "DigitalCard",
                principalColumn: "DigitalCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Invoice_InvoiceId",
                table: "InvoiceItem",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItem_Product_ProductId",
                table: "InvoiceItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Branches_BranchId",
                table: "Product",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Platform_PlatformId",
                table: "Product",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
