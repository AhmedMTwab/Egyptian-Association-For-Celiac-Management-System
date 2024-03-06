using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("pharmacy_phone")]
public partial class PharmacyPhone
{
    [Column("phone_number", TypeName = "numeric(18, 0)")]
    public decimal PhoneNumber { get; set; }

    [Column("pharmacy_id")]
    public int PharmacyId { get; set; }

    [ForeignKey("PharmacyId")]
    public virtual Pharmacy Pharmacy { get; set; } = null!;
}