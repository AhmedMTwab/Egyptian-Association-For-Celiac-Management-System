using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class cartpatientrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d4917c4-2e20-41cb-bdd6-7fc4afa60548");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "373dce7c-8c36-4e31-956a-39b50f2d47e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a4ba47-f880-4664-a3de-543c5d227a4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826417dd-cf96-4ce0-873c-23272f699770");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b55bcd7c-9119-4459-aad0-888a733762d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee1861c1-d4f7-489c-aa72-c429b9c73f8f");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "023a3da7-dbbe-4068-bc25-bbc099cdcca8", "95782a18-89e9-4aa5-81ed-72741fb099ad", "Admin", "admin" },
                    { "095edc83-bef8-4edb-9271-c862e85ddd16", "ac3bb1b5-1728-4117-a8a7-d277036994b3", "UserManager", "usermanager" },
                    { "3b7a09c9-19e8-4a90-92e8-40f334798e4a", "7021697a-5ccf-4d22-90a2-70cfb6412163", "NormalUser", "normaluser" },
                    { "80504f11-25ce-4b6d-923f-bdfe51bc7b09", "e28ad55d-832d-4fd8-b9bc-1a52812e91d1", "StoreManager", "storemanager" },
                    { "dbf75c9d-7737-4cd2-9a44-5aabd9b1f60c", "23759e78-1450-4b0a-9012-04e5b2ed93a9", "MedicalManager", "medicalmanager" },
                    { "dc9cb497-4bd4-4169-8c2d-dfc07bace243", "65c18252-94e1-46db-a0b2-bc5d5212beee", "Doctor", "doctor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_PatientId",
                table: "Carts",
                column: "PatientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_patient_PatientId",
                table: "Carts",
                column: "PatientId",
                principalTable: "patient",
                principalColumn: "patient_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_patient_PatientId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_PatientId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023a3da7-dbbe-4068-bc25-bbc099cdcca8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "095edc83-bef8-4edb-9271-c862e85ddd16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b7a09c9-19e8-4a90-92e8-40f334798e4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80504f11-25ce-4b6d-923f-bdfe51bc7b09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf75c9d-7737-4cd2-9a44-5aabd9b1f60c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc9cb497-4bd4-4169-8c2d-dfc07bace243");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Carts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d4917c4-2e20-41cb-bdd6-7fc4afa60548", "8ee1eb28-3418-4265-96e0-b5421aed04cb", "MedicalManager", "medicalmanager" },
                    { "373dce7c-8c36-4e31-956a-39b50f2d47e7", "190c41e5-8465-40b8-ab52-f677af5e7afe", "NormalUser", "normaluser" },
                    { "78a4ba47-f880-4664-a3de-543c5d227a4f", "16386e44-78ef-4dfc-89e0-252be12da4e8", "Doctor", "doctor" },
                    { "826417dd-cf96-4ce0-873c-23272f699770", "c2880092-c17a-44a1-b5f9-21ff86a27a2b", "UserManager", "usermanager" },
                    { "b55bcd7c-9119-4459-aad0-888a733762d5", "5998c294-5263-4c9a-bc90-d9d74af489c3", "StoreManager", "storemanager" },
                    { "ee1861c1-d4f7-489c-aa72-c429b9c73f8f", "4266c657-a068-4398-9e61-75bf4c0d833e", "Admin", "admin" }
                });
        }
    }
}
