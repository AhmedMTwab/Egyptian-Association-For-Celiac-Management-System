using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("PharmacyId", "AdminId")]
[Table("medicaladmin_pharmacy_control")]
public partial class MedicalAdminPharmacyControl
{
    [Column("pharmacy_id")]
    public int PharmacyId { get; set; }

    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual MedicalAdmin Admin { get; set; } = null!;

    [ForeignKey("PharmacyId")]
    public virtual Pharmacy Pharmacy { get; set; } = null!;
}
