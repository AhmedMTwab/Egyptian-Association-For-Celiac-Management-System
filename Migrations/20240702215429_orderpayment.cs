using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class orderpayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payment_order_OrderId",
                table: "payment");

            migrationBuilder.DropIndex(
                name: "IX_payment_OrderId",
                table: "payment");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22684772-8e3a-415a-b7be-bd6a01736e74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d984a1c-bc84-47d9-865a-af5a4c80d0ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fbe34d8-cc82-4dc1-a5a0-3a2987b1a0ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01103c1-d5f4-443b-8676-e16f5c103a7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d23e5e74-6163-45bf-97be-2e0e07fd16b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dff860eb-01e8-44ca-ba69-b197067878fd");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "payment");

            migrationBuilder.DropColumn(
                name: "total_paid",
                table: "payment");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "OrderId",
                table: "payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "total_paid",
                table: "payment",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22684772-8e3a-415a-b7be-bd6a01736e74", "303e245a-c576-47f2-b96e-02b6beff1575", "Doctor", "doctor" },
                    { "8d984a1c-bc84-47d9-865a-af5a4c80d0ad", "d3dce088-cd21-48cc-93f0-b1146a22ccb2", "StoreManager", "storemanager" },
                    { "8fbe34d8-cc82-4dc1-a5a0-3a2987b1a0ae", "0d633a93-b476-42e3-97a4-005c93823915", "MedicalManager", "medicalmanager" },
                    { "b01103c1-d5f4-443b-8676-e16f5c103a7f", "776423dd-dd9b-495b-8264-949f028cb460", "Admin", "admin" },
                    { "d23e5e74-6163-45bf-97be-2e0e07fd16b1", "a99f18fc-89c5-4a79-8593-613b58956ad0", "UserManager", "usermanager" },
                    { "dff860eb-01e8-44ca-ba69-b197067878fd", "f77da2b6-52c8-493b-9dfe-1a60c60672a5", "NormalUser", "normaluser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_payment_OrderId",
                table: "payment",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_payment_order_OrderId",
                table: "payment",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
