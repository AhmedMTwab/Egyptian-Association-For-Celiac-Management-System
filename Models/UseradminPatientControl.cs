using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("AdminId", "PatientId")]
[Table("useradmin_patient_control")]
public partial class UseradminPatientControl
{
    [Column("admin_id")]
    public int AdminId { get; set; }

    [Column("patient_id")]
    public int PatientId { get; set; }

    [ForeignKey("AdminId")]
    public virtual UserAdmin Uadmin { get; set; } = null!;

    [ForeignKey("PatientId")]
    public virtual Patient Patient { get; set; } = null!;
}
