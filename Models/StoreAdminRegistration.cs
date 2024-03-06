using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("storeadmin_registraation")]
public partial class StoreAdminRegistration
{
    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("admin_id")]
    public int AdminId { get; set; }

    [Column("password")]
    public int Password { get; set; }

    [Column("date")]
    public DateOnly Date { get; set; }

    [ForeignKey("AdminId")]
    public virtual StoreAdmin Admin { get; set; } = null!;
}
