using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class orderpaymentadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "267a8ca8-aeda-4a6f-ab21-4e917082e4f0", "8cbe32a0-6c16-4c02-87c8-be9ec59deea3", "StoreManager", "storemanager" },
                    { "5385811b-9207-41da-8dd7-c81329b7569b", "49ac20e5-5043-437a-a1e4-db26a320e900", "MedicalManager", "medicalmanager" },
                    { "586ff84d-a08e-4ecd-941c-ed12230f619a", "5cef69f4-208a-4e9b-8da1-b0a5a4a65ffd", "NormalUser", "normaluser" },
                    { "8d6ba35f-3637-4b2e-8ded-6682851628c1", "bd8a0204-04f8-48f1-a7cd-34beec85fdbe", "Doctor", "doctor" },
                    { "a0510c45-0b4b-4101-afc1-4f5089250e07", "c29e2fd7-0a05-4500-a165-bd371d64c645", "Admin", "admin" },
                    { "b1579663-985e-45eb-9f53-994d861e26c0", "2de95d0f-3d43-4230-b20c-415308c1ae38", "UserManager", "usermanager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_Payment_id",
                table: "order",
                column: "Payment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_payment_Payment_id",
                table: "order",
                column: "Payment_id",
                principalTable: "payment",
                principalColumn: "payment_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_payment_Payment_id",
                table: "order");

            migrationBuilder.DropIndex(
                name: "IX_order_Payment_id",
                table: "order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "267a8ca8-aeda-4a6f-ab21-4e917082e4f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5385811b-9207-41da-8dd7-c81329b7569b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "586ff84d-a08e-4ecd-941c-ed12230f619a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d6ba35f-3637-4b2e-8ded-6682851628c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0510c45-0b4b-4101-afc1-4f5089250e07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1579663-985e-45eb-9f53-994d861e26c0");

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
    }
}
