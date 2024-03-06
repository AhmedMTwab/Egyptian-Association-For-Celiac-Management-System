using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Egyptian_association_of_cieliac_patients.Models
{
    [Table("useradmin_patient_registration_approve")]
    public partial class UserAdminPatientRegistrationApprove
    {
        [Column("username")]
        [Key]
        [ForeignKey("Registration")]
        public string UserName { get; set; }

        [Column("patient_id")]
        [Key]
        [ForeignKey("Registration")]
        public int PatientId { get; set; }

        [Column("useradmin_id")]
        [Key]
        [ForeignKey("UserAdmin")]
        public int UserAdminId { get; set; }

        public virtual UserAdmin UserAdmin { get; set; } = null!;
        public virtual PatientRegistration Registration { get; set; } = null!;
    }
}
