using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class fixorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61c7a80e-c44a-456f-b6a5-c330fd054bc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67fa9acc-084e-4128-9d32-f3eb8c0a4b33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99564f7a-d72c-44ad-b24a-02d671db31cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c46fff74-dc89-4cfe-905c-db3883a06ee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d135894b-b5b3-4570-ab03-1197ce178a84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da5e9425-b071-494f-8c93-3896a1f6480d");

            migrationBuilder.CreateTable(
                name: "order_material",
                columns: table => new
                {
                    Material_id = table.Column<int>(type: "int", nullable: false),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_material", x => new { x.Material_id, x.order_id });
                    table.ForeignKey(
                        name: "FK_order_material_order_order_id",
                        column: x => x.order_id,
                        principalTable: "order",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_material_raw_material_Material_id",
                        column: x => x.Material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_product", x => new { x.product_id, x.order_id });
                    table.ForeignKey(
                        name: "FK_order_product_order_order_id",
                        column: x => x.order_id,
                        principalTable: "order",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_product_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_order_material_order_id",
                table: "order_material",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_product_order_id",
                table: "order_product",
                column: "order_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_material");

            migrationBuilder.DropTable(
                name: "order_product");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61c7a80e-c44a-456f-b6a5-c330fd054bc7", "bf632cca-d2d0-4283-84ba-30f654e2970f", "StoreManager", "storemanager" },
                    { "67fa9acc-084e-4128-9d32-f3eb8c0a4b33", "db185365-2fbd-4a3a-88b0-4fd45d559651", "Admin", "admin" },
                    { "99564f7a-d72c-44ad-b24a-02d671db31cc", "538e4fcc-d488-4f50-a636-c4081071adeb", "Doctor", "doctor" },
                    { "c46fff74-dc89-4cfe-905c-db3883a06ee8", "94b2d192-bcfd-4cef-a253-bd7bff360d04", "NormalUser", "normaluser" },
                    { "d135894b-b5b3-4570-ab03-1197ce178a84", "c954aec5-7052-4571-91e9-bff91a91e387", "MedicalManager", "medicalmanager" },
                    { "da5e9425-b071-494f-8c93-3896a1f6480d", "5f05c00d-9176-446f-8c52-c247d046b69f", "UserManager", "usermanager" }
                });
        }
    }
}
