using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Egyptian_association_of_cieliac_patients.Models
{
    [Table("useradmin_medicaladmin_registration_approve")]
    public partial class UserAdminMedicalAdminRegistrationApprove
    {
        [Column("username")]
        [Key]
        [ForeignKey("MedicalAdmin")]
        public string UserName { get; set; }

        [Column("medicaladmin_id")]
        [Key]
        [ForeignKey("MedicalAdmin")]
        public int MedicalAdminId { get; set; }

        [Column("useradmin_id")]
        [Key]
        [ForeignKey("UserAdmin")]
        public int UserAdminId { get; set; }

        public virtual UserAdmin UserAdmin { get; set; } = null!;
        public virtual MedicalAdminRegistration MedicalAdmin { get; set; } = null!;
    }
}