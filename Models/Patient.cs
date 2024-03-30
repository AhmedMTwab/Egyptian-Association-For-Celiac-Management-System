using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("patient")]
public partial class Patient
{
    [Key]
    [Column("patient_id")]
    public int PatientId { get; set; }

    [Column("patient_name")]
    [StringLength(50)]
    public string PatientName { get; set; } = null!;

    [Column("patient_bloodtype")]
    [StringLength(10)]
    public string PatientBloodtype { get; set; } = null!;

    [Column("DOB")]
    public DateOnly Dob { get; set; }

    [Column("SSN")]
    public int Ssn { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
    
    public virtual ICollection<PatientAddress> Addresses { get; set; } = new List<PatientAddress>();
    
    //public virtual ICollection<PatientPhone> PhoneNumbers { get; set; } = new List<PatientPhone>();
}
