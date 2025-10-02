using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class EditClinicViewModel
    {
        public int clinicid { get; set; }
        [Required(ErrorMessage = "Clinic Name Is Required")]
        public string ClinicName { get; set; }
        [Required(ErrorMessage = "Please Enter Open Time")]
        public TimeSpan OpenTime { get; set; }
        [Required(ErrorMessage = "Please Enter Close Time")]
        public TimeSpan CloseTime { get; set; }
        [Required(ErrorMessage = "Mobile Phone Is Required")]
        public List<string> PhoneNumbers { get; set; }=new List<string>();
        [Required(ErrorMessage = "Address Is Required")]
        public List<string> Addresses { get; set; } = new List<string>();
        [Required(ErrorMessage = "Branch Is Required")]
        public List<string> AssosiationBranches { get; set; } = new List<string>();
        public List<double> AssosiationDiscounds { get; set; } = new List<double>();
        [Required(ErrorMessage = "Insurance Is Required")]
        public List<string> Insurances { get; set; } = new List<string>();
        public List<double> InsuranceDiscounds { get; set; } = new List<double>();
    }
}
