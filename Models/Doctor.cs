﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("doctor")]
public partial class Doctor
{
    [Key]
    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("major")]
    [StringLength(50)]
    [Unicode(false)]
    public string Major { get; set; } = null!;

    [Column("arrive_time")]
    public TimeOnly ArriveTime { get; set; }

    [Column("leave_time")]
    public TimeOnly LeaveTime { get; set; }
    [InverseProperty("Doctor")]
    public virtual ICollection<DoctorPhone> DoctorPhones { get; set; }=new List<DoctorPhone>();
    [InverseProperty("Doctor")]
    public virtual ICollection<DoctorClinicWork> clinics { get; set; } = new List<DoctorClinicWork>();
    [InverseProperty("Doctor")]
    public virtual ICollection<UseradminDoctorControl> admins { get; set; } = new List<UseradminDoctorControl>();
    [InverseProperty("Doctor")]
    public virtual ICollection<DoctorMedicalrecordVeiw> medicalrecords { get; set; } = new List<DoctorMedicalrecordVeiw>();
}
