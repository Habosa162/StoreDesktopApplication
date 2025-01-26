using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class addingSystemUserIntoTransAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BranchID",
                table: "Transactions",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_username",
                table: "Transactions",
                column: "username");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Branches_BranchID",
                table: "Transactions",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_SystemUsers_username",
                table: "Transactions",
                column: "username",
                principalTable: "SystemUsers",
                principalColumn: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Branches_BranchID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_SystemUsers_username",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_BranchID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_username",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Transactions");
        }
    }
}
