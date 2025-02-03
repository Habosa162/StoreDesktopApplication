using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class AddCondtionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConditionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    ConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    condition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.ConditionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ConditionId",
                table: "Products",
                column: "ConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Conditions_ConditionId",
                table: "Products",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "ConditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Conditions_ConditionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropIndex(
                name: "IX_Products_ConditionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ConditionId",
                table: "Products");
        }
    }
}
