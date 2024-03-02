using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_cart_payment_id",
                table: "cart",
                column: "payment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_payment_payment_id",
                table: "cart",
                column: "payment_id",
                principalTable: "payment",
                principalColumn: "payment_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_payment_payment_id",
                table: "cart");

            migrationBuilder.DropIndex(
                name: "IX_cart_payment_id",
                table: "cart");
        }
    }
}
