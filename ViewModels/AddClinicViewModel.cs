using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddClinicViewModel
    {
        public int clinicid { get; set; }
        [Required(ErrorMessage = "Clinic Name Is Required")]
        [MaxLength(50)]
        [DataType("string")]
        public string ClinicName { get; set; }
        [Required(ErrorMessage = "Please Enter Open Time")]
        [DataType(DataType.Time)]
        public TimeSpan OpenTime { get; set; }
        [Required(ErrorMessage = "Please Enter Close Time")]
        [DataType(DataType.Time)]
        public TimeSpan CloseTime { get; set; }
        [Required(ErrorMessage ="Mobile Phone Is Required")]
        public List<string> PhoneNumbers { get; set; }
        [Required(ErrorMessage ="Address Is Required")]
        public List<string> Addresses { get; set; }
        [Required(ErrorMessage ="Branch Is Required")]
        public List<string> AssosiationBranches { get; set; }
        [Required]
        public List<double> AssosiationDiscounds { get; set; }
        [Required(ErrorMessage ="Insurance Is Required")]
        public List<string> Insurances { get; set; }
        [Required]
        public List<double> InsuranceDiscounds { get; set; }
    }
}

