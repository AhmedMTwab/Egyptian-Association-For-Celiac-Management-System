﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("order")]
public partial class Order
{
    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("order_date")]
    public DateOnly OrderDate { get; set; }

    [Column("order_details", TypeName = "text")]
    public string OrderDetails { get; set; } = null!;
    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("total_cost", TypeName = "money")]
    public decimal TotalCost { get; set; }

    [Column("shipment_location")]
    [StringLength(50)]
    [Unicode(false)]
    public string ShipmentLocation { get; set; } = null!;

    [Column("shipment_time")]
    public TimeOnly ShipmentTime { get; set; }

    [Column("shipment_phone")]
    public string ShipmentPhone { get; set; }

   
    [Column("patient_id")]
    public int PatientId { get; set; }
    [InverseProperty("Order")]
    public virtual List<OrderProduct> OrderedProducts { get; set; }= new List<OrderProduct>();
    [InverseProperty("Order")]
    public virtual List<OrderMaterial> OrderedMaterials { get; set; }=new List<OrderMaterial>();


    [Column("Cart_id")]
    public int CartId { get; set; }
    [Column("Payment_id")]
    public int PaymentId { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("Orders")]
    public virtual Patient Patient { get; set; } = null!;

    [ForeignKey("CartId")]
    public virtual Cart Cart { get; set; }
    [ForeignKey("PaymentId")]
    public virtual Payment Payment { get; set; } = null!;
}
