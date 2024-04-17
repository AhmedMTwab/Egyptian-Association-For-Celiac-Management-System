using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("AdminId", "DoctorId")]
[Table("useradmin_doctor_control")]
public partial class UseradminDoctorControl
{
    [Column("admin_id")]
    public int AdminId { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [ForeignKey("AdminId")]
    public virtual UserAdmin Uadmin { get; set; } = null!;

    [ForeignKey("DoctorId")]
    public virtual Doctor Doctor { get; set; } = null!;
}
