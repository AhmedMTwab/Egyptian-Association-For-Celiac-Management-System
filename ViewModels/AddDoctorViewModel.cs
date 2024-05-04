namespace Egyptian_association_of_cieliac_patients.ViewModels
{
	public class AddDoctorViewModel
	{
		public int doctorid { get; set; }
		public string DoctorName { get; set;}
		public string DoctorMajor {  get; set;}
        public List<string> ClinicNames { get; set; } 
        public List<TimeSpan> ClinicArrivalTimes { get; set; } 
        public List<TimeSpan> ClinicLeaveTimes { get; set; } 
        public List<string> PhoneNumbers { get; set; }
	}
}
