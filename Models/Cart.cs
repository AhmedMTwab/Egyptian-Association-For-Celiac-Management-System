﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("cart")]
public partial class Cart
{
    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("order_date")]
    public DateOnly OrderDate { get; set; }

    [Column("order_details", TypeName = "text")]
    public string OrderDetails { get; set; } = null!;

    [Column("total_cost", TypeName = "money")]
    public decimal TotalCost { get; set; }

    [Column("shipment_location")]
    [StringLength(50)]
    [Unicode(false)]
    public string ShipmentLocation { get; set; } = null!;

    [Column("shipment_time")]
    public TimeOnly ShipmentTime { get; set; }

    [Column("shipment_phone", TypeName = "numeric(18, 0)")]
    public decimal ShipmentPhone { get; set; }

    [Column("patient_id")]
    public int PatientId { get; set; }

    [Column("payment_id")]
    public int PaymentId { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("Carts")]
    public virtual Patient Patient { get; set; } = null!;

    [ForeignKey("PaymentId")]
    public virtual Payment Payment { get; set; } = null!;
}
