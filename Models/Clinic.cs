using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("clinic")]
public partial class Clinic
{
    [Key]
    [Column("clinic_id")]
    public int ClinicId { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("open_time")]
    public TimeOnly OpenTime { get; set; }

    [Column("close_time")]
    public TimeOnly CloseTime { get; set; }
}
