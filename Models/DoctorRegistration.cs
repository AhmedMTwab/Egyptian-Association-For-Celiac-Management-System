using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("doctor_registration")]
public partial class DoctorRegistration
{
    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("date")]
    public DateOnly Date { get; set; }

    [ForeignKey("DoctorId")]
    public virtual Doctor Doctor { get; set; } = null!;
}
