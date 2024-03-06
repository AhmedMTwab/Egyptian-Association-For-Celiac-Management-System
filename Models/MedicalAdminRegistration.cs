using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("medicaladmin_registration")]
public partial class MedicalAdminRegistration
{
    [Key]
    [Column("admin_id")]
    public int AdminId { get; set; }
    [Key]
    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("date")]
    public DateOnly Date { get; set; }
    [ForeignKey("AdminId")]
    public virtual MedicalAdmin MedicalAdmin { get; set; }
}
