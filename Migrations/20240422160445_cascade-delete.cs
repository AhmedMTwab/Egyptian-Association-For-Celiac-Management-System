using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class cascadedelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_patient",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_address_patient",
                table: "patient_address");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_dises-have_dises",
                table: "patient_dises-have");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_dises-have_patient",
                table: "patient_dises-have");

            migrationBuilder.AddForeignKey(
                name: "FK_order_patient",
                table: "order",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_address_patient",
                table: "patient_address",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patient_dises-have_dises",
                table: "patient_dises-have",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patient_dises-have_patient",
                table: "patient_dises-have",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_patient",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_address_patient",
                table: "patient_address");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_dises-have_dises",
                table: "patient_dises-have");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_dises-have_patient",
                table: "patient_dises-have");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_patient",
                table: "order",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_address_patient",
                table: "patient_address",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_dises-have_dises",
                table: "patient_dises-have",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_dises-have_patient",
                table: "patient_dises-have",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");
        }
    }
}
