﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("medical_record-test")]
public partial class MedicalRecordTest
{
    [Column("test")]
    [MaxLength(50)]
    public byte[] Test { get; set; } = null!;

    [Column("record_id")]
    public int RecordId { get; set; }

    [ForeignKey("RecordId")]
    public virtual MedicalRecord Record { get; set; } = null!;
}
