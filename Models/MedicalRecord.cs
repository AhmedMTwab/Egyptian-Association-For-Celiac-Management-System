using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("medical_record")]
public partial class MedicalRecord
{
    [Key]
    [Column("record_id")]
    public int RecordId { get; set; }

    [Column("date")]
    public DateOnly Date { get; set; }

    [Column("patient_id")]
    public int? PatientId { get; set; }

    [Column("dises_id")]
    public int? DisesId { get; set; }
    [InverseProperty("Record")]
    public virtual ICollection<DoctorMedicalrecordVeiw> Doctors { get; set; } = new List<DoctorMedicalrecordVeiw>();
    public virtual ICollection<MedicalRecordDrug> Drug { get; set; } = new List<MedicalRecordDrug>();
    public virtual ICollection<MedicalRecordTest> Test { get; set; } = new List<MedicalRecordTest>();
}
