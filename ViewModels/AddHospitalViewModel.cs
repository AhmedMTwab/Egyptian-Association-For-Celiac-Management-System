namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class AddHospitalViewModel
    {
        public int Hospitalid { get; set; }
        public string HospitalName { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public List<string> Addresses { get; set; }

        public List<string> Insurances { get; set; }
        public List<double> InsuranceDiscounds { get; set; }
        public List<string> HospitalTypes { get; set; }
    }
}
