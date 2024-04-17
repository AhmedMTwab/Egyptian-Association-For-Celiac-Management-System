using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("UadminId", "SadminId")]
[Table("useradmin_storeadmin_control")]
public partial class UseradminStoreadminControl
{
    [Column("Uadmin_id")]
    public int UadminId { get; set; }

    [Column("Sadmin_id")]
    public int SadminId { get; set; }

    [ForeignKey("SadminId")]
    public virtual StoreAdmin Sadmin { get; set; } = null!;

    [ForeignKey("UadminId")]
    public virtual UserAdmin Uadmin { get; set; } = null!;
}
