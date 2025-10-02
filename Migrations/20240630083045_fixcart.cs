using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class fixcart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_Carts_CartId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_raw_material_Carts_CartId",
                table: "raw_material");

            migrationBuilder.DropIndex(
                name: "IX_raw_material_CartId",
                table: "raw_material");

            migrationBuilder.DropIndex(
                name: "IX_product_CartId",
                table: "product");

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
                name: "CartId",
                table: "raw_material");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "raw_material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "cart_Material_have",
                columns: table => new
                {
                    Material_id = table.Column<int>(type: "int", nullable: false),
                    cart_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_Material_have", x => new { x.Material_id, x.cart_id });
                    table.ForeignKey(
                        name: "FK_cart_Material_have_Carts_cart_id",
                        column: x => x.cart_id,
                        principalTable: "Carts",
                        principalColumn: "cart_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cart_Material_have_raw_material_Material_id",
                        column: x => x.Material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cart_product_have",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false),
                    cart_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_product_have", x => new { x.product_id, x.cart_id });
                    table.ForeignKey(
                        name: "FK_cart_product_have_Carts_cart_id",
                        column: x => x.cart_id,
                        principalTable: "Carts",
                        principalColumn: "cart_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cart_product_have_product_product_id",
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
                    { "61c7a80e-c44a-456f-b6a5-c330fd054bc7", "bf632cca-d2d0-4283-84ba-30f654e2970f", "StoreManager", "storemanager" },
                    { "67fa9acc-084e-4128-9d32-f3eb8c0a4b33", "db185365-2fbd-4a3a-88b0-4fd45d559651", "Admin", "admin" },
                    { "99564f7a-d72c-44ad-b24a-02d671db31cc", "538e4fcc-d488-4f50-a636-c4081071adeb", "Doctor", "doctor" },
                    { "c46fff74-dc89-4cfe-905c-db3883a06ee8", "94b2d192-bcfd-4cef-a253-bd7bff360d04", "NormalUser", "normaluser" },
                    { "d135894b-b5b3-4570-ab03-1197ce178a84", "c954aec5-7052-4571-91e9-bff91a91e387", "MedicalManager", "medicalmanager" },
                    { "da5e9425-b071-494f-8c93-3896a1f6480d", "5f05c00d-9176-446f-8c52-c247d046b69f", "UserManager", "usermanager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cart_Material_have_cart_id",
                table: "cart_Material_have",
                column: "cart_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_product_have_cart_id",
                table: "cart_product_have",
                column: "cart_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart_Material_have");

            migrationBuilder.DropTable(
                name: "cart_product_have");

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

            migrationBuilder.DropColumn(
                name: "stock",
                table: "raw_material");

            migrationBuilder.DropColumn(
                name: "stock",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "raw_material",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "product",
                type: "int",
                nullable: true);

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
                name: "IX_raw_material_CartId",
                table: "raw_material",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_product_CartId",
                table: "product",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_Carts_CartId",
                table: "product",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "cart_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_raw_material_Carts_CartId",
                table: "raw_material",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "cart_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
