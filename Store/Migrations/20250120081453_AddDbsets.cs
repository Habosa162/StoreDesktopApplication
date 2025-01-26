using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class AddDbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Branch_BranchId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Branch_BranchId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Category_CategoryId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCard_Branch_BranchId",
                table: "DigitalCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Branch_BranchId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Branch_BranchId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemUsers_Branch_BranchId",
                table: "SystemUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "Branches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branches",
                table: "Branches",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Branches_BranchId",
                table: "Customer",
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
                name: "FK_DeviceMaintenance_Categories_CategoryId",
                table: "DeviceMaintenance",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCard_Branches_BranchId",
                table: "DigitalCard",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Branches_BranchId",
                table: "Invoice",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_SystemUsers_Branches_BranchId",
                table: "SystemUsers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Branches_BranchId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Branches_BranchId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceMaintenance_Categories_CategoryId",
                table: "DeviceMaintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCard_Branches_BranchId",
                table: "DigitalCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Branches_BranchId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Branches_BranchId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemUsers_Branches_BranchId",
                table: "SystemUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branches",
                table: "Branches");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Branches",
                newName: "Branch");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Branch_BranchId",
                table: "Customer",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Branch_BranchId",
                table: "DeviceMaintenance",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceMaintenance_Category_CategoryId",
                table: "DeviceMaintenance",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCard_Branch_BranchId",
                table: "DigitalCard",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Branch_BranchId",
                table: "Invoice",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Branch_BranchId",
                table: "Product",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemUsers_Branch_BranchId",
                table: "SystemUsers",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
