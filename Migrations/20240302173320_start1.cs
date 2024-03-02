using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class start1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_reservation_clinic_id",
                table: "reservation",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_patient_id",
                table: "reservation",
                column: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_reservation_clinic_clinic_id",
                table: "reservation",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reservation_patient_patient_id",
                table: "reservation",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reservation_clinic_clinic_id",
                table: "reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_reservation_patient_patient_id",
                table: "reservation");

            migrationBuilder.DropIndex(
                name: "IX_reservation_clinic_id",
                table: "reservation");

            migrationBuilder.DropIndex(
                name: "IX_reservation_patient_id",
                table: "reservation");
        }
    }
}
