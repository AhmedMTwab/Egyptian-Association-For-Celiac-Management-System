using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class newrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ee71e1e-fac4-4f90-bb4e-ecf10520ba93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ad64ea-0994-4b4c-a33e-ceaeb35205f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a55597f-79c8-488f-91f1-a70f5c1046ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8743724-66ae-4fba-9862-f05a9ed3ccd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29797908-d8fb-4691-ba37-a5177f1d14ef", "34295a89-b8f9-431d-8b83-b95f0d21f9b3", "Admin", "admin" },
                    { "750f74ef-66a5-4587-b536-c5084ebe7580", "07bfb070-33c2-4938-b400-e4b546f5c710", "UserManager", "usermanager" },
                    { "a1eeb4b3-eea3-4815-9b86-555afe35b7ba", "9e6c3665-a95c-4f17-a257-a7b80a16e630", "NormalUser", "normaluser" },
                    { "bc40b216-2bea-4044-8ecd-3a727810da21", "eb325fbc-de92-44c4-ac56-dd0e23e5ee59", "StoreManager", "storemanager" },
                    { "cf7f1cb4-dfae-4287-b487-d49d4462b931", "d83b1455-b878-4865-9d12-1e655ce94719", "MedicalManager", "medicalmanager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29797908-d8fb-4691-ba37-a5177f1d14ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "750f74ef-66a5-4587-b536-c5084ebe7580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1eeb4b3-eea3-4815-9b86-555afe35b7ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc40b216-2bea-4044-8ecd-3a727810da21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf7f1cb4-dfae-4287-b487-d49d4462b931");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ee71e1e-fac4-4f90-bb4e-ecf10520ba93", "e9cfdd28-3999-4bea-9805-bc25e080456e", "UserManager", "usermanager" },
                    { "83ad64ea-0994-4b4c-a33e-ceaeb35205f0", "84a3ae2a-82eb-4b23-9cde-732aa72f605f", "StoreManager", "storemanager" },
                    { "9a55597f-79c8-488f-91f1-a70f5c1046ba", "3be6a1e5-0be0-4f79-8d2f-61bc8faa9911", "MedicalManager", "medicalmanager" },
                    { "a8743724-66ae-4fba-9862-f05a9ed3ccd4", "a28ff19d-7b69-4a8a-af04-cbbcd7160419", "Admin", "admin" }
                });
        }
    }
}
