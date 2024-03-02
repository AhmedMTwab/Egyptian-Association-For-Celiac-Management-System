using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assosiation_branch",
                columns: table => new
                {
                    assosiation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    open_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    close_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assosiation_branch", x => x.assosiation_id);
                });

            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    clinic_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    open_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    close_time = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic", x => x.clinic_id);
                });

            migrationBuilder.CreateTable(
                name: "dises",
                columns: table => new
                {
                    dises_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dises", x => x.dises_id);
                });

            migrationBuilder.CreateTable(
                name: "doctor",
                columns: table => new
                {
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    major = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    arrive_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    leave_time = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor", x => x.doctor_id);
                });

            migrationBuilder.CreateTable(
                name: "health_insurance",
                columns: table => new
                {
                    insurance_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LicenseCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_health_insurance", x => x.insurance_id);
                });

            migrationBuilder.CreateTable(
                name: "medical_record",
                columns: table => new
                {
                    record_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: true),
                    dises_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medical_record", x => x.record_id);
                });

            migrationBuilder.CreateTable(
                name: "medicaladmin_regesteration",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patient_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    patient_bloodtype = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    SSN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.patient_id);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    total_paid = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.payment_id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "raw_material",
                columns: table => new
                {
                    material_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raw_material", x => x.material_id);
                });

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reservation_date = table.Column<DateOnly>(type: "date", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    reservation_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    appointment_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    book_date = table.Column<DateOnly>(type: "date", nullable: false),
                    book_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    clinic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation", x => x.reservation_id);
                });

            migrationBuilder.CreateTable(
                name: "store_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_admin", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "user_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admin_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    admin_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    admin_password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_admin", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "assosiation_branch_phone",
                columns: table => new
                {
                    phone_number = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_assosiation_branch_phone_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medical_admin", x => x.admin_id);
                    table.ForeignKey(
                        name: "FK_medical_admin_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clinic_assosiation_discount",
                columns: table => new
                {
                    clinic_id = table.Column<int>(type: "int", nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false),
                    discount_precentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_clinic_assosiation_discount_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clinic_assosiation_discount_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "clinic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clinic_phone",
                columns: table => new
                {
                    phone_number = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    clinic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_clinic_phone_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "clinic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assosiation_dises_follow",
                columns: table => new
                {
                    dises_id = table.Column<int>(type: "int", nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_assosiation_dises_follow_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_assosiation_dises_follow_dises_dises_id",
                        column: x => x.dises_id,
                        principalTable: "dises",
                        principalColumn: "dises_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doctor_clinic_work",
                columns: table => new
                {
                    clinic_id = table.Column<int>(type: "int", nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_doctor_clinic_work_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "clinic_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doctor_clinic_work_doctor_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doctor_phone",
                columns: table => new
                {
                    phone_number = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_doctor_phone_doctor_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doctor_regestraion",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_doctor_regestraion_doctor_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assosiation_insurance_provide",
                columns: table => new
                {
                    assosiation_id = table.Column<int>(type: "int", nullable: false),
                    insurance_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_assosiation_insurance_provide_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_assosiation_insurance_provide_health_insurance_insurance_id",
                        column: x => x.insurance_id,
                        principalTable: "health_insurance",
                        principalColumn: "insurance_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clinic_insurance_discount",
                columns: table => new
                {
                    clinic_id = table.Column<int>(type: "int", nullable: false),
                    insurance_id = table.Column<int>(type: "int", nullable: false),
                    discount_precentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_clinic_insurance_discount_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "clinic_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clinic_insurance_discount_health_insurance_insurance_id",
                        column: x => x.insurance_id,
                        principalTable: "health_insurance",
                        principalColumn: "insurance_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "insurance_address",
                columns: table => new
                {
                    address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    insurance_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_insurance_address_health_insurance_insurance_id",
                        column: x => x.insurance_id,
                        principalTable: "health_insurance",
                        principalColumn: "insurance_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "insurance_phone",
                columns: table => new
                {
                    phone_number = table.Column<int>(type: "int", nullable: false),
                    insurance_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_insurance_phone_health_insurance_insurance_id",
                        column: x => x.insurance_id,
                        principalTable: "health_insurance",
                        principalColumn: "insurance_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doctor_medicalrecord_veiw",
                columns: table => new
                {
                    record_id = table.Column<int>(type: "int", nullable: false),
                    doctor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_doctor_medicalrecord_veiw_doctor_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doctor_medicalrecord_veiw_medical_record_record_id",
                        column: x => x.record_id,
                        principalTable: "medical_record",
                        principalColumn: "record_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_record-drug",
                columns: table => new
                {
                    drug = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    record_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_medical_record-drug_medical_record_record_id",
                        column: x => x.record_id,
                        principalTable: "medical_record",
                        principalColumn: "record_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_record-test",
                columns: table => new
                {
                    test = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: false),
                    record_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_medical_record-test_medical_record_record_id",
                        column: x => x.record_id,
                        principalTable: "medical_record",
                        principalColumn: "record_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cart",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_date = table.Column<DateOnly>(type: "date", nullable: false),
                    order_details = table.Column<string>(type: "text", nullable: false),
                    total_cost = table.Column<decimal>(type: "money", nullable: false),
                    shipment_location = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    shipment_time = table.Column<TimeOnly>(type: "time", nullable: false),
                    shipment_phone = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    payment_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_cart_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_address",
                columns: table => new
                {
                    address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_address_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_assosiation_particpate",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    assosiation_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_assosiation_particpate_assosiation_branch_assosiation_id",
                        column: x => x.assosiation_id,
                        principalTable: "assosiation_branch",
                        principalColumn: "assosiation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patient_assosiation_particpate_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_dises-have",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    dises_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_dises-have_dises_dises_id",
                        column: x => x.dises_id,
                        principalTable: "dises",
                        principalColumn: "dises_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patient_dises-have_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_phone",
                columns: table => new
                {
                    phone_number = table.Column<int>(type: "int", nullable: true),
                    patient_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_phone_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id");
                });

            migrationBuilder.CreateTable(
                name: "patient_registrition",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_registrition_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dises_product_catogrize",
                columns: table => new
                {
                    dises_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    catogert_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_dises_product_catogrize_dises_dises_id",
                        column: x => x.dises_id,
                        principalTable: "dises",
                        principalColumn: "dises_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dises_product_catogrize_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_product_view",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "int", nullable: true),
                    product_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_product_view_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id");
                    table.ForeignKey(
                        name: "FK_patient_product_view_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id");
                });

            migrationBuilder.CreateTable(
                name: "product_image",
                columns: table => new
                {
                    product_image = table.Column<byte[]>(type: "image", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_product_image_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dises_material_catogrize",
                columns: table => new
                {
                    dises_id = table.Column<int>(type: "int", nullable: false),
                    material_id = table.Column<int>(type: "int", nullable: false),
                    catogery_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_dises_material_catogrize_dises_dises_id",
                        column: x => x.dises_id,
                        principalTable: "dises",
                        principalColumn: "dises_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dises_material_catogrize_raw_material_material_id",
                        column: x => x.material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_rawmaterial_veiw",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "int", nullable: false),
                    material_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_patient_rawmaterial_veiw_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patient_rawmaterial_veiw_raw_material_material_id",
                        column: x => x.material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rawmaterial_image",
                columns: table => new
                {
                    material_image = table.Column<byte[]>(type: "image", nullable: false),
                    material_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_rawmaterial_image_raw_material_material_id",
                        column: x => x.material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
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
                    table.ForeignKey(
                        name: "FK_storeadmin_material_control_raw_material_material_id",
                        column: x => x.material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storeadmin_material_control_store_admin_admin_id",
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
                    table.ForeignKey(
                        name: "FK_storeadmin_product_control_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storeadmin_product_control_store_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "store_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "storeadmin_regestriation",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    admin_id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_storeadmin_regestriation_store_admin_admin_id",
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
                    table.ForeignKey(
                        name: "FK_useradmin_doctor_control_doctor_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_useradmin_doctor_control_user_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "useradmin_patient_approve",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_useradmin_patient_approve_user_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_useradmin_patient_control_patient_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "patient_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_useradmin_patient_control_user_admin_admin_id",
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
                    table.ForeignKey(
                        name: "FK_useradmin_storeadmin_control_store_admin_Sadmin_id",
                        column: x => x.Sadmin_id,
                        principalTable: "store_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_useradmin_storeadmin_control_user_admin_Uadmin_id",
                        column: x => x.Uadmin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id",
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
                    table.ForeignKey(
                        name: "FK_medicaladmin_clinic_control_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "clinic_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicaladmin_clinic_control_medical_admin_admin_id",
                        column: x => x.admin_id,
                        principalTable: "medical_admin",
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
                    table.ForeignKey(
                        name: "FK_useradmin_medicaladmin_control_medical_admin_Madmin_id",
                        column: x => x.Madmin_id,
                        principalTable: "medical_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_useradmin_medicaladmin_control_user_admin_Uadmin_id",
                        column: x => x.Uadmin_id,
                        principalTable: "user_admin",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cart_material_add",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    material_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_cart_material_add_cart_order_id",
                        column: x => x.order_id,
                        principalTable: "cart",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cart_material_add_raw_material_material_id",
                        column: x => x.material_id,
                        principalTable: "raw_material",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cart_product_add",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_cart_product_add_cart_order_id",
                        column: x => x.order_id,
                        principalTable: "cart",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cart_product_add_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_assosiation_branch_phone_assosiation_id",
                table: "assosiation_branch_phone",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_assosiation_dises_follow_assosiation_id",
                table: "assosiation_dises_follow",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_assosiation_dises_follow_dises_id",
                table: "assosiation_dises_follow",
                column: "dises_id");

            migrationBuilder.CreateIndex(
                name: "IX_assosiation_insurance_provide_assosiation_id",
                table: "assosiation_insurance_provide",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_assosiation_insurance_provide_insurance_id",
                table: "assosiation_insurance_provide",
                column: "insurance_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_patient_id",
                table: "cart",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_material_add_material_id",
                table: "cart_material_add",
                column: "material_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_material_add_order_id",
                table: "cart_material_add",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_product_add_order_id",
                table: "cart_product_add",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_product_add_product_id",
                table: "cart_product_add",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinic_assosiation_discount_assosiation_id",
                table: "clinic_assosiation_discount",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinic_assosiation_discount_clinic_id",
                table: "clinic_assosiation_discount",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinic_insurance_discount_clinic_id",
                table: "clinic_insurance_discount",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinic_insurance_discount_insurance_id",
                table: "clinic_insurance_discount",
                column: "insurance_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinic_phone_clinic_id",
                table: "clinic_phone",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_dises_material_catogrize_dises_id",
                table: "dises_material_catogrize",
                column: "dises_id");

            migrationBuilder.CreateIndex(
                name: "IX_dises_material_catogrize_material_id",
                table: "dises_material_catogrize",
                column: "material_id");

            migrationBuilder.CreateIndex(
                name: "IX_dises_product_catogrize_dises_id",
                table: "dises_product_catogrize",
                column: "dises_id");

            migrationBuilder.CreateIndex(
                name: "IX_dises_product_catogrize_product_id",
                table: "dises_product_catogrize",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_clinic_work_clinic_id",
                table: "doctor_clinic_work",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_clinic_work_doctor_id",
                table: "doctor_clinic_work",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_medicalrecord_veiw_doctor_id",
                table: "doctor_medicalrecord_veiw",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_medicalrecord_veiw_record_id",
                table: "doctor_medicalrecord_veiw",
                column: "record_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_phone_doctor_id",
                table: "doctor_phone",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_regestraion_doctor_id",
                table: "doctor_regestraion",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_insurance_address_insurance_id",
                table: "insurance_address",
                column: "insurance_id");

            migrationBuilder.CreateIndex(
                name: "IX_insurance_phone_insurance_id",
                table: "insurance_phone",
                column: "insurance_id");

            migrationBuilder.CreateIndex(
                name: "IX_medical_admin_assosiation_id",
                table: "medical_admin",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_medical_record-drug_record_id",
                table: "medical_record-drug",
                column: "record_id");

            migrationBuilder.CreateIndex(
                name: "IX_medical_record-test_record_id",
                table: "medical_record-test",
                column: "record_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_clinic_control_admin_id",
                table: "medicaladmin_clinic_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicaladmin_clinic_control_clinic_id",
                table: "medicaladmin_clinic_control",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_address_patient_id",
                table: "patient_address",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_assosiation_particpate_assosiation_id",
                table: "patient_assosiation_particpate",
                column: "assosiation_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_assosiation_particpate_patient_id",
                table: "patient_assosiation_particpate",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_dises-have_dises_id",
                table: "patient_dises-have",
                column: "dises_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_dises-have_patient_id",
                table: "patient_dises-have",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_phone_patient_id",
                table: "patient_phone",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_product_view_patient_id",
                table: "patient_product_view",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_product_view_product_id",
                table: "patient_product_view",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_rawmaterial_veiw_material_id",
                table: "patient_rawmaterial_veiw",
                column: "material_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_rawmaterial_veiw_patient_id",
                table: "patient_rawmaterial_veiw",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_patient_registrition_patient_id",
                table: "patient_registrition",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_image_product_id",
                table: "product_image",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_rawmaterial_image_material_id",
                table: "rawmaterial_image",
                column: "material_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_material_control_admin_id",
                table: "storeadmin_material_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_material_control_material_id",
                table: "storeadmin_material_control",
                column: "material_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_product_control_admin_id",
                table: "storeadmin_product_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_product_control_product_id",
                table: "storeadmin_product_control",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_storeadmin_regestriation_admin_id",
                table: "storeadmin_regestriation",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_doctor_control_admin_id",
                table: "useradmin_doctor_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_doctor_control_doctor_id",
                table: "useradmin_doctor_control",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_medicaladmin_control_Madmin_id",
                table: "useradmin_medicaladmin_control",
                column: "Madmin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_medicaladmin_control_Uadmin_id",
                table: "useradmin_medicaladmin_control",
                column: "Uadmin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_patient_approve_admin_id",
                table: "useradmin_patient_approve",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_patient_control_admin_id",
                table: "useradmin_patient_control",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_patient_control_patient_id",
                table: "useradmin_patient_control",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_storeadmin_control_Sadmin_id",
                table: "useradmin_storeadmin_control",
                column: "Sadmin_id");

            migrationBuilder.CreateIndex(
                name: "IX_useradmin_storeadmin_control_Uadmin_id",
                table: "useradmin_storeadmin_control",
                column: "Uadmin_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "assosiation_branch_phone");

            migrationBuilder.DropTable(
                name: "assosiation_dises_follow");

            migrationBuilder.DropTable(
                name: "assosiation_insurance_provide");

            migrationBuilder.DropTable(
                name: "cart_material_add");

            migrationBuilder.DropTable(
                name: "cart_product_add");

            migrationBuilder.DropTable(
                name: "clinic_assosiation_discount");

            migrationBuilder.DropTable(
                name: "clinic_insurance_discount");

            migrationBuilder.DropTable(
                name: "clinic_phone");

            migrationBuilder.DropTable(
                name: "dises_material_catogrize");

            migrationBuilder.DropTable(
                name: "dises_product_catogrize");

            migrationBuilder.DropTable(
                name: "doctor_clinic_work");

            migrationBuilder.DropTable(
                name: "doctor_medicalrecord_veiw");

            migrationBuilder.DropTable(
                name: "doctor_phone");

            migrationBuilder.DropTable(
                name: "doctor_regestraion");

            migrationBuilder.DropTable(
                name: "insurance_address");

            migrationBuilder.DropTable(
                name: "insurance_phone");

            migrationBuilder.DropTable(
                name: "medical_record-drug");

            migrationBuilder.DropTable(
                name: "medical_record-test");

            migrationBuilder.DropTable(
                name: "medicaladmin_clinic_control");

            migrationBuilder.DropTable(
                name: "medicaladmin_regesteration");

            migrationBuilder.DropTable(
                name: "patient_address");

            migrationBuilder.DropTable(
                name: "patient_assosiation_particpate");

            migrationBuilder.DropTable(
                name: "patient_dises-have");

            migrationBuilder.DropTable(
                name: "patient_phone");

            migrationBuilder.DropTable(
                name: "patient_product_view");

            migrationBuilder.DropTable(
                name: "patient_rawmaterial_veiw");

            migrationBuilder.DropTable(
                name: "patient_registrition");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "product_image");

            migrationBuilder.DropTable(
                name: "rawmaterial_image");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropTable(
                name: "storeadmin_material_control");

            migrationBuilder.DropTable(
                name: "storeadmin_product_control");

            migrationBuilder.DropTable(
                name: "storeadmin_regestriation");

            migrationBuilder.DropTable(
                name: "useradmin_doctor_control");

            migrationBuilder.DropTable(
                name: "useradmin_medicaladmin_control");

            migrationBuilder.DropTable(
                name: "useradmin_patient_approve");

            migrationBuilder.DropTable(
                name: "useradmin_patient_control");

            migrationBuilder.DropTable(
                name: "useradmin_storeadmin_control");

            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropTable(
                name: "health_insurance");

            migrationBuilder.DropTable(
                name: "medical_record");

            migrationBuilder.DropTable(
                name: "clinic");

            migrationBuilder.DropTable(
                name: "dises");

            migrationBuilder.DropTable(
                name: "raw_material");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "doctor");

            migrationBuilder.DropTable(
                name: "medical_admin");

            migrationBuilder.DropTable(
                name: "store_admin");

            migrationBuilder.DropTable(
                name: "user_admin");

            migrationBuilder.DropTable(
                name: "patient");

            migrationBuilder.DropTable(
                name: "assosiation_branch");
        }
    }
}
