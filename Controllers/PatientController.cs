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
        private readonly IPatientRepo patientrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
        private readonly IWebHostEnvironment hosting;

        public PatientController(IPatientRepo patientrepo,ICRUDRepo<AssosiationBranch> assosiation_crud,IWebHostEnvironment hosting)
        {
            this.patientrepo = patientrepo;
            assosiation_Crud = assosiation_crud;
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
            var patient = patientrepo.FindById(Id);
            return View(patient);
        }
        [HttpGet]
        public IActionResult Addpatient()
        {
            ViewBag.assosiations=assosiation_Crud.FindAll().ToList();
            return View("AddPatient");
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
                    Address = NewPatientData.PatientAddress,
                    PatientId = patient.PatientId
                };


                var phone = new PatientPhone()
                {
                    PhoneNumber = NewPatientData.PatientPhone,
                    PatientId = patient.PatientId
                };
                var dises = new Dises()
                {
                    Name = NewPatientData.dises
                };
                var patientdises = new PatientDisesHave()
                {
                    Dises = dises,
                    PatientId = patient.PatientId
                };
                string recordFolder = Path.Combine(hosting.WebRootPath, "medical records");
                string testpath = Path.Combine(recordFolder, NewPatientData.medicaltest.FileName);
                NewPatientData.medicaltest.CopyTo(new FileStream(testpath, FileMode.Create));
                var medicalrecordtest = new MedicalRecordTest()
                {
                    TestsPath = NewPatientData.medicaltest.FileName
                };
                var medicalrecord = new MedicalRecord();
                medicalrecord.Tests.Add(medicalrecordtest);
                medicalrecord.PatientId = patient.PatientId;
                medicalrecord.DisesId = patient.Diseses.FirstOrDefault().DisesId;
                patient.Medicalrecords.Add(medicalrecord);
                patient.PatientName=NewPatientData.PatientName;
                patient.PatientBloodtype = NewPatientData.PatientBloodType;
                patient.Dob = NewPatientData.Dob;
                patient.Ssn = NewPatientData.Ssn;
                patient.assosiationid = NewPatientData.assosiationId;
                patient.Addresses.Add(adress);
                patient.PhoneNumbers.Add(phone);
                patient.Diseses.Add(patientdises);
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
            PatientViewModel patientView = new PatientViewModel();
            patientView.PatientId = id;
            patientView.PatientName = patient.PatientName;
            patientView.Dob = patient.Dob;
            patientView.Ssn = patient.Ssn;
            patientView.PatientBloodType = patient.PatientBloodtype;
            patientView.PatientAddress = patient.Addresses.FirstOrDefault().Address;
            patientView.dises = patient.Diseses.FirstOrDefault().Dises.Name;
            patientView.PatientPhone = patient.PhoneNumbers.FirstOrDefault().PhoneNumber;
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
        public IActionResult Editpatient(int id,PatientViewModel newdata)
        {
            var patient = patientrepo.FindById(id);
            var adress = new PatientAddress()
            {
                Address = newdata.PatientAddress,
                PatientId = patient.PatientId
            };


            var phone = new PatientPhone()
            {
                PhoneNumber = newdata.PatientPhone,
                PatientId = patient.PatientId
            };
            var dises = new Dises()
            {
                Name = newdata.dises
            };
            var patientdises = new PatientDisesHave()
            {
                Dises = dises,
                PatientId = patient.PatientId
            };
            List<PatientAddress> newaddresses = new List<PatientAddress>();
            newaddresses.Add(adress);
            patient.Addresses = newaddresses;

            List<PatientPhone> newphones = new List<PatientPhone>();
            newphones.Add(phone);
            patient.PhoneNumbers = newphones;

            List<PatientDisesHave> newdisses = new List<PatientDisesHave>();
            newdisses.Add(patientdises);
            patient.Diseses = newdisses;
            patient.assosiationid = newdata.assosiationId;
            patient.Assosiation = assosiation_Crud.FindById(newdata.assosiationId);
            patientrepo.UpdateOne(patient);

            return RedirectToAction("viewall");
        }
        public IActionResult Deletepatient(int id)
        {
            var patient=patientrepo.FindById(id);
            patientrepo.DeleteOne(patient);
            return RedirectToAction("viewall");
        }

    }
}
