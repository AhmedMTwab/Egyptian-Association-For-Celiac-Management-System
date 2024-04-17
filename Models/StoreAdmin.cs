using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("store_admin")]
public partial class StoreAdmin
{
    [Key]
    [Column("admin_id")]
    public int AdminId { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("assosiation_id")]
    public int AssosiationId { get; set; }

    [ForeignKey("AssosiationId")]
    public virtual AssosiationBranch Assosiation { get; set; } = null!;

    [InverseProperty("Sadmin")]
    public virtual ICollection<UseradminStoreadminControl> Uadmins { get; set; } = new List<UseradminStoreadminControl>();

    [InverseProperty("Sadmin")]
    public virtual ICollection<StoreadminProductControl> Products { get; set; } = new List<StoreadminProductControl>();

    [InverseProperty("Sadmin")]
    public virtual ICollection<StoreadminMaterialControl> Materials { get; set; } = new List<StoreadminMaterialControl>();
}
