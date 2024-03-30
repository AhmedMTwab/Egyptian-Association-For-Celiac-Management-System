using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class composedkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_patient_address",
                table: "patient_address",
                columns: new[] { "address", "patient_id" });

            migrationBuilder.CreateTable(
                name: "PatientPatientAddress",
                columns: table => new
                {
                    Patient1PatientId = table.Column<int>(type: "int", nullable: false),
                    AddressesAddress = table.Column<string>(type: "varchar(50)", nullable: false),
                    AddressesPatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPatientAddress", x => new { x.Patient1PatientId, x.AddressesAddress, x.AddressesPatientId });
                    table.ForeignKey(
                        name: "FK_PatientPatientAddress_patient_Patient1PatientId",
                        column: x => x.Patient1PatientId,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientPatientAddress_patient_address_AddressesAddress_AddressesPatientId",
                        columns: x => new { x.AddressesAddress, x.AddressesPatientId },
                        principalTable: "patient_address",
                        principalColumns: new[] { "address", "patient_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientPatientAddress_AddressesAddress_AddressesPatientId",
                table: "PatientPatientAddress",
                columns: new[] { "AddressesAddress", "AddressesPatientId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientPatientAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patient_address",
                table: "patient_address");
        }
    }
}
