using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class AddingCustomertoInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerPhoneNumber",
                table: "Invoices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerPhoneNumber",
                table: "Invoices",
                column: "CustomerPhoneNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customers_CustomerPhoneNumber",
                table: "Invoices",
                column: "CustomerPhoneNumber",
                principalTable: "Customers",
                principalColumn: "phoneNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_CustomerPhoneNumber",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CustomerPhoneNumber",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CustomerPhoneNumber",
                table: "Invoices");
        }
    }
}
