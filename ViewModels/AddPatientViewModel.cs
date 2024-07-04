using Egyptian_association_of_cieliac_patients.Models;
using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
	public class AddPatientViewModel
	{
		public int PatientId { get; set; }
		[Required]
		public string PatientName { get; set; }
        [Required]
		public string PatientBloodType { get; set; }
		[Required]
		public string Dob { get; set; }
		[Required]
		[MinLength(14)]
		[MaxLength(14)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "SSN must be numeric")]
        public string Ssn { get; set; }
		public List<string> PatientAddress { get; set; }=new List<string>();
		public List<string> PatientPhone { get; set; } = new List<string>();
		public int assosiationId { get; set; }
		[Required]
        public IFormFile medicaltest {  get; set; }
		public string? recordpath { get; set; }
		public List<int> dissesIds { get; set; } = new List<int>();

	}
}
