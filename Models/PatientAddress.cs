using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("patient_address")]
public partial class PatientAddress
{
    [Column("address")]
    [StringLength(50)]
    [Unicode(false)]
    public string Address { get; set; } = null!;

    [Column("patient_id")]
    public int PatientId { get; set; }

    [ForeignKey("PatientId")]
    public virtual Patient Patient { get; set; } = null!;
}
