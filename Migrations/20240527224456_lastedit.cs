using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class lastedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medicaladmin_clinic_control");

            migrationBuilder.DropTable(
                name: "medicaladmin_hospital_control");

            migrationBuilder.DropTable(
                name: "medicaladmin_lab_control");

            migrationBuilder.DropTable(
                name: "medicaladmin_pharmacy_control");

            migrationBuilder.DropTable(
                name: "storeadmin_material_control");

            migrationBuilder.DropTable(
                name: "storeadmin_product_control");

            migrationBuilder.DropTable(
                name: "useradmin_doctor_control");

            migrationBuilder.DropTable(
                name: "useradmin_medicaladmin_control");

            migrationBuilder.DropTable(
                name: "useradmin_patient_control");

            migrationBuilder.DropTable(
                name: "useradmin_storeadmin_control");

            migrationBuilder.DropTable(
                name: "medical_admin");

            migrationBuilder.DropTable(
                name: "store_admin");

            migrationBuilder.DropTable(
                name: "user_admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "medical_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assosiation_id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medical_admin", x => x.admin_id);
                    table.ForeignKey(
                        name: "FK_medical_admin_assosiation_branch",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "store_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assosiation_id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_admin", x => x.admin_id);
                    table.ForeignKey(
                        name: "FK_store_admin_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assosiation_id = table.Column<int>(type: "int", nullable: false),
                    admin_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    admin_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    admin_password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMIN_table", x => x.admin_id);
                    table.ForeignKey(
                        name: "FK_user_admin_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicaladmin_clinic_control",
                columns: table => new
                {
                    clinic_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicaladmin_clinic_control", x => new { x.clinic_id, x.admin_id });
                    table.ForeignKey(
                        name: "FK_medicaladmin_clinic_control_clinic",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "clinic_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicaladmin_clinic_control_medical_admin",
                        column: x => x.admin_id,
                        principalTable: "medical_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicaladmin_hospital_control",
                columns: table => new
                {
                    hospital_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicaladmin_hospital_control", x => new { x.hospital_id, x.admin_id });
                    table.ForeignKey(
                        name: "FK_medicaladmin_hospital_control_hospital_hospital_id",
                        column: x => x.hospital_id,
                        principalTable: "hospital",
                        principalColumn: "hospital_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicaladmin_hospital_control_medical_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "medical_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicaladmin_lab_control",
                columns: table => new
                {
                    lab_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicaladmin_lab_control", x => new { x.lab_id, x.admin_id });
                    table.ForeignKey(
                        name: "FK_medicaladmin_lab_control_lab_lab_id",
                        column: x => x.lab_id,
                        principalTable: "lab",
                        principalColumn: "lab_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicaladmin_lab_control_medical_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "medical_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicaladmin_pharmacy_control",
                columns: table => new
                {
                    pharmacy_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicaladmin_pharmacy_control", x => new { x.pharmacy_id, x.admin_id });
                    table.ForeignKey(
                        name: "FK_medicaladmin_pharmacy_control_medical_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "medical_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicaladmin_pharmacy_control_pharmacy_pharmacy_id",
                        column: x => x.pharmacy_id,
                        principalTable: "pharmacy",
                        principalColumn: "pharmacy_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "storeadmin_material_control",
                columns: table => new
                {
                    material_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storeadmin_material_control", x => new { x.material_id, x.admin_id });
                    table.ForeignKey(
                        name: "FK_storeadmin_material_control_raw_material",
                        column: x => x.material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storeadmin_material_control_store_admin",
                        column: x => x.admin_id,
                        principalTable: "store_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "storeadmin_product_control",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storeadmin_product_control", x => new { x.product_id, x.admin_id });
                    table.ForeignKey(
                        name: "FK_storeadmin_product_control_product",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storeadmin_product_control_store_admin",
                        column: x => x.admin_id,
                        principalTable: "store_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "useradmin_doctor_control",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_useradmin_doctor_control", x => new { x.admin_id, x.doctor_id });
                    table.ForeignKey(
                        name: "FK_useradmin_doctor_control_doctor",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_useradmin_doctor_control_user_admin",
                        column: x => x.admin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "useradmin_medicaladmin_control",
                columns: table => new
                {
                    Uadmin_id = table.Column<int>(type: "int", nullable: false),
                    Madmin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_useradmin_medicaladmin_control", x => new { x.Uadmin_id, x.Madmin_id });
                    table.ForeignKey(
                        name: "FK_useradmin_medicaladmin_control_medical_admin",
                        column: x => x.Madmin_id,
                        principalTable: "medical_admin",
                        principalColumn: "admin_id");
                    table.ForeignKey(
                        name: "FK_useradmin_medicaladmin_control_user_admin",
                        column: x => x.Uadmin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id");
                });

            migrationBuilder.CreateTable(
                name: "useradmin_patient_control",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_useradmin_patient_control", x => new { x.admin_id, x.patient_id });
                    table.ForeignKey(
                        name: "FK_useradmin_patient_control_patient",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_useradmin_patient_control_user_admin",
                        column: x => x.admin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "useradmin_storeadmin_control",
                columns: table => new
                {
                    Uadmin_id = table.Column<int>(type: "int", nullable: false),
                    Sadmin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_useradmin_storeadmin_control", x => new { x.Uadmin_id, x.Sadmin_id });
                    table.ForeignKey(
                        name: "FK_useradmin_storeadmin_control_store_admin",
                        column: x => x.Sadmin_id,
                        principalTable: "store_admin",
                        principalColumn: "admin_id");
                    table.ForeignKey(
                        name: "FK_useradmin_storeadmin_control_user_admin",
                        column: x => x.Uadmin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_medical_admin_assosiation_id",
                table: "medical_admin",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_clinic_control_admin_id",
                table: "medicaladmin_clinic_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_hospital_control_admin_id",
                table: "medicaladmin_hospital_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_lab_control_admin_id",
                table: "medicaladmin_lab_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_pharmacy_control_admin_id",
                table: "medicaladmin_pharmacy_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_store_admin_assosiation_id",
                table: "store_admin",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_material_control_admin_id",
                table: "storeadmin_material_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_product_control_admin_id",
                table: "storeadmin_product_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_admin_assosiation_id",
                table: "user_admin",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_doctor_control_doctor_id",
                table: "useradmin_doctor_control",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_medicaladmin_control_Madmin_id",
                table: "useradmin_medicaladmin_control",
                column: "Madmin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_patient_control_patient_id",
                table: "useradmin_patient_control",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_storeadmin_control_Sadmin_id",
                table: "useradmin_storeadmin_control",
                column: "Sadmin_id");
        }
    }
}
