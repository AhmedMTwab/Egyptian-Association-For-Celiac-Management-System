using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class multivalue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patient_address_patient_PatientId1",
                table: "patient_address");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_phone_patient",
                table: "patient_phone");

            migrationBuilder.DropIndex(
                name: "IX_patient_address_PatientId1",
                table: "patient_address");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "patient_address");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "patient_phone",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "patient_id",
                table: "patient_phone",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_patient_phone",
                table: "patient_phone",
                columns: new[] { "phone_number", "patient_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_patient_phone_patient",
                table: "patient_phone",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patient_phone_patient",
                table: "patient_phone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patient_phone",
                table: "patient_phone");

            migrationBuilder.AlterColumn<int>(
                name: "patient_id",
                table: "patient_phone",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "phone_number",
                table: "patient_phone",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_patient_phone_patient",
                table: "patient_phone",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");
        }
    }
}
