using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Mvc;
using Egyptian_association_of_cieliac_patients.ViewModels;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ICRUDRepo<Doctor> doctor_Crud;

        public DoctorController(ICRUDRepo<Doctor> Doctor_crud) 
        {
            doctor_Crud = Doctor_crud;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult viewall()
        {
            var doctors=doctor_Crud.FindAll();
            return View(doctors);
        }
        public IActionResult viewone(int id)
        {
            var doctor = doctor_Crud.FindById(id, "DoctorPhones", "clinics");

            return View(doctor);
        }
        [HttpGet]
        public IActionResult AddDoctor()
        {
            return View("AddDoctor");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDoctor(AddDoctorViewModel doctor)
        {
            Doctor doc =new Doctor();
            doc.Name = doctor.DoctorName;
            doc.Major = doctor.DoctorMajor;
            ICollection<DoctorClinicWork> clinics=new List<DoctorClinicWork>();
            int i = 0;
            foreach(var ClinicName in doctor.ClinicNames)
            {
                
                var clinic = new Clinic();
                var doctor_clinics = new DoctorClinicWork();
                clinic.Name = ClinicName;
                doctor_clinics.ArriveTime = TimeOnly.FromTimeSpan(doctor.ClinicArrivalTimes[i]);
                doctor_clinics.LeaveTime= TimeOnly.FromTimeSpan(doctor.ClinicLeaveTimes[i]);
                //clinic.Doctors.Add(doctor_clinics);
                doctor_clinics.Clinic = clinic;
                clinics.Add(doctor_clinics);
                i++;
            }
            doc.clinics = clinics;

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



            return RedirectToAction("viewall");
        }
        [HttpGet]
        public IActionResult EditDoctor(int id)
        {
               
                var doctor = doctor_Crud.FindById(id);
                EditDoctorViewModel doctorView = new EditDoctorViewModel();
                doctorView.doctorid = id;
                doctorView.DoctorName = doctor.Name;
                doctorView.DoctorMajor = doctor.Major;
                
                
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
			foreach (var clinic_ in newdata.ClinicNames)
			{
                var clinicc = new Clinic()
                {
                    Name = clinic_
                };
                var clinic = new DoctorClinicWork()
                {
                    Clinic = clinicc,
                    DoctorId = doctor.DoctorId,
                    ArriveTime = TimeOnly.FromTimeSpan(newdata.ClinicArrivalTimes[i]),
					LeaveTime = TimeOnly.FromTimeSpan(newdata.ClinicLeaveTimes[i]),
				};
				newclinic.Add(clinic);
                i++;
			}

			doctor.clinics = newclinic;



			doctor_Crud.UpdateOne(doctor);

            return RedirectToAction("viewall");
        }

        public IActionResult DeleteDoctor(int id)
        {
            var doctor = doctor_Crud.FindById(id);
            if (doctor != null)
            {
                doctor_Crud.DeleteOne(doctor);
            }
            return RedirectToAction("viewall");
        }

    }
}
