using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class nullablecartid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07c277cf-e131-451d-8ab9-c8e9c8ccb7aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bcae34f-4f0f-4504-ba1b-5f48b27dc3dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ff65ed8-01eb-4e8a-b044-a68dbacd3d4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77e8b0ab-072f-482f-a74d-ed0451a168e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b6d9be1-6eac-40cf-b69f-899910ff7997");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8d54bed-6f2f-40f6-a9ca-ef4c8450615a");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "raw_material",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "raw_material",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07c277cf-e131-451d-8ab9-c8e9c8ccb7aa", "4615f5df-6745-4f82-bda9-398cb9fc06e8", "UserManager", "usermanager" },
                    { "6bcae34f-4f0f-4504-ba1b-5f48b27dc3dd", "af9ed102-3a2a-436a-95cb-b48183850688", "Admin", "admin" },
                    { "6ff65ed8-01eb-4e8a-b044-a68dbacd3d4a", "455d62ad-a952-4ea7-88c8-18bce29a87da", "Doctor", "doctor" },
                    { "77e8b0ab-072f-482f-a74d-ed0451a168e2", "13829279-6805-43be-b47c-8df2a32758dd", "StoreManager", "storemanager" },
                    { "9b6d9be1-6eac-40cf-b69f-899910ff7997", "acd08230-b280-455a-80c1-d0c42fc30741", "MedicalManager", "medicalmanager" },
                    { "c8d54bed-6f2f-40f6-a9ca-ef4c8450615a", "475ddf7b-8e58-4888-8ae7-780047ee9c80", "NormalUser", "normaluser" }
                });
        }
    }
}
