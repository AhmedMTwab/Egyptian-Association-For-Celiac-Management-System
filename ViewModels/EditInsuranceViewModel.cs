using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class EditInsuranceViewModel
    {
        [Key]
        public int Insuranceid { get; set; }
        [Required(ErrorMessage = "Insurance Name Is Required")]
        public string InsuranceName { get; set; }
		[Required(ErrorMessage = "License Code Is Required")]
		public int LicenseCode { get; set; }
		[Required(ErrorMessage ="Mobile Phone Is Required")]
        public List<string> PhoneNumbers { get; set; }
        [Required(ErrorMessage ="Address Is Required")]
        public List<string> Addresses { get; set; }
    }
}

