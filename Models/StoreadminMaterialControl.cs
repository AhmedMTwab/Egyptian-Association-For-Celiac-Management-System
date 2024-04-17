using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("MaterialId", "AdminId")]
[Table("storeadmin_material_control")]
public partial class StoreadminMaterialControl
{
    [Column("material_id")]
    public int MaterialId { get; set; }

    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual StoreAdmin Sadmin { get; set; } = null!;

    [ForeignKey("MaterialId")]
    public virtual RawMaterial Material { get; set; } = null!;
}
