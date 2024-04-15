using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("UadminId","MadminId")]
[Table("useradmin_medicaladmin_control")]
public partial class UseradminMedicaladminControl
{
    [Column("Uadmin_id")]
    public int UadminId { get; set; }

    [Column("Madmin_id")]
    public int MadminId { get; set; }

    [ForeignKey("MadminId")]
    public virtual MedicalAdmin Madmin { get; set; } = null!;

    [ForeignKey("UadminId")]
    public virtual UserAdmin Uadmin { get; set; } = null!;
}
