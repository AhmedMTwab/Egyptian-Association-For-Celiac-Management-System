using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("ClinicId", "AdminId")]
[Table("medicaladmin_clinic_control")]
public partial class MedicaladminClinicControl
{
    [Column("clinic_id")]
    public int ClinicId { get; set; }

    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual MedicalAdmin Admin { get; set; } = null!;

    [ForeignKey("ClinicId")]
    public virtual Clinic Clinic { get; set; } = null!;
}
