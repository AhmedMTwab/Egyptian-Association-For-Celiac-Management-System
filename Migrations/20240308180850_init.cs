using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
<<<<<<< HEAD
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "useradmin_patient_approve");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "useradmin_patient_approve",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_useradmin_patient_approve_user_admin",
                        column: x => x.admin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_patient_approve_admin_id",
                table: "useradmin_patient_approve",
                column: "admin_id");
        }
    }
}
=======
	/// <inheritdoc />
	public partial class init : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{

		}
	}
}
>>>>>>> b3feb215df36f47c5294f1f05e4b5bfc9afad0ad
