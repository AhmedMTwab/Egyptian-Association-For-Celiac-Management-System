using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("LabId","AdminId")]
[Table("medicaladmin_lab_control")]
public partial class MedicalAdminLabControl
{
    [Column("lab_id")]
    public int LabId { get; set; }

    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual MedicalAdmin Admin { get; set; } = null!;

    [ForeignKey("LabId")]
    public virtual Lab Lab { get; set; } = null!;
}
