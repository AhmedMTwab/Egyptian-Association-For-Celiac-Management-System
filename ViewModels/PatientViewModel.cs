using Egyptian_association_of_cieliac_patients.Models;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
	public class PatientViewModel
	{
		public string PatientName { get; set; }
		public string PatientBloodType { get; set; }

		public DateOnly Dob { get; set; }
		public int Ssn { get; set; }
		public string PatientAddress { get; set; }
		public string PatientPhone {  get; set; }


	}
}
