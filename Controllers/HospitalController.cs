using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class HospitalController : Controller
    {
        private readonly ICRUDRepo<Hospital> hospitalRepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiationRepo;
        private readonly ICRUDRepo<HealthInsurance> insuranceRepo;

        public HospitalController(ICRUDRepo<Hospital> HospitalRepo, ICRUDRepo<AssosiationBranch> AssosiationRepo, ICRUDRepo<HealthInsurance> InsuranceRepo)
        {
            hospitalRepo = HospitalRepo;
            assosiationRepo = AssosiationRepo;
            insuranceRepo = InsuranceRepo;
        }

        public IActionResult Index()
        {
            var hospitals = hospitalRepo.FindAll();
            return View(hospitals);
        }
        public IActionResult Details(int id)
        {
            var hospital = hospitalRepo.FindById(id, "PhoneNumbers", "addresses", "insurances", "types");
            return View(hospital);
        }
        [HttpGet]
        public IActionResult AddHospital()
        {
            // Serialize ViewBag.assosiations to JSON with ReferenceHandler.Preserve
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
            var insurances = insuranceRepo.FindAll();
            var insuranceNames = insurances.Select(a => a.Name).ToArray();
            ViewBag.insurances = JsonSerializer.Serialize(insuranceNames, options);
            return View("AddHospital");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddHospital(AddHospitalViewModel newhospital)
        {
            if (ModelState.IsValid)
            {
                var hospital = new Hospital();
                hospital.Name = newhospital.HospitalName;
                foreach (var type in newhospital.HospitalTypes)
                {
                    var Type = new HospitalType()
                    {
                        Type = type,
                        HospitalId = hospital.HospitalId
                    };
                    hospital.types.Add(Type);
                }

                foreach (var phone in newhospital.PhoneNumbers)
                {
                    var phonenumber = new HospitalPhone()
                    {
                        PhoneNumber = phone,
                        HospitalId = hospital.HospitalId
                    };
                    hospital.PhoneNumbers.Add(phonenumber);

                }
                foreach (var address in newhospital.Addresses)
                {
                    var Address = new HospitalAddress()
                    {
                        Address = address,
                        HospitalId = hospital.HospitalId
                    };
                    hospital.addresses.Add(Address);

                }

                var addedinsurance = new HashSet<int>();
                for (int i = 0; i < newhospital.Insurances.Count; i++)
                {
                    var insurance = newhospital.Insurances[i];
                    var discound = newhospital.InsuranceDiscounds[i];

                    var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;
                    if (insuranceId != null && !addedinsurance.Contains(insuranceId))
                    {
                        var Discound = new HospitalInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            HospitalId = hospital.HospitalId
                        };

                        hospital.insurances.Add(Discound);
                        addedinsurance.Add(insuranceId);
                    }
                }

                hospitalRepo.AddOne(hospital);
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditHospital(int id)
        {
            var hospital = hospitalRepo.FindById(id);
            EditHospitalViewModel model = new EditHospitalViewModel();
            model.Hospitalid = hospital.HospitalId;
            model.HospitalName = hospital.Name;
            foreach (var type in hospital.types)
            {
                model.HospitalTypes.Add(type.Type);
            }

            foreach (var phone in hospital.PhoneNumbers)
            {
                model.PhoneNumbers.Add(phone.PhoneNumber);
            }
            foreach (var address in hospital.addresses)
            {
                model.Addresses.Add(address.Address);
            }
            foreach (var insurance in hospital.insurances)
            {
                model.Insurances.Add(insurance.Insurance.Name);
                model.InsuranceDiscounds.Add(insurance.DiscountPrecentage);
            }

            return View("EditHospital", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHospital(int id, EditHospitalViewModel NewHospital)
        {
            if (ModelState.IsValid)
            {
                var hospital = hospitalRepo.FindById(id);
                if (hospital != null)
                {
                   
                    hospital.types.Clear();
                    foreach (var type in NewHospital.HospitalTypes)
                    {
                        var Type = new HospitalType()
                        {
                            Type = type,
                            HospitalId = hospital.HospitalId
                        };
                        hospital.types.Add(Type);

                    }

                    hospital.PhoneNumbers.Clear();
                    foreach (var phone in NewHospital.PhoneNumbers)
                    {
                        var phonenumber = new HospitalPhone()
                        {
                            PhoneNumber = phone,
                            HospitalId = hospital.HospitalId
                        };
                        hospital.PhoneNumbers.Add(phonenumber);

                    }
                    hospital.addresses.Clear();
                    foreach (var address in NewHospital.Addresses)
                    {
                        var Address = new HospitalAddress()
                        {
                            Address = address,
                            HospitalId = hospital.HospitalId
                        };
                        hospital.addresses.Add(Address);

                    }

                   
                    hospital.insurances.Clear();
                    for (int i = 0; i < NewHospital.Insurances.Count; i++)
                    {
                        var insurance = NewHospital.Insurances[i];
                        var discound = NewHospital.InsuranceDiscounds[i];

                        var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;

                        var Discound = new HospitalInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            HospitalId = hospital.HospitalId
                        };

                        hospital.insurances.Add(Discound);
                    }

                    hospitalRepo.UpdateOne(hospital);
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult DeleteHospital(int id)
        {
            var hospital = hospitalRepo.FindById(id);
            hospitalRepo.DeleteOne(hospital);
            return RedirectToAction("Index");
        }
    }
}
