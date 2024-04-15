using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("HospitalId", "AdminId")]
[Table("medicaladmin_hospital_control")]
public partial class MedicalAdminHospitalControl
{
    [Column("hospital_id")]
    public int HospitalId { get; set; }

    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual MedicalAdmin Admin { get; set; } = null!;

    [ForeignKey("HospitalId")]
    public virtual Hospital Hospital { get; set; } = null!;
}
