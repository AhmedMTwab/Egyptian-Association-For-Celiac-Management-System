using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("doctor_phone")]
public partial class DoctorPhone
{
    [Column("phone_number", TypeName = "numeric(18, 0)")]
    public decimal PhoneNumber { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [ForeignKey("DoctorId")]
    public virtual Doctor Doctor { get; set; } = null!;
}
