using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddLabViewModel
    {
        public int Labid { get; set; }
        [Required]
        public string LabName { get; set; }
		[Required]
		public TimeSpan OpenTime { get; set; }
		[Required]
		public TimeSpan CloseTime { get; set; }
        [Required]
        public List<string> PhoneNumbers { get; set; }
        [Required]
        public List<string> Addresses { get; set; }
		[Required]
		public List<string> AssosiationBranches { get; set; }
        [Required]
        public List<double> AssosiationDiscounds { get; set; }
        [Required]
        public List<string> Insurances { get; set; }
        [Required]
        public List<double> InsuranceDiscounds { get; set; }
		[Required]
		public string LabType { get; set; }


    }
}
