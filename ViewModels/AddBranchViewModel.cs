using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddBranchViewModel
    {
        public int AssosiationId { get; set; }
        [Required(ErrorMessage = "Please Enter Open Time")]
        [DataType("TimeSpan")]
        public TimeSpan OpenTime { get; set; }
        [Required(ErrorMessage = "Please Enter Close Time")]
        [DataType("TimeSpan")]
        public TimeSpan CloseTime { get; set; }
        [Required(ErrorMessage = "Address Is Required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Mobile Phone Is Required")]
        [Phone]
        [StringLength(11)]
        public List<string> PhoneNumbers { get; set; }
        [Required(ErrorMessage ="Dises Is Required")]
        [MaxLength(50)]
        public List<string> Dises { get; set; }
        
        [Required(ErrorMessage ="Insurance Is Required")]
        [MaxLength(50)]
        public List<string> Insurances { get; set; }
    }
}

