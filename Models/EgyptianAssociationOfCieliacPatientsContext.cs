using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

public partial class EgyptianAssociationOfCieliacPatientsContext : DbContext
{
    public EgyptianAssociationOfCieliacPatientsContext()
    {
    }

    public EgyptianAssociationOfCieliacPatientsContext(DbContextOptions<EgyptianAssociationOfCieliacPatientsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssosiationBranch> AssosiationBranches { get; set; }

    public virtual DbSet<AssosiationBranchPhone> AssosiationBranchPhones { get; set; }

    public virtual DbSet<AssosiationDisesFollow> AssosiationDisesFollows { get; set; }

    public virtual DbSet<AssosiationInsuranceProvide> AssosiationInsuranceProvides { get; set; }

    public virtual DbSet<Clinic> Clinics { get; set; }

    public virtual DbSet<ClinicAssosiationDiscount> ClinicAssosiationDiscounts { get; set; }

    public virtual DbSet<ClinicInsuranceDiscount> ClinicInsuranceDiscounts { get; set; }

    public virtual DbSet<ClinicPhone> ClinicPhones { get; set; }
    public virtual DbSet<ClinicAddress> ClinicAddresses { get; set; }

    public virtual DbSet<Dises> Dises { get; set; }

    public virtual DbSet<DisesMaterialCatogrize> DisesMaterialCatogrizes { get; set; }

    public virtual DbSet<DisesProductCatogrize> DisesProductCatogrizes { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorClinicWork> DoctorClinicWorks { get; set; }

    public virtual DbSet<DoctorMedicalrecordVeiw> DoctorMedicalrecordVeiws { get; set; }

    public virtual DbSet<DoctorPhone> DoctorPhones { get; set; }


    public virtual DbSet<HealthInsurance> HealthInsurances { get; set; }

    public virtual DbSet<InsuranceAddress> InsuranceAddresses { get; set; }

    public virtual DbSet<InsurancePhone> InsurancePhones { get; set; }

    public virtual DbSet<MedicalAdmin> MedicalAdmins { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<MedicalRecordDrug> MedicalRecordDrugs { get; set; }

    public virtual DbSet<MedicalRecordTest> MedicalRecordTests { get; set; }

    public virtual DbSet<MedicaladminClinicControl> MedicaladminClinicControls { get; set; }


    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientAddress> PatientAddresses { get; set; }


    public virtual DbSet<PatientDisesHave> PatientDisesHaves { get; set; }

    public virtual DbSet<PatientPhone> PatientPhones { get; set; }

    public virtual DbSet<PatientProductView> PatientProductViews { get; set; }

    public virtual DbSet<PatientRawmaterialVeiw> PatientRawmaterialVeiws { get; set; }


    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<RawMaterial> RawMaterials { get; set; }

    public virtual DbSet<RawmaterialImage> RawmaterialImages { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<StoreAdmin> StoreAdmins { get; set; }

    public virtual DbSet<UserAdmin> UserAdmins { get; set; }

    public virtual DbSet<UseradminDoctorControl> UseradminDoctorControls { get; set; }

    public virtual DbSet<UseradminMedicaladminControl> UseradminMedicaladminControls { get; set; }

    public virtual DbSet<UseradminStoreadminControl> UseradminStoreadminControls { get; set; }

    public virtual DbSet<StoreadminMaterialControl> StoreadminMaterialControls { get; set; }

    public virtual DbSet<StoreadminProductControl> StoreadminProductControls { get; set; }

    public virtual DbSet<UseradminPatientControl> UseradminPatientControls { get; set; }
    public virtual DbSet<Lab> Labs { get; set; }
    public virtual DbSet<LabPhone> LabPhones { get; set; }
    public virtual DbSet<LabAddress> LabAddresses { get; set; }
    public virtual DbSet<LabType> LabTypes { get; set; }
    public virtual DbSet<LabAssosiationDiscount> LabAssociationDiscounts { get; set; }
    public virtual DbSet<MedicalAdminLabControl> MedicalAdminLabControls { get; set; }
    public virtual DbSet<LabInsuranceDiscount> LabInsuranceDiscounts { get; set; }
    public virtual DbSet<Pharmacy> Pharmacies { get; set; }
    public virtual DbSet<PharmacyPhone> PharmacyPhones { get; set; }
    public virtual DbSet<PharmacyAddress> PharmacyAddresses { get; set; }
    public virtual DbSet<PharmacyAssosiationDiscount> PharmacyAssociationDiscounts { get; set; }
    public virtual DbSet<MedicalAdminPharmacyControl> MedicalAdminPharmacyControls { get; set; }
    public virtual DbSet<PharmacyInsuranceDiscount> PharmacyInsuranceDiscounts { get; set; }
    public virtual DbSet<Hospital> Hospitals { get; set; }
    public virtual DbSet<HospitalPhone> HospitalPhones { get; set; }
    public virtual DbSet<HospitalAddress> HospitalAddresses { get; set; }
    public virtual DbSet<HospitalType> HospitalTypes { get; set; }
    public virtual DbSet<MedicalAdminHospitalControl> MedicalAdminHospitalControls { get; set; }
    public virtual DbSet<HospitalInsuranceDiscount> HospitalInsuranceDiscounts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {



        modelBuilder.Entity<AssosiationBranch>(entity =>
        {
            entity.Property(e => e.AssosiationId).ValueGeneratedNever();
            entity.HasMany(e => e.Patients).WithOne(e => e.Assosiation).HasForeignKey(e => e.assosiationid);
        });

        modelBuilder.Entity<AssosiationBranchPhone>(entity =>
        {
            entity.HasOne(d => d.Assosiation).WithMany(d => d.PhoneNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_assosiation_branch_phone_assosiation_branch");
        });

        modelBuilder.Entity<AssosiationDisesFollow>(entity =>
        {
            entity.HasOne(d => d.Assosiation).WithMany(d => d.Dises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_assosiation_dises_follow_assosiation_branch");

            entity.HasOne(d => d.Dises).WithMany(d => d.Branches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_assosiation_dises__dises");
        });

        modelBuilder.Entity<AssosiationInsuranceProvide>(entity =>
        {
            entity.HasOne(d => d.Assosiation).WithMany(d => d.insurances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_assosiation_assosiation_branch");

            entity.HasOne(d => d.Insurance).WithMany(d => d.AssosiationBranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_assosiation_health_insurance");
        });

        modelBuilder.Entity<Clinic>(entity =>
        {
            entity.Property(e => e.ClinicId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ClinicAssosiationDiscount>(entity =>
        {
            entity.HasOne(d => d.Assosiation).WithMany(d => d.clinics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clinic_assosiation_discount_assosiation_branch");

            entity.HasOne(d => d.Clinic).WithMany(d => d.branches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clinic_assosiation_discount_clinic");
        });

        modelBuilder.Entity<ClinicInsuranceDiscount>(entity =>
        {
            entity.HasOne(d => d.Clinic).WithMany(d => d.insurences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clinic_insurance_discount_clinic");

            entity.HasOne(d => d.Insurance).WithMany(d => d.clinics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clinic_insurance_discount_health_insurance");
        });

        modelBuilder.Entity<ClinicPhone>(entity =>
        {
            entity.HasOne(d => d.Clinic).WithMany(d => d.clinicphones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clinic_phone_clinic");
        });

        modelBuilder.Entity<Dises>(entity =>
        {
            entity.Property(e => e.DisesId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DisesMaterialCatogrize>(entity =>
        {
            entity.HasOne(d => d.Dises).WithMany(d => d.Materials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_raw_material_dises_catogrize_dises");

            entity.HasOne(d => d.Material).WithMany(d => d.dises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_raw_material_dises_catogrize_raw_material");
        });

        modelBuilder.Entity<DisesProductCatogrize>(entity =>
        {
            entity.HasOne(d => d.Dises).WithMany(d => d.Products)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dises_product_catogrize_dises");

            entity.HasOne(d => d.Product).WithMany(d => d.dises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dises_product_catogrize_product");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.Property(e => e.DoctorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DoctorClinicWork>(entity =>
        {
            entity.HasOne(d => d.Clinic).WithMany(d => d.Doctors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doctor_clinic_work_clinic");

            entity.HasOne(d => d.Doctor).WithMany(d => d.clinics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doctor_clinic_work_doctor");
        });

        modelBuilder.Entity<DoctorMedicalrecordVeiw>(entity =>
        {
            entity.HasOne(d => d.Doctor).WithMany(d => d.medicalrecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doctor_medicalrecord_veiw_doctor");

            entity.HasOne(d => d.Record).WithMany(d => d.Doctors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doctor_medicalrecord_veiw_medical_record");
        });

        modelBuilder.Entity<DoctorPhone>(entity =>
        {
            entity.HasOne(d => d.Doctor).WithMany(d => d.DoctorPhones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doctor_phone_doctor");
        });


        modelBuilder.Entity<HealthInsurance>(entity =>
        {
            entity.Property(e => e.InsuranceId).ValueGeneratedNever();
        });

        modelBuilder.Entity<InsuranceAddress>(entity =>
        {
            entity.HasOne(d => d.Insurance).WithMany(d => d.addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_insurance_address_health_insurance");
        });

        modelBuilder.Entity<InsurancePhone>(entity =>
        {
            entity.HasOne(d => d.Insurance).WithMany(d => d.PhoneNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_insurance_phone_health_insurance");
        });

        modelBuilder.Entity<MedicalAdmin>(entity =>
        {
            entity.Property(e => e.AdminId).ValueGeneratedNever();

            entity.HasOne(d => d.Assosiation).WithMany(p => p.MedicalAdmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_medical_admin_assosiation_branch");
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.Property(e => e.RecordId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MedicalRecordDrug>(entity =>
        {
            entity.HasOne(d => d.Record).WithMany(d => d.Drug)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_medical_record-drug_medical_record");
        });

        modelBuilder.Entity<MedicalRecordTest>(entity =>
        {
            entity.HasOne(d => d.Record).WithMany(d => d.Test)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_medical_record-test_medical_record");
        });

        modelBuilder.Entity<MedicaladminClinicControl>(entity =>
        {
            entity.HasOne(d => d.Admin).WithMany(d => d.clinics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_medicaladmin_clinic_control_medical_admin");

            entity.HasOne(d => d.Clinic).WithMany(d => d.admins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_medicaladmin_clinic_control_clinic");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.Property(e => e.PatientId)/*.ValueGeneratedNever()*/;
            entity.Property(e => e.PatientBloodtype).IsFixedLength();
        });

        modelBuilder.Entity<PatientAddress>(entity =>
        {
            entity.HasOne(d => d.Patient).WithMany(d => d.Addresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_patient_address_patient");
        });



        modelBuilder.Entity<PatientDisesHave>(entity =>
        {
            entity.HasOne(d => d.Dises).WithMany(d => d.patients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_patient_dises-have_dises");

            entity.HasOne(d => d.Patient).WithMany(d => d.Diseses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_patient_dises-have_patient");
        });

        modelBuilder.Entity<PatientPhone>(entity =>
        {
            entity.HasOne(d => d.Patient).WithMany(d => d.PhoneNumbers).HasConstraintName("FK_patient_phone_patient");
        });

        modelBuilder.Entity<PatientProductView>(entity =>
        {
            entity.HasOne(d => d.Patient).WithMany(d => d.products).HasConstraintName("FK_patient_product_view_patient");

            entity.HasOne(d => d.Product).WithMany(d => d.patients).HasConstraintName("FK_patient_product_view_product");
        });

        modelBuilder.Entity<PatientRawmaterialVeiw>(entity =>
        {
            entity.HasOne(d => d.Material).WithMany(d => d.patients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_patient_rawmaterial_veiw_raw_material");

            entity.HasOne(d => d.Patient).WithMany(d => d.Materials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_patient_rawmaterial_veiw_patient");
        });



        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(e => e.PaymentId).ValueGeneratedNever();
            entity.Property(e => e.PaymentType).IsFixedLength();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(d => d.Images)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_product_image_product");
        });


        modelBuilder.Entity<RawMaterial>(entity =>
        {
            entity.Property(e => e.MaterialId).ValueGeneratedNever();
        });
        modelBuilder.Entity<RawmaterialImage>(entity =>
        {
            entity.HasOne(d => d.Material).WithMany(d => d.Images)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rawmaterial_image_raw_material");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.Property(e => e.ReservationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StoreAdmin>(entity =>
        {
            entity.Property(e => e.AdminId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserAdmin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK_ADMIN_table");

            entity.Property(e => e.AdminId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UseradminDoctorControl>(entity =>
        {
            entity.HasOne(d => d.Uadmin).WithMany(d => d.doctors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_doctor_control_user_admin");

            entity.HasOne(d => d.Doctor).WithMany(d => d.Uadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_doctor_control_doctor");
        });

        modelBuilder.Entity<UseradminMedicaladminControl>(entity =>
        {
            entity.HasOne(d => d.Madmin).WithMany(d => d.Uadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_medicaladmin_control_medical_admin");

            entity.HasOne(d => d.Uadmin).WithMany(d => d.Madmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_medicaladmin_control_user_admin");
        });

        modelBuilder.Entity<StoreadminMaterialControl>(entity =>
        {
            entity.HasOne(d => d.Sadmin).WithMany(d => d.Materials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storeadmin_material_control_store_admin");

            entity.HasOne(d => d.Material).WithMany(d => d.Sadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storeadmin_material_control_raw_material");
        });

        modelBuilder.Entity<StoreadminProductControl>(entity =>
        {
            entity.HasOne(d => d.Sadmin).WithMany(d => d.Products)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storeadmin_product_control_store_admin");

            entity.HasOne(d => d.Product).WithMany(d => d.Sadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_storeadmin_product_control_product");
        });

        modelBuilder.Entity<UseradminStoreadminControl>(entity =>
        {
            entity.HasOne(d => d.Sadmin).WithMany(d => d.Uadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_storeadmin_control_store_admin");

            entity.HasOne(d => d.Uadmin).WithMany(d => d.Sadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_storeadmin_control_user_admin");
        });

        modelBuilder.Entity<UseradminPatientControl>(entity =>
        {
            entity.HasOne(d => d.Uadmin).WithMany(d => d.Patient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_patient_control_user_admin");

            entity.HasOne(d => d.Patient).WithMany(d => d.Uadmins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_useradmin_patient_control_patient");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).ValueGeneratedNever();

            entity.HasOne(d => d.Patient).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cart_patient");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
