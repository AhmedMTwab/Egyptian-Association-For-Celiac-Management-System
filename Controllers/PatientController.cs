using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepo patientrepo;

        public PatientController(IPatientRepo patientrepo)
        {
            this.patientrepo = patientrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult viewall()
        {
            var patientsList = patientrepo.FindAll();
            return View(patientsList);
        }
        public IActionResult viewone(int Id)
        {
            var patient = patientrepo.FindById(Id);
            return View(patient);
        }
        [HttpGet]
        public IActionResult Addpatient()
        {

            return View("UserAdminControls");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Addpatient(PatientViewModel NewPatientData)
		{
            if (ModelState.IsValid)
            {
                var patient = new Patient();
                var adress = new PatientAddress()
                {
                    Address = NewPatientData.PatientAddress
                };
                patient.PatientName=NewPatientData.PatientName;
                patient.PatientBloodtype = NewPatientData.PatientBloodType;
                patient.Dob = NewPatientData.Dob;
                patient.Ssn = NewPatientData.Ssn;
                //patient.Addresses.Add(adress);
                patientrepo.AddOne(patient);
                return RedirectToAction("viewall");

            }
			return View("UserAdminControls",NewPatientData);
		}
	}
}
