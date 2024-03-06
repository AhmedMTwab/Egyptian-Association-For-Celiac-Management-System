using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Egyptian_association_of_cieliac_patients.Models
{
    [Table("useradmin_storeadmin_registration_approve")]
    public partial class UserAdminStoreAdminRegistrationApprove
    {
        [Column("username")]
        [Key]
        [ForeignKey("StoreAdmin")]
        public string UserName { get; set; }

        [Column("storeadmin_id")]
        [Key]
        [ForeignKey("StoreAdmin")]
        public int StoreAdminId { get; set; }

        [Column("useradmin_id")]
        [Key]
        [ForeignKey("UserAdmin")]
        public int UserAdminId { get; set; }

        public virtual UserAdmin UserAdmin { get; set; } = null!;
        public virtual StoreAdminRegistration StoreAdmin { get; set; } = null!;
    }
}