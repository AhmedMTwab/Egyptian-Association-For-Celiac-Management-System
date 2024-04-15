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

    [Column("Useradmin_id")]
    public int UseradminId { get; set; }

    [Column("assosiation_id")]
    public int AssosiationId { get; set; }

    [ForeignKey("UseradminId")]
    public virtual UserAdmin Admin { get; set; } = null!;

    [ForeignKey("AssosiationId")]
    public virtual AssosiationBranch Assosiation { get; set; } = null!;
}
