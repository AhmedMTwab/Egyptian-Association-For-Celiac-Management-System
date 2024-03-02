using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("patient_phone")]
public partial class PatientPhone
{
    [Column("phone_number")]
    public int? PhoneNumber { get; set; }

    [Column("patient_id")]
    public int? PatientId { get; set; }

    [ForeignKey("PatientId")]
    public virtual Patient? Patient { get; set; }
}
