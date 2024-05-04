namespace Egyptian_association_of_cieliac_patients.ViewModels
{
    public class EditPatientViewModel
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientBloodType { get; set; }
        public string Dob { get; set; }
        public string Ssn { get; set; }
        public List<string> PatientAddress { get; set; }=new List<string>();
        public List<string> PatientPhone { get; set; }= new List<string>();
        public List<string> patientDisses { get; set; }=new List<string>();
        public int assosiationId { get; set; }
        public IFormFile medicaltest { get; set; }
        public string recordpath { get; set; }
        public List<int> dissesIds { get; set; }
    }
}
