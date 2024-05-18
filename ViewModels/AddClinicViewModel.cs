namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddClinicViewModel
    {
        public int clinicid { get; set; }
        public string ClinicName { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public List<string> Addresses { get; set; }

        public List<string> AssosiationBranches { get; set; }
        public List<double> AssosiationDiscounds { get; set; }
        public List<string> Insurances { get; set; }
        public List<double> InsuranceDiscounds { get; set; }
    }
}

