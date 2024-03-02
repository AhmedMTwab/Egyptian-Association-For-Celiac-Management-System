using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("cart_material_add")]
public partial class CartMaterialAdd
{
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("material_id")]
    public int MaterialId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [ForeignKey("MaterialId")]
    public virtual RawMaterial Material { get; set; } = null!;

    [ForeignKey("OrderId")]
    public virtual Cart Order { get; set; } = null!;
}
