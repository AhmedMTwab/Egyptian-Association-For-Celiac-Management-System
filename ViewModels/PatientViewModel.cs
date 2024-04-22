using Egyptian_association_of_cieliac_patients.Models;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
	public class PatientViewModel
	{
		public int PatientId { get; set; }
		public string PatientName { get; set; }
		public string PatientBloodType { get; set; }
		public string dises {  get; set; }
		public DateOnly Dob { get; set; }
		public string Ssn { get; set; }
		public string PatientAddress { get; set; }
		public string PatientPhone {  get; set; }
		public int assosiationId { get; set; }
		public IFormFile medicaltest {  get; set; }
		public string recordpath { get; set; }

	}
}
