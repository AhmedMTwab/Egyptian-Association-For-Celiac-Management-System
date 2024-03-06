using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("patient_registration")]
public partial class PatientRegistration
{
    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("patient_id")]
    public int PatientId { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("date")]
    public DateOnly Date { get; set; }

    [ForeignKey("PatientId")]
    public virtual Patient Patient { get; set; } = null!;
}
