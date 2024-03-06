﻿using System;
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

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartMaterialAdd> CartMaterialAdds { get; set; }

    public virtual DbSet<CartProductAdd> CartProductAdds { get; set; }

    public virtual DbSet<Clinic> Clinics { get; set; }

    public virtual DbSet<ClinicAssosiationDiscount> ClinicAssosiationDiscounts { get; set; }

    public virtual DbSet<ClinicInsuranceDiscount> ClinicInsuranceDiscounts { get; set; }

    public virtual DbSet<ClinicPhone> ClinicPhones { get; set; }
    public virtual DbSet<ClinicAddress> ClinicAddresses { get; set; }

    public virtual DbSet<Dise> Dises { get; set; }

    public virtual DbSet<DisesMaterialCatogrize> DisesMaterialCatogrizes { get; set; }

    public virtual DbSet<DisesProductCatogrize> DisesProductCatogrizes { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorClinicWork> DoctorClinicWorks { get; set; }

    public virtual DbSet<DoctorMedicalrecordVeiw> DoctorMedicalrecordVeiws { get; set; }

    public virtual DbSet<DoctorPhone> DoctorPhones { get; set; }

    public virtual DbSet<DoctorRegistration> DoctorRegestraions { get; set; }

    public virtual DbSet<HealthInsurance> HealthInsurances { get; set; }

    public virtual DbSet<InsuranceAddress> InsuranceAddresses { get; set; }

    public virtual DbSet<InsurancePhone> InsurancePhones { get; set; }

    public virtual DbSet<MedicalAdmin> MedicalAdmins { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<MedicalRecordDrug> MedicalRecordDrugs { get; set; }

    public virtual DbSet<MedicalRecordTest> MedicalRecordTests { get; set; }

    public virtual DbSet<MedicaladminClinicControl> MedicaladminClinicControls { get; set; }

    public virtual DbSet<MedicalAdminRegistration> MedicaladminRegesterations { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientAddress> PatientAddresses { get; set; }

    public virtual DbSet<PatientAssosiationParticpate> PatientAssosiationParticpates { get; set; }

    public virtual DbSet<PatientDisesHave> PatientDisesHaves { get; set; }

    public virtual DbSet<PatientPhone> PatientPhones { get; set; }

    public virtual DbSet<PatientProductView> PatientProductViews { get; set; }

    public virtual DbSet<PatientRawmaterialVeiw> PatientRawmaterialVeiws { get; set; }

    public virtual DbSet<PatientRegistration> PatientRegistritions { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<RawMaterial> RawMaterials { get; set; }

    public virtual DbSet<RawmaterialImage> RawmaterialImages { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<StoreAdmin> StoreAdmins { get; set; }

    public virtual DbSet<StoreadminMaterialControl> StoreadminMaterialControls { get; set; }

    public virtual DbSet<StoreadminProductControl> StoreadminProductControls { get; set; }

    public virtual DbSet<StoreAdminRegistration> StoreadminRegestriations { get; set; }

    public virtual DbSet<UserAdmin> UserAdmins { get; set; }

    public virtual DbSet<UseradminDoctorControl> UseradminDoctorControls { get; set; }

    public virtual DbSet<UseradminMedicaladminControl> UseradminMedicaladminControls { get; set; }

    public virtual DbSet<UseradminPatientApprove> UseradminPatientApproves { get; set; }

    public virtual DbSet<UseradminPatientControl> UseradminPatientControls { get; set; }

    public virtual DbSet<UseradminStoreadminControl> UseradminStoreadminControls { get; set; }
    public virtual DbSet<Lab> Labs { get; set; }
    public virtual DbSet<LabPhone> LabPhones { get; set; }
    public virtual DbSet<LabAddress> LabAddresses { get; set; }
    public virtual DbSet<LabType> LabTypes { get; set; }
    public virtual DbSet<LabAssociationDiscount> LabAssociationDiscounts { get; set; }
    public virtual DbSet<MedicalAdminLabControl> MedicalAdminLabControls { get; set; }
    public virtual DbSet<LabInsuranceDiscount> LabInsuranceDiscounts { get; set; }
    public virtual DbSet<Pharmacy> Pharmacies { get; set; }
    public virtual DbSet<PharmacyPhone> PharmacyPhones { get; set; }
    public virtual DbSet<PharmacyAddress> PharmacyAddresses { get; set; }
    public virtual DbSet<PharmacyAssociationDiscount> PharmacyAssociationDiscounts { get; set; }
    public virtual DbSet<MedicalAdminPharmacyControl> MedicalAdminPharmacyControls { get; set; }
    public virtual DbSet<PharmacyInsuranceDiscount> PharmacyInsuranceDiscounts { get; set; }
    public virtual DbSet<Hospital> Hospitals { get; set; }
    public virtual DbSet<HospitalPhone> HospitalPhones { get; set; }
    public virtual DbSet<HospitalAddress> HospitalAddresses { get; set; }
    public virtual DbSet<HospitalType> HospitalTypes { get; set; }
    public virtual DbSet<MedicalAdminHospitalControl> MedicalAdminHospitalControls { get; set; }
    public virtual DbSet<HospitalInsuranceDiscount> HospitalInsuranceDiscounts { get; set; }
    public virtual DbSet<UserAdminDoctorRegistrationApprove> UserAdminDoctorRegistrationApproves { get; set; }
    public virtual DbSet<UserAdminPatientRegistrationApprove> UserAdminPatientRegistrationApproves { get; set; }
    public virtual DbSet<UserAdminMedicalAdminRegistrationApprove> UserAdminMedicalAdminRegistrationApproves { get; set; }
    public virtual DbSet<UserAdminStoreAdminRegistrationApprove> UserAdminStoreAdminRegistrationApproves { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Egyptian association of cieliac patients;Trusted_Connection=True;TrustServerCertificate=True;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<AssosiationBranch>(entity =>
    //    {
    //        entity.Property(e => e.AssosiationId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<AssosiationBranchPhone>(entity =>
    //    {
    //        entity.HasOne(d => d.Assosiation).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_assosiation_branch_phone_assosiation_branch");
    //    });

    //    modelBuilder.Entity<AssosiationDisesFollow>(entity =>
    //    {
    //        entity.HasOne(d => d.Assosiation).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_assosiation_dises_follow_assosiation_branch");

    //        entity.HasOne(d => d.Dises).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_assosiation_dises__dises");
    //    });

    //    modelBuilder.Entity<AssosiationInsuranceProvide>(entity =>
    //    {
    //        entity.HasOne(d => d.Assosiation).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_assosiation_assosiation_branch");

    //        entity.HasOne(d => d.Insurance).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_assosiation_health_insurance");
    //    });

    //    modelBuilder.Entity<Cart>(entity =>
    //    {
    //        entity.Property(e => e.OrderId).ValueGeneratedNever();

    //        entity.HasOne(d => d.Patient).WithMany(p => p.Carts)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_cart_patient");
    //    });

    //    modelBuilder.Entity<CartMaterialAdd>(entity =>
    //    {
    //        entity.HasOne(d => d.Material).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_cart_material_add_raw_material");

    //        entity.HasOne(d => d.Order).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_cart_material_add_cart");
    //    });

    //    modelBuilder.Entity<CartProductAdd>(entity =>
    //    {
    //        entity.HasOne(d => d.Order).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_cart_product_add_cart");

    //        entity.HasOne(d => d.Product).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_cart_product_add_product");
    //    });

    //    modelBuilder.Entity<Clinic>(entity =>
    //    {
    //        entity.Property(e => e.ClinicId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<ClinicAssosiationDiscount>(entity =>
    //    {
    //        entity.HasOne(d => d.Assosiation).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_clinic_assosiation_discount_assosiation_branch");

    //        entity.HasOne(d => d.Clinic).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_clinic_assosiation_discount_clinic");
    //    });

    //    modelBuilder.Entity<ClinicInsuranceDiscount>(entity =>
    //    {
    //        entity.HasOne(d => d.Clinic).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_clinic_insurance_discount_clinic");

    //        entity.HasOne(d => d.Insurance).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_clinic_insurance_discount_health_insurance");
    //    });

    //    modelBuilder.Entity<ClinicPhone>(entity =>
    //    {
    //        entity.HasOne(d => d.Clinic).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_clinic_phone_clinic");
    //    });

    //    modelBuilder.Entity<Dise>(entity =>
    //    {
    //        entity.Property(e => e.DisesId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<DisesMaterialCatogrize>(entity =>
    //    {
    //        entity.HasOne(d => d.Dises).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_raw_material_dises_catogrize_dises");

    //        entity.HasOne(d => d.Material).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_raw_material_dises_catogrize_raw_material");
    //    });

    //    modelBuilder.Entity<DisesProductCatogrize>(entity =>
    //    {
    //        entity.HasOne(d => d.Dises).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_dises_product_catogrize_dises");

    //        entity.HasOne(d => d.Product).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_dises_product_catogrize_product");
    //    });

    //    modelBuilder.Entity<Doctor>(entity =>
    //    {
    //        entity.Property(e => e.DoctorId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<DoctorClinicWork>(entity =>
    //    {
    //        entity.HasOne(d => d.Clinic).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_doctor_clinic_work_clinic");

    //        entity.HasOne(d => d.Doctor).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_doctor_clinic_work_doctor");
    //    });

    //    modelBuilder.Entity<DoctorMedicalrecordVeiw>(entity =>
    //    {
    //        entity.HasOne(d => d.Doctor).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_doctor_medicalrecord_veiw_doctor");

    //        entity.HasOne(d => d.Record).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_doctor_medicalrecord_veiw_medical_record");
    //    });

    //    modelBuilder.Entity<DoctorPhone>(entity =>
    //    {
    //        entity.HasOne(d => d.Doctor).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_doctor_phone_doctor");
    //    });

    //    modelBuilder.Entity<DoctorRegestraion>(entity =>
    //    {
    //        entity.HasOne(d => d.Doctor).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_doctor_regestraion_doctor");
    //    });

    //    modelBuilder.Entity<HealthInsurance>(entity =>
    //    {
    //        entity.Property(e => e.InsuranceId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<InsuranceAddress>(entity =>
    //    {
    //        entity.HasOne(d => d.Insurance).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_insurance_address_health_insurance");
    //    });

    //    modelBuilder.Entity<InsurancePhone>(entity =>
    //    {
    //        entity.HasOne(d => d.Insurance).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_insurance_phone_health_insurance");
    //    });

    //    modelBuilder.Entity<MedicalAdmin>(entity =>
    //    {
    //        entity.Property(e => e.AdminId).ValueGeneratedNever();

    //        entity.HasOne(d => d.Assosiation).WithMany(p => p.MedicalAdmins)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_medical_admin_assosiation_branch");
    //    });

    //    modelBuilder.Entity<MedicalRecord>(entity =>
    //    {
    //        entity.Property(e => e.RecordId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<MedicalRecordDrug>(entity =>
    //    {
    //        entity.HasOne(d => d.Record).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_medical_record-drug_medical_record");
    //    });

    //    modelBuilder.Entity<MedicalRecordTest>(entity =>
    //    {
    //        entity.HasOne(d => d.Record).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_medical_record-test_medical_record");
    //    });

    //    modelBuilder.Entity<MedicaladminClinicControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_medicaladmin_clinic_control_medical_admin");

    //        entity.HasOne(d => d.Clinic).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_medicaladmin_clinic_control_clinic");
    //    });

    //    modelBuilder.Entity<Patient>(entity =>
    //    {
    //        entity.Property(e => e.PatientId).ValueGeneratedNever();
    //        entity.Property(e => e.PatientBloodtype).IsFixedLength();
    //    });

    //    modelBuilder.Entity<PatientAddress>(entity =>
    //    {
    //        entity.HasOne(d => d.Patient).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_address_patient");
    //    });

    //    modelBuilder.Entity<PatientAssosiationParticpate>(entity =>
    //    {
    //        entity.HasOne(d => d.Assosiation).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_assosiation_particpate_assosiation_branch");

    //        entity.HasOne(d => d.Patient).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_assosiation_particpate_patient");
    //    });

    //    modelBuilder.Entity<PatientDisesHave>(entity =>
    //    {
    //        entity.HasOne(d => d.Dises).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_dises-have_dises");

    //        entity.HasOne(d => d.Patient).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_dises-have_patient");
    //    });

    //    modelBuilder.Entity<PatientPhone>(entity =>
    //    {
    //        entity.HasOne(d => d.Patient).WithMany().HasConstraintName("FK_patient_phone_patient");
    //    });

    //    modelBuilder.Entity<PatientProductView>(entity =>
    //    {
    //        entity.HasOne(d => d.Patient).WithMany().HasConstraintName("FK_patient_product_view_patient");

    //        entity.HasOne(d => d.Product).WithMany().HasConstraintName("FK_patient_product_view_product");
    //    });

    //    modelBuilder.Entity<PatientRawmaterialVeiw>(entity =>
    //    {
    //        entity.HasOne(d => d.Material).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_rawmaterial_veiw_raw_material");

    //        entity.HasOne(d => d.Patient).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_rawmaterial_veiw_patient");
    //    });

    //    modelBuilder.Entity<PatientRegistrition>(entity =>
    //    {
    //        entity.HasOne(d => d.Patient).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_patient_registrition_patient");
    //    });

    //    modelBuilder.Entity<Payment>(entity =>
    //    {
    //        entity.Property(e => e.PaymentId).ValueGeneratedNever();
    //        entity.Property(e => e.PaymentType).IsFixedLength();
    //    });

    //    modelBuilder.Entity<Product>(entity =>
    //    {
    //        entity.Property(e => e.ProductId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<ProductImage>(entity =>
    //    {
    //        entity.HasOne(d => d.Product).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_product_image_product");
    //    });

    //    modelBuilder.Entity<RawMaterial>(entity =>
    //    {
    //        entity.Property(e => e.MaterialId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<RawmaterialImage>(entity =>
    //    {
    //        entity.HasOne(d => d.Material).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_rawmaterial_image_raw_material");
    //    });

    //    modelBuilder.Entity<Reservation>(entity =>
    //    {
    //        entity.Property(e => e.ReservationId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<StoreAdmin>(entity =>
    //    {
    //        entity.Property(e => e.AdminId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<StoreadminMaterialControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_storeadmin_material_control_store_admin");

    //        entity.HasOne(d => d.Material).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_storeadmin_material_control_raw_material");
    //    });

    //    modelBuilder.Entity<StoreadminProductControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_storeadmin_product_control_store_admin");

    //        entity.HasOne(d => d.Product).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_storeadmin_product_control_product");
    //    });

    //    modelBuilder.Entity<StoreadminRegestriation>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_storeadmin_regestriation_store_admin");
    //    });

    //    modelBuilder.Entity<UserAdmin>(entity =>
    //    {
    //        entity.HasKey(e => e.AdminId).HasName("PK_ADMIN_table");

    //        entity.Property(e => e.AdminId).ValueGeneratedNever();
    //    });

    //    modelBuilder.Entity<UseradminDoctorControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_doctor_control_user_admin");

    //        entity.HasOne(d => d.Doctor).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_doctor_control_doctor");
    //    });

    //    modelBuilder.Entity<UseradminMedicaladminControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Madmin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_medicaladmin_control_medical_admin");

    //        entity.HasOne(d => d.Uadmin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_medicaladmin_control_user_admin");
    //    });

    //    modelBuilder.Entity<UseradminPatientApprove>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_patient_approve_user_admin");
    //    });

    //    modelBuilder.Entity<UseradminPatientControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Admin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_patient_control_user_admin");

    //        entity.HasOne(d => d.Patient).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_patient_control_patient");
    //    });

    //    modelBuilder.Entity<UseradminStoreadminControl>(entity =>
    //    {
    //        entity.HasOne(d => d.Sadmin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_storeadmin_control_store_admin");

    //        entity.HasOne(d => d.Uadmin).WithMany()
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_useradmin_storeadmin_control_user_admin");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
