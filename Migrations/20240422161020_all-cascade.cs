using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptian_association_of_cieliac_patients.Migrations
{
    /// <inheritdoc />
    public partial class allcascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_branch_phone_assosiation_branch",
                table: "assosiation_branch_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_dises__dises",
                table: "assosiation_dises_follow");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_dises_follow_assosiation_branch",
                table: "assosiation_dises_follow");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_assosiation_branch",
                table: "assosiation_insurance_provide");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_health_insurance",
                table: "assosiation_insurance_provide");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_assosiation_discount_assosiation_branch",
                table: "clinic_assosiation_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_assosiation_discount_clinic",
                table: "clinic_assosiation_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_insurance_discount_clinic",
                table: "clinic_insurance_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_insurance_discount_health_insurance",
                table: "clinic_insurance_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_phone_clinic",
                table: "clinic_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_raw_material_dises_catogrize_dises",
                table: "dises_material_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_raw_material_dises_catogrize_raw_material",
                table: "dises_material_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_dises_product_catogrize_dises",
                table: "dises_product_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_dises_product_catogrize_product",
                table: "dises_product_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_clinic_work_clinic",
                table: "doctor_clinic_work");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_clinic_work_doctor",
                table: "doctor_clinic_work");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_medicalrecord_veiw_doctor",
                table: "doctor_medicalrecord_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_medicalrecord_veiw_medical_record",
                table: "doctor_medicalrecord_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_phone_doctor",
                table: "doctor_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_insurance_address_health_insurance",
                table: "insurance_address");

            migrationBuilder.DropForeignKey(
                name: "FK_insurance_phone_health_insurance",
                table: "insurance_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_medical_admin_assosiation_branch",
                table: "medical_admin");

            migrationBuilder.DropForeignKey(
                name: "FK_medical_record-drug_medical_record",
                table: "medical_record-drug");

            migrationBuilder.DropForeignKey(
                name: "FK_medical_record-test_medical_record",
                table: "medical_record-test");

            migrationBuilder.DropForeignKey(
                name: "FK_medicaladmin_clinic_control_clinic",
                table: "medicaladmin_clinic_control");

            migrationBuilder.DropForeignKey(
                name: "FK_medicaladmin_clinic_control_medical_admin",
                table: "medicaladmin_clinic_control");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_rawmaterial_veiw_patient",
                table: "patient_rawmaterial_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_rawmaterial_veiw_raw_material",
                table: "patient_rawmaterial_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_product",
                table: "product_image");

            migrationBuilder.DropForeignKey(
                name: "FK_rawmaterial_image_raw_material",
                table: "rawmaterial_image");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_material_control_raw_material",
                table: "storeadmin_material_control");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_material_control_store_admin",
                table: "storeadmin_material_control");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_product_control_product",
                table: "storeadmin_product_control");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_product_control_store_admin",
                table: "storeadmin_product_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_doctor_control_doctor",
                table: "useradmin_doctor_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_doctor_control_user_admin",
                table: "useradmin_doctor_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_patient_control_patient",
                table: "useradmin_patient_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_patient_control_user_admin",
                table: "useradmin_patient_control");

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_branch_phone_assosiation_branch",
                table: "assosiation_branch_phone",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_dises__dises",
                table: "assosiation_dises_follow",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_dises_follow_assosiation_branch",
                table: "assosiation_dises_follow",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_assosiation_branch",
                table: "assosiation_insurance_provide",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_health_insurance",
                table: "assosiation_insurance_provide",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_assosiation_discount_assosiation_branch",
                table: "clinic_assosiation_discount",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_assosiation_discount_clinic",
                table: "clinic_assosiation_discount",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_insurance_discount_clinic",
                table: "clinic_insurance_discount",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_insurance_discount_health_insurance",
                table: "clinic_insurance_discount",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_phone_clinic",
                table: "clinic_phone",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_raw_material_dises_catogrize_dises",
                table: "dises_material_catogrize",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_raw_material_dises_catogrize_raw_material",
                table: "dises_material_catogrize",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dises_product_catogrize_dises",
                table: "dises_product_catogrize",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dises_product_catogrize_product",
                table: "dises_product_catogrize",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_clinic_work_clinic",
                table: "doctor_clinic_work",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_clinic_work_doctor",
                table: "doctor_clinic_work",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_medicalrecord_veiw_doctor",
                table: "doctor_medicalrecord_veiw",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_medicalrecord_veiw_medical_record",
                table: "doctor_medicalrecord_veiw",
                column: "record_id",
                principalTable: "medical_record",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_phone_doctor",
                table: "doctor_phone",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_insurance_address_health_insurance",
                table: "insurance_address",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_insurance_phone_health_insurance",
                table: "insurance_phone",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medical_admin_assosiation_branch",
                table: "medical_admin",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medical_record-drug_medical_record",
                table: "medical_record-drug",
                column: "record_id",
                principalTable: "medical_record",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medical_record-test_medical_record",
                table: "medical_record-test",
                column: "record_id",
                principalTable: "medical_record",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicaladmin_clinic_control_clinic",
                table: "medicaladmin_clinic_control",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicaladmin_clinic_control_medical_admin",
                table: "medicaladmin_clinic_control",
                column: "admin_id",
                principalTable: "medical_admin",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patient_rawmaterial_veiw_patient",
                table: "patient_rawmaterial_veiw",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patient_rawmaterial_veiw_raw_material",
                table: "patient_rawmaterial_veiw",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_product",
                table: "product_image",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rawmaterial_image_raw_material",
                table: "rawmaterial_image",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_material_control_raw_material",
                table: "storeadmin_material_control",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_material_control_store_admin",
                table: "storeadmin_material_control",
                column: "admin_id",
                principalTable: "store_admin",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_product_control_product",
                table: "storeadmin_product_control",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_product_control_store_admin",
                table: "storeadmin_product_control",
                column: "admin_id",
                principalTable: "store_admin",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_doctor_control_doctor",
                table: "useradmin_doctor_control",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_doctor_control_user_admin",
                table: "useradmin_doctor_control",
                column: "admin_id",
                principalTable: "user_admin",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_patient_control_patient",
                table: "useradmin_patient_control",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_patient_control_user_admin",
                table: "useradmin_patient_control",
                column: "admin_id",
                principalTable: "user_admin",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_branch_phone_assosiation_branch",
                table: "assosiation_branch_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_dises__dises",
                table: "assosiation_dises_follow");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_dises_follow_assosiation_branch",
                table: "assosiation_dises_follow");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_assosiation_branch",
                table: "assosiation_insurance_provide");

            migrationBuilder.DropForeignKey(
                name: "FK_assosiation_health_insurance",
                table: "assosiation_insurance_provide");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_assosiation_discount_assosiation_branch",
                table: "clinic_assosiation_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_assosiation_discount_clinic",
                table: "clinic_assosiation_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_insurance_discount_clinic",
                table: "clinic_insurance_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_insurance_discount_health_insurance",
                table: "clinic_insurance_discount");

            migrationBuilder.DropForeignKey(
                name: "FK_clinic_phone_clinic",
                table: "clinic_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_raw_material_dises_catogrize_dises",
                table: "dises_material_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_raw_material_dises_catogrize_raw_material",
                table: "dises_material_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_dises_product_catogrize_dises",
                table: "dises_product_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_dises_product_catogrize_product",
                table: "dises_product_catogrize");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_clinic_work_clinic",
                table: "doctor_clinic_work");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_clinic_work_doctor",
                table: "doctor_clinic_work");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_medicalrecord_veiw_doctor",
                table: "doctor_medicalrecord_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_medicalrecord_veiw_medical_record",
                table: "doctor_medicalrecord_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_phone_doctor",
                table: "doctor_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_insurance_address_health_insurance",
                table: "insurance_address");

            migrationBuilder.DropForeignKey(
                name: "FK_insurance_phone_health_insurance",
                table: "insurance_phone");

            migrationBuilder.DropForeignKey(
                name: "FK_medical_admin_assosiation_branch",
                table: "medical_admin");

            migrationBuilder.DropForeignKey(
                name: "FK_medical_record-drug_medical_record",
                table: "medical_record-drug");

            migrationBuilder.DropForeignKey(
                name: "FK_medical_record-test_medical_record",
                table: "medical_record-test");

            migrationBuilder.DropForeignKey(
                name: "FK_medicaladmin_clinic_control_clinic",
                table: "medicaladmin_clinic_control");

            migrationBuilder.DropForeignKey(
                name: "FK_medicaladmin_clinic_control_medical_admin",
                table: "medicaladmin_clinic_control");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_rawmaterial_veiw_patient",
                table: "patient_rawmaterial_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_patient_rawmaterial_veiw_raw_material",
                table: "patient_rawmaterial_veiw");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_product",
                table: "product_image");

            migrationBuilder.DropForeignKey(
                name: "FK_rawmaterial_image_raw_material",
                table: "rawmaterial_image");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_material_control_raw_material",
                table: "storeadmin_material_control");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_material_control_store_admin",
                table: "storeadmin_material_control");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_product_control_product",
                table: "storeadmin_product_control");

            migrationBuilder.DropForeignKey(
                name: "FK_storeadmin_product_control_store_admin",
                table: "storeadmin_product_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_doctor_control_doctor",
                table: "useradmin_doctor_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_doctor_control_user_admin",
                table: "useradmin_doctor_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_patient_control_patient",
                table: "useradmin_patient_control");

            migrationBuilder.DropForeignKey(
                name: "FK_useradmin_patient_control_user_admin",
                table: "useradmin_patient_control");

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_branch_phone_assosiation_branch",
                table: "assosiation_branch_phone",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_dises__dises",
                table: "assosiation_dises_follow",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id");

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_dises_follow_assosiation_branch",
                table: "assosiation_dises_follow",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_assosiation_branch",
                table: "assosiation_insurance_provide",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_assosiation_health_insurance",
                table: "assosiation_insurance_provide",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_assosiation_discount_assosiation_branch",
                table: "clinic_assosiation_discount",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_assosiation_discount_clinic",
                table: "clinic_assosiation_discount",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_insurance_discount_clinic",
                table: "clinic_insurance_discount",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_insurance_discount_health_insurance",
                table: "clinic_insurance_discount",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinic_phone_clinic",
                table: "clinic_phone",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id");

            migrationBuilder.AddForeignKey(
                name: "FK_raw_material_dises_catogrize_dises",
                table: "dises_material_catogrize",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id");

            migrationBuilder.AddForeignKey(
                name: "FK_raw_material_dises_catogrize_raw_material",
                table: "dises_material_catogrize",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id");

            migrationBuilder.AddForeignKey(
                name: "FK_dises_product_catogrize_dises",
                table: "dises_product_catogrize",
                column: "dises_id",
                principalTable: "dises",
                principalColumn: "dises_id");

            migrationBuilder.AddForeignKey(
                name: "FK_dises_product_catogrize_product",
                table: "dises_product_catogrize",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_clinic_work_clinic",
                table: "doctor_clinic_work",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_clinic_work_doctor",
                table: "doctor_clinic_work",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_medicalrecord_veiw_doctor",
                table: "doctor_medicalrecord_veiw",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_medicalrecord_veiw_medical_record",
                table: "doctor_medicalrecord_veiw",
                column: "record_id",
                principalTable: "medical_record",
                principalColumn: "record_id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_phone_doctor",
                table: "doctor_phone",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_insurance_address_health_insurance",
                table: "insurance_address",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id");

            migrationBuilder.AddForeignKey(
                name: "FK_insurance_phone_health_insurance",
                table: "insurance_phone",
                column: "insurance_id",
                principalTable: "health_insurance",
                principalColumn: "insurance_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medical_admin_assosiation_branch",
                table: "medical_admin",
                column: "assosiation_id",
                principalTable: "assosiation_branch",
                principalColumn: "assosiation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medical_record-drug_medical_record",
                table: "medical_record-drug",
                column: "record_id",
                principalTable: "medical_record",
                principalColumn: "record_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medical_record-test_medical_record",
                table: "medical_record-test",
                column: "record_id",
                principalTable: "medical_record",
                principalColumn: "record_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicaladmin_clinic_control_clinic",
                table: "medicaladmin_clinic_control",
                column: "clinic_id",
                principalTable: "clinic",
                principalColumn: "clinic_id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicaladmin_clinic_control_medical_admin",
                table: "medicaladmin_clinic_control",
                column: "admin_id",
                principalTable: "medical_admin",
                principalColumn: "admin_id");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_rawmaterial_veiw_patient",
                table: "patient_rawmaterial_veiw",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_patient_rawmaterial_veiw_raw_material",
                table: "patient_rawmaterial_veiw",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_product",
                table: "product_image",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_rawmaterial_image_raw_material",
                table: "rawmaterial_image",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id");

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_material_control_raw_material",
                table: "storeadmin_material_control",
                column: "material_id",
                principalTable: "raw_material",
                principalColumn: "material_id");

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_material_control_store_admin",
                table: "storeadmin_material_control",
                column: "admin_id",
                principalTable: "store_admin",
                principalColumn: "admin_id");

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_product_control_product",
                table: "storeadmin_product_control",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_storeadmin_product_control_store_admin",
                table: "storeadmin_product_control",
                column: "admin_id",
                principalTable: "store_admin",
                principalColumn: "admin_id");

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_doctor_control_doctor",
                table: "useradmin_doctor_control",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "doctor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_doctor_control_user_admin",
                table: "useradmin_doctor_control",
                column: "admin_id",
                principalTable: "user_admin",
                principalColumn: "admin_id");

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_patient_control_patient",
                table: "useradmin_patient_control",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_useradmin_patient_control_user_admin",
                table: "useradmin_patient_control",
                column: "admin_id",
                principalTable: "user_admin",
                principalColumn: "admin_id");
        }
    }
}
