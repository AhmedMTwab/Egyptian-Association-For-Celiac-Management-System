using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_regesteration_admin_id",
                table: "medicaladmin_regesteration",
                column: "admin_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicaladmin_regesteration_medical_admin_admin_id",
                table: "medicaladmin_regesteration",
                column: "admin_id",
                principalTable: "medical_admin",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicaladmin_regesteration_medical_admin_admin_id",
                table: "medicaladmin_regesteration");

            migrationBuilder.DropIndex(
                name: "IX_medicaladmin_regesteration_admin_id",
                table: "medicaladmin_regesteration");
        }
    }
}
