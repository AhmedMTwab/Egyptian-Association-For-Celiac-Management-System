using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class orderpaymenthave : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ca39fdd-4060-4313-af95-fff742145602");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c30a9e7-b971-4531-bb54-4a6abcb8fcd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "732fd563-5ec1-4be8-9988-fc3686c35550");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "748ed33b-fdf5-48b6-8ab7-bff5f4d3ff94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afcc3663-a6b9-49a7-b1c5-c5827b9eeca9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ae6baf-fdd1-4a73-80c2-4632c2d11be7");

            migrationBuilder.AddColumn<int>(
                name: "Payment_id",
                table: "order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08756800-1cdb-4b7d-b537-05db00b37960", "98da8292-d46d-45e4-a5b2-6f98f9791251", "Doctor", "doctor" },
                    { "23f0c0dc-c516-4cb2-9a47-94d697921c8f", "1e9eee6d-0852-4c43-9c78-95c6c79fdfe6", "MedicalManager", "medicalmanager" },
                    { "8872bcac-18e9-4a41-8d15-fc8cb5c5b4a1", "b7cb9743-83e6-4c2c-b605-300607896cb9", "UserManager", "usermanager" },
                    { "cf71d772-8390-4744-906b-2f6e37a95d54", "eda6c94e-5378-4516-ac00-62f3db03121e", "StoreManager", "storemanager" },
                    { "e7b9027b-065f-4326-9b01-fbfef5fa0ff7", "5c9edde2-66d0-4478-a816-6773e9f20ac8", "NormalUser", "normaluser" },
                    { "eb3e8f2b-2f5d-4764-9f4d-9b4d00c8d469", "a4233711-e92d-4020-a836-88de20341d05", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08756800-1cdb-4b7d-b537-05db00b37960");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23f0c0dc-c516-4cb2-9a47-94d697921c8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8872bcac-18e9-4a41-8d15-fc8cb5c5b4a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf71d772-8390-4744-906b-2f6e37a95d54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b9027b-065f-4326-9b01-fbfef5fa0ff7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb3e8f2b-2f5d-4764-9f4d-9b4d00c8d469");

            migrationBuilder.DropColumn(
                name: "Payment_id",
                table: "order");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ca39fdd-4060-4313-af95-fff742145602", "c29bbf6d-f434-4838-a9f0-4a4e4a3cf2be", "Admin", "admin" },
                    { "2c30a9e7-b971-4531-bb54-4a6abcb8fcd8", "80516a83-bcb7-4fe9-8327-ae5f8cdb56cc", "Doctor", "doctor" },
                    { "732fd563-5ec1-4be8-9988-fc3686c35550", "6ab54bff-2288-4688-b5a9-c673e92e4588", "StoreManager", "storemanager" },
                    { "748ed33b-fdf5-48b6-8ab7-bff5f4d3ff94", "2c9bf9b8-ebee-464f-973c-899ae3bb3efc", "MedicalManager", "medicalmanager" },
                    { "afcc3663-a6b9-49a7-b1c5-c5827b9eeca9", "e984edfd-3a30-4264-825e-ee8bf159fa80", "NormalUser", "normaluser" },
                    { "e5ae6baf-fdd1-4a73-80c2-4632c2d11be7", "6b041bf8-2a2b-44da-bb2e-f6d36b747d38", "UserManager", "usermanager" }
                });
        }
    }
}
