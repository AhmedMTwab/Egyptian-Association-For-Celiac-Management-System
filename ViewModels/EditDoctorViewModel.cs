﻿namespace Egyptian_association_of_cieliac_patients.ViewModels
{
	public class EditDoctorViewModel
	{
		
		public int doctorid { get; set; }
		public string DoctorName { get; set; }
		public string DoctorMajor { get; set; }
		public List<string> ClinicNames { get; set; } = new List<string>();
		public List<TimeSpan> ClinicArrivalTimes { get; set; } = new List<TimeSpan>();
		public List<TimeSpan> ClinicLeaveTimes { get; set; } = new List<TimeSpan>();
		public List<string> PhoneNumbers { get; set; } = new List<string>();
	}
}

