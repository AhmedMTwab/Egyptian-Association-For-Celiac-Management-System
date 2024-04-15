using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("user_admin")]
public partial class UserAdmin
{
    [Key]
    [Column("admin_id")]
    public int AdminId { get; set; }

    [Column("admin_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdminName { get; set; } = null!;

    [Column("admin_email")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdminEmail { get; set; } = null!;

    [Column("admin_password")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdminPassword { get; set; } = null!;

    [Column("assosiation_id")]
    public int AssosiationId { get; set; }

    [InverseProperty("Admin")]
    public virtual ICollection<UseradminDoctorControl> doctors { get; set; } = new List<UseradminDoctorControl>();
    [InverseProperty("Uadmin")]
    public virtual ICollection<UseradminMedicaladminControl> Madmins { get; set; } = new List<UseradminMedicaladminControl>();
}
