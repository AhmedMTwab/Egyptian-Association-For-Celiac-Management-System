using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("product_image")]
public partial class ProductImage
{
    [Column("product_image", TypeName = "image")]
    public byte[] ProductImage1 { get; set; } = null!;

    [Column("product_id")]
    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; } = null!;
}
