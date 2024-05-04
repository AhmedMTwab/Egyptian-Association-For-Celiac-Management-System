using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Repository;
using Microsoft.AspNetCore.Hosting;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class PatientController : Controller
    {
        private readonly ICRUDRepo<Patient> patientrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
		private readonly ICRUDRepo<Dises> dises_Crud;
		private readonly IWebHostEnvironment hosting;

        public PatientController(ICRUDRepo<Patient> patientrepo,ICRUDRepo<AssosiationBranch> assosiation_crud,ICRUDRepo<Dises> dises_crud,IWebHostEnvironment hosting)
        {
            this.patientrepo = patientrepo;
            assosiation_Crud = assosiation_crud;
			dises_Crud = dises_crud;
			this.hosting = hosting;
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
            var patient = patientrepo.FindById(Id, "Addresses", "PhoneNumbers", "Diseses", "Medicalrecords");
            return View(patient);
        }
        [HttpGet]
        public IActionResult Addpatient()
        {
            ViewBag.assosiations=assosiation_Crud.FindAll().ToList();
            ViewBag.disess=dises_Crud.FindAll().ToList();
            return View("AddPatient");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Addpatient(AddPatientViewModel NewPatientData)
		{
            if (ModelState.IsValid)
            {
                var patient = new Patient();
                foreach (var _address in NewPatientData.PatientAddress)
                {
                    var address = new PatientAddress()
                    {
                        Address = _address,
                        PatientId = patient.PatientId
                    };
                    patient.Addresses.Add(address);

                }

                
                foreach (var phone in NewPatientData.PatientPhone)
                {
                    var phonenumber = new PatientPhone()
                    {
                        PhoneNumber = phone,
                        PatientId = patient.PatientId
                    };
                    patient.PhoneNumbers.Add(phonenumber);

                }

                List<Dises> patient_disses = new List<Dises>();
                foreach (var disess in NewPatientData.dissesIds)
                {
                    var dises = dises_Crud.FindById(disess);
                    patient_disses.Add(dises);
                }
                foreach(var disess in patient_disses)
                {
                    var patientdises = new PatientDisesHave()
                    {
                        Dises = disess,
                        PatientId = patient.PatientId
                    };
                    patient.Diseses.Add(patientdises);
                }

                string recordFolder = Path.Combine(hosting.WebRootPath, "medical records");
                string testpath = Path.Combine(recordFolder, NewPatientData.medicaltest.FileName);
                NewPatientData.medicaltest.CopyTo(new FileStream(testpath, FileMode.Create));
                var medicalrecordtest = new MedicalRecordTest()
                {
                    TestsPath = NewPatientData.medicaltest.FileName
                };
               
                patient.PatientName=NewPatientData.PatientName;
                patient.PatientBloodtype = NewPatientData.PatientBloodType;
                DateTime dob=DateTime.Parse(NewPatientData.Dob);
                patient.Dob = DateOnly.FromDateTime(dob);
                patient.Ssn = NewPatientData.Ssn;
                patient.assosiationid = NewPatientData.assosiationId;
				var medicalrecord = new MedicalRecord();
				medicalrecord.Tests.Add(medicalrecordtest);
				medicalrecord.PatientId = patient.PatientId;
				medicalrecord.DisesId = patient.Diseses.FirstOrDefault().DisesId;
                medicalrecord.Date = DateOnly.FromDateTime(DateTime.Now);
				patient.Medicalrecords.Add(medicalrecord);
				patient.Assosiation = assosiation_Crud.FindById(NewPatientData.assosiationId);
                patientrepo.AddOne(patient);
                return RedirectToAction("viewall");

            }
			return View("AddPatient",NewPatientData);
		}
        [HttpGet]
        public IActionResult Editpatient(int id)
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            var patient=patientrepo.FindById(id);
            EditPatientViewModel patientView = new EditPatientViewModel();
            patientView.PatientId = id;
            patientView.PatientName = patient.PatientName;
            patientView.Dob = patient.Dob.ToDateTime(TimeOnly.Parse("00:00")).ToString();
            patientView.Ssn = patient.Ssn;
            patientView.PatientBloodType = patient.PatientBloodtype;
            foreach (var address in patient.Addresses)
            {
                patientView.PatientAddress.Add(address.Address);
            }
            foreach (var disses in patient.Diseses) 
            {
                patientView.patientDisses.Add(disses.Dises.Name);
            }
            foreach (var phone in patient.PhoneNumbers)
            {
                patientView.PatientPhone.Add(phone.PhoneNumber);
            }
            if (patient.Medicalrecords.First().Tests.First().TestsPath != null)
            {
                patientView.recordpath = patient.Medicalrecords.First().Tests.First().TestsPath;
            }
            else
                patientView.recordpath = "";

            return View("EditPatient",patientView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editpatient(int id, EditPatientViewModel newdata)
        {
            var patient = patientrepo.FindById(id);
            List<PatientAddress> newaddresses = new List<PatientAddress>();
            foreach (var address in newdata.PatientAddress)
            {
                var adress = new PatientAddress()
                {
                    Address = address,
                    PatientId = patient.PatientId
                };
                newaddresses.Add(adress);
            }
            patient.Addresses = newaddresses;

            List<PatientPhone> newphones = new List<PatientPhone>();
            foreach (var Phone in newdata.PatientPhone)
            {
                var phone = new PatientPhone()
                {
                    PhoneNumber = Phone,
                    PatientId = patient.PatientId
                };
                newphones.Add(phone);
            }

            patient.PhoneNumbers = newphones;



            patient.assosiationid = newdata.assosiationId;
            patient.Assosiation = assosiation_Crud.FindById(newdata.assosiationId);
            patientrepo.UpdateOne(patient);

            return RedirectToAction("viewall");
        }
        public IActionResult Deletepatient(int id)
        {
            var patient = patientrepo.FindById(id);
            string recordFolder = Path.Combine(hosting.WebRootPath, "medical records");
            string testpath = Path.Combine(recordFolder, patient.Medicalrecords.FirstOrDefault().Tests.FirstOrDefault().TestsPath);
            System.IO.File.Delete(testpath);
            patientrepo.DeleteOne(patient);
            return RedirectToAction("viewall");
        }

    }
}
