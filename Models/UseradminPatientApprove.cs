using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("useradmin_patient_approve")]
public partial class UseradminPatientApprove
{
    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual UserAdmin Admin { get; set; } = null!;
}
