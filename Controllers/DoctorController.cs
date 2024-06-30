using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Mvc;
using Egyptian_association_of_cieliac_patients.ViewModels;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using Egyptian_association_of_cieliac_patients.IdentityModels;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleUser}")]
    public class DoctorController : Controller
    {
        private readonly ICRUDRepo<Doctor> doctor_Crud;
        private readonly ICRUDRepo<Clinic> clinicRepo;

        public DoctorController(ICRUDRepo<Doctor> Doctor_crud,ICRUDRepo<Clinic> ClinicRepo) 
        {
            doctor_Crud = Doctor_crud;
            clinicRepo = ClinicRepo;
        }
        public IActionResult Index()
        {
            var doctors = doctor_Crud.FindAll();
            return View(doctors);
        }
    
        public IActionResult Details(int id)
        {
            var doctor = doctor_Crud.FindById(id, "DoctorPhones", "clinics");

            return View(doctor);
        }
        [HttpGet]
        public IActionResult AddDoctor()
        {
            // Serialize ViewBag.assosiations to JSON with ReferenceHandler.Preserve
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
            var clinics = clinicRepo.FindAll();
            var clinicName = clinics.Select(a => a.Name).ToArray();
            ViewBag.clinics = JsonSerializer.Serialize(clinicName, options);
            return View("AddDoctor");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDoctor(AddDoctorViewModel doctor)
        {
            Doctor doc =new Doctor();
            doc.Name = doctor.DoctorName;
            doc.Major = doctor.DoctorMajor;

            List<DoctorClinicWork> newclinic = new List<DoctorClinicWork>();
            var addedClinics = new HashSet<int>(); 
            int i = 0;
            foreach (var clinicName in doctor.ClinicNames)
            {
                var existingClinic = clinicRepo.FindAll().FirstOrDefault(c => c.Name == clinicName);

                if (existingClinic != null && !addedClinics.Contains(existingClinic.ClinicId)) 
                {
                    var clinic = new DoctorClinicWork()
                    {
                        Clinic = existingClinic,
                        DoctorId = doctor.doctorid,
                        ArriveTime = TimeOnly.FromTimeSpan(doctor.ClinicArrivalTimes[i]),
                        LeaveTime = TimeOnly.FromTimeSpan(doctor.ClinicLeaveTimes[i]),
                    };

                    newclinic.Add(clinic);
                    addedClinics.Add(existingClinic.ClinicId);  
                }

                i++;
            }

            doc.clinics = newclinic;
            foreach (var phone in doctor.PhoneNumbers)
            {
                var phonenumber = new DoctorPhone()
                {
                    PhoneNumber = phone,
                    DoctorId = doc.DoctorId
                };
                doc.DoctorPhones.Add(phonenumber);

            }
            doctor_Crud.AddOne(doc);



            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditDoctor(int id)
        {
               
                var doctor = doctor_Crud.FindById(id);
                EditDoctorViewModel doctorView = new EditDoctorViewModel();
                doctorView.doctorid = id;
                doctorView.DoctorName = doctor.Name;
                doctorView.DoctorMajor = doctor.Major;
                var clinics = clinicRepo.FindAll();
                ViewBag.clinics = clinics;

            foreach (var phone in doctor.DoctorPhones)
                {
                    doctorView.PhoneNumbers.Add(phone.PhoneNumber);
                }
                foreach (var clinic in doctor.clinics)
                {
                    doctorView.ClinicNames.Add(clinic.Clinic.Name);
                    doctorView.ClinicArrivalTimes.Add(clinic.ArriveTime.ToTimeSpan());
				    doctorView.ClinicLeaveTimes.Add(clinic.LeaveTime.ToTimeSpan());
			    }

                return View("EditDoctor", doctorView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditDoctor(int id, EditDoctorViewModel newdata)
        {
            var doctor = doctor_Crud.FindById(id);

            doctor.DoctorPhones.Clear();
            List<DoctorPhone> newphones = new List<DoctorPhone>();
            foreach (var Phone in newdata.PhoneNumbers)
            {
                var phone = new DoctorPhone()
                {
                    PhoneNumber = Phone,
                    DoctorId = doctor.DoctorId
                };
                newphones.Add(phone);
            }

            doctor.DoctorPhones = newphones;

            doctor.clinics.Clear();
            List<DoctorClinicWork> newclinic = new List<DoctorClinicWork>();
            int i = 0;
            foreach (var clinicName in newdata.ClinicNames)
            {
                // Find the clinic by name
                var existingClinic = clinicRepo.FindAll().FirstOrDefault(c => c.Name == clinicName);

                if (existingClinic != null)
                {
                    // Clinic with the same name exists, use its ClinicId
                    var clinic = new DoctorClinicWork()
                    {
                        Clinic = existingClinic,
                        DoctorId = doctor.DoctorId,
                        ArriveTime = TimeOnly.FromTimeSpan(newdata.ClinicArrivalTimes[i]),
                        LeaveTime = TimeOnly.FromTimeSpan(newdata.ClinicLeaveTimes[i]),
                    };
                    newclinic.Add(clinic);
                }
                i++;
            }

            doctor.clinics = newclinic;
            doctor_Crud.UpdateOne(doctor);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteDoctor(int id)
        {
            var doctor = doctor_Crud.FindById(id);
            if (doctor != null)
            {
                doctor_Crud.DeleteOne(doctor);
            }
            return RedirectToAction("Index");
        }

    }
}
