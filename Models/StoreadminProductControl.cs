using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Keyless]
[Table("storeadmin_product_control")]
public partial class StoreadminProductControl
{
    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("admin_id")]
    public int AdminId { get; set; }

    [ForeignKey("AdminId")]
    public virtual StoreAdmin Admin { get; set; } = null!;

    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; } = null!;
}
