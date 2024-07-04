using System.ComponentModel.DataAnnotations;

namespace Egyptian_association_of_cieliac_patients.ViewModels
{
	public class AddDoctorViewModel
	{
		public int doctorid { get; set; }
		[Required]
		public string DoctorName { get; set;}
        [Required]
        public string DoctorMajor {  get; set;}
        [Required]
        public List<string> ClinicNames { get; set; }
        [Required]
        public List<TimeSpan> ClinicArrivalTimes { get; set; }
        [Required]
        public List<TimeSpan> ClinicLeaveTimes { get; set; }
        [Required]
        public List<string> PhoneNumbers { get; set; }
	}
}
