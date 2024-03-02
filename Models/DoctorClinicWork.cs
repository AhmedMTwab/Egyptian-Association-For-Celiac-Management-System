using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("doctor_clinic_work")]
public partial class DoctorClinicWork
{
    [Column("clinic_id")]
    public int ClinicId { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [ForeignKey("ClinicId")]
    public virtual Clinic Clinic { get; set; } = null!;

    [ForeignKey("DoctorId")]
    public virtual Doctor Doctor { get; set; } = null!;
}
