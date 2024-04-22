using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class patientmedicalrecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_medical_record_patient_id",
                table: "medical_record",
                column: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medical_record_patient_patient_id",
                table: "medical_record",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medical_record_patient_patient_id",
                table: "medical_record");

            migrationBuilder.DropIndex(
                name: "IX_medical_record_patient_id",
                table: "medical_record");
        }
    }
}
