using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class EditBranchViewModel
    {
        [Key]
        public int AssosiationId { get; set; }
        [Required(ErrorMessage = "Please Enter Open Time")]
        public TimeSpan OpenTime { get; set; }
        [Required(ErrorMessage = "Please Enter Close Time")]
        public TimeSpan CloseTime { get; set; }
        [Required(ErrorMessage = "Address Is Required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Mobile Phone Is Required")]
        public List<string> PhoneNumbers { get; set; }
        [Required(ErrorMessage ="Dises Is Required")]
        public List<string> Dises { get; set; }
        
        [Required(ErrorMessage ="Insurance Is Required")]
        public List<string> Insurances { get; set; }
    }
}

