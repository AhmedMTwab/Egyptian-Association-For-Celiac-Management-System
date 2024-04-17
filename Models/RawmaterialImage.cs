using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[PrimaryKey("MaterialImage", "MaterialId")]
[Table("rawmaterial_image")]
public partial class RawmaterialImage
{
    [Column("material_image")]
    public string MaterialImage { get; set; } = null!;

    [Column("material_id")]
    public int MaterialId { get; set; }

    [ForeignKey("MaterialId")]
    public virtual RawMaterial Material { get; set; } = null!;
}
