using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Digital_Card_Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_DigitalCards_DigitalCardtId",
                table: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "DigitalCards");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItems_DigitalCardtId",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "DigitalCardtId",
                table: "InvoiceItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DigitalCardtId",
                table: "InvoiceItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DigitalCards",
                columns: table => new
                {
                    DigitalCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigitalCards", x => x.DigitalCardId);
                    table.ForeignKey(
                        name: "FK_DigitalCards_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_DigitalCardtId",
                table: "InvoiceItems",
                column: "DigitalCardtId");

            migrationBuilder.CreateIndex(
                name: "IX_DigitalCards_PlatformId",
                table: "DigitalCards",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_DigitalCards_DigitalCardtId",
                table: "InvoiceItems",
                column: "DigitalCardtId",
                principalTable: "DigitalCards",
                principalColumn: "DigitalCardId");
        }
    }
}
