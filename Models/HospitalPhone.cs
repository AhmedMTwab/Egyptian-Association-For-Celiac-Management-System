﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("PhoneNumber", "HospitalId")]
[Table("hospital_phone")]
public partial class HospitalPhone
{
    [Column("phone_number", TypeName = "numeric(18, 0)")]
    public decimal PhoneNumber { get; set; }

    [Column("hospital_id")]
    public int HospitalId { get; set; }

    [ForeignKey("HospitalId")]
    public virtual Hospital Hospital { get; set; } = null!;
}