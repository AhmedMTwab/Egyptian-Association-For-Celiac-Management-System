using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class identityerror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientPatientAddress");

            migrationBuilder.AddColumn<int>(
                name: "PatientId1",
                table: "patient_address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_patient_address_PatientId1",
                table: "patient_address",
                column: "PatientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_address_patient_PatientId1",
                table: "patient_address",
                column: "PatientId1",
                principalTable: "patient",
                principalColumn: "patient_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patient_address_patient_PatientId1",
                table: "patient_address");

            migrationBuilder.DropIndex(
                name: "IX_patient_address_PatientId1",
                table: "patient_address");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "patient_address");

            migrationBuilder.AlterColumn<int>(
                name: "patient_id",
                table: "patient",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
    }
}
