using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egyptian_association_of_cieliac_patients.Models;

[Table("dises")]
public partial class Dises
{
    [Key]
    [Column("dises_id")]
    public int DisesId { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;
    public virtual ICollection<PatientDisesHave> patients { get;}=new List<PatientDisesHave>();
}
