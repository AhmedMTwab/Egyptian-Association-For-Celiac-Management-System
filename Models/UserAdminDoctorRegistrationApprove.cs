using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Egyptian_association_of_cieliac_patients.Models
{
    [Table("useradmin_doctor_registration_approve")]
    public partial class UserAdminDoctorRegistrationApprove
    {
        [Column("username")]
        [Key]
        [ForeignKey("Registration")]
        public string UserName { get; set; }

        [Column("doctor_id")]
        [Key]
        [ForeignKey("Registration")]
        public int DoctorId { get; set; }

        [Column("useradmin_id")]
        [Key]
        [ForeignKey("UserAdmin")]
        public int UserAdminId { get; set; }

        public virtual UserAdmin UserAdmin { get; set; } = null!;
        public virtual DoctorRegistration Registration { get; set; } = null!;
    }
}
