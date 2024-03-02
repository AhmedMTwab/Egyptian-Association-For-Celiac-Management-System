using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("raw_material")]
public partial class RawMaterial
{
    [Key]
    [Column("material_id")]
    public int MaterialId { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("details", TypeName = "text")]
    public string Details { get; set; } = null!;

    [Column("price", TypeName = "money")]
    public decimal Price { get; set; }
}
