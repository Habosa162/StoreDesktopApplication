using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameDigitalCardsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCard_Branches_BranchId",
                table: "DigitalCard");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCard_Platforms_PlatformId",
                table: "DigitalCard");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DigitalCard_DigitalCardtId",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DigitalCard",
                table: "DigitalCard");

            migrationBuilder.RenameTable(
                name: "DigitalCard",
                newName: "DigitalCards");

            migrationBuilder.RenameIndex(
                name: "IX_DigitalCard_PlatformId",
                table: "DigitalCards",
                newName: "IX_DigitalCards_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_DigitalCard_BranchId",
                table: "DigitalCards",
                newName: "IX_DigitalCards_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DigitalCards",
                table: "DigitalCards",
                column: "DigitalCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCards_Branches_BranchId",
                table: "DigitalCards",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCards_Platforms_PlatformId",
                table: "DigitalCards",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_DigitalCards_DigitalCardtId",
                table: "InvoiceItems",
                column: "DigitalCardtId",
                principalTable: "DigitalCards",
                principalColumn: "DigitalCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCards_Branches_BranchId",
                table: "DigitalCards");

            migrationBuilder.DropForeignKey(
                name: "FK_DigitalCards_Platforms_PlatformId",
                table: "DigitalCards");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DigitalCards_DigitalCardtId",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DigitalCards",
                table: "DigitalCards");

            migrationBuilder.RenameTable(
                name: "DigitalCards",
                newName: "DigitalCard");

            migrationBuilder.RenameIndex(
                name: "IX_DigitalCards_PlatformId",
                table: "DigitalCard",
                newName: "IX_DigitalCard_PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_DigitalCards_BranchId",
                table: "DigitalCard",
                newName: "IX_DigitalCard_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DigitalCard",
                table: "DigitalCard",
                column: "DigitalCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCard_Branches_BranchId",
                table: "DigitalCard",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalCard_Platforms_PlatformId",
                table: "DigitalCard",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_DigitalCard_DigitalCardtId",
                table: "InvoiceItems",
                column: "DigitalCardtId",
                principalTable: "DigitalCard",
                principalColumn: "DigitalCardId");
        }
    }
}
