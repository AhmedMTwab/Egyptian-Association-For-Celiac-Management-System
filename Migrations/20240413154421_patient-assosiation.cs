using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class patientassosiation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_patient_assosiation_branch_AssosiationId",
            //    table: "patient");

            migrationBuilder.RenameColumn(
                name: "AssosiationId",
                table: "patient",
                newName: "assosiationid");

            migrationBuilder.RenameIndex(
                name: "IX_patient_AssosiationId",
                table: "patient",
                newName: "IX_patient_assosiationid");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_assosiation_branch_assosiationid",
                table: "patient",
                column: "assosiationid",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patient_assosiation_branch_assosiationid",
                table: "patient");

            migrationBuilder.RenameColumn(
                name: "assosiationid",
                table: "patient",
                newName: "AssosiationId");

            migrationBuilder.RenameIndex(
                name: "IX_patient_assosiationid",
                table: "patient",
                newName: "IX_patient_AssosiationId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_patient_assosiation_branch_AssosiationId",
            //    table: "patient",
            //    column: "AssosiationId",
            //    principalTable: "assosiation_branch",
            //    principalColumn: "assosiation_id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
