using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using Egyptian_association_of_cieliac_patients.ViewModels;
using System.Numerics;
using NuGet.Packaging;
using Microsoft.AspNetCore.Authorization;
using Egyptian_association_of_cieliac_patients.IdentityModels;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleMedical}")]
    public class ClinicController : Controller
	{
		private readonly ICRUDRepo<Clinic> clinicRepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiationRepo;
        private readonly ICRUDRepo<HealthInsurance> insuranceRepo;

        public ClinicController(ICRUDRepo<Clinic> ClinicRepo,ICRUDRepo<AssosiationBranch> AssosiationRepo,ICRUDRepo<HealthInsurance> InsuranceRepo)
		{
			clinicRepo = ClinicRepo;
            assosiationRepo = AssosiationRepo;
            insuranceRepo = InsuranceRepo;
        }

		public IActionResult Index()
		{
            var clinic = clinicRepo.FindAll();
            return View(clinic);
        }

		public IActionResult Details(int id)
		{
			var clinic = clinicRepo.FindById(id, "Doctors", "clinicphones", "clinicaddreses", "branches", "insurences");
			return View(clinic);
		}
		[HttpGet]
		public IActionResult AddClinic()
		{
			
            // Serialize ViewBag.assosiations to JSON with ReferenceHandler.Preserve
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
			var assosiations = assosiationRepo.FindAll();
			var assosiationsAddresses=assosiations.Select(a => a.Address).ToArray();
            ViewBag.assosiations= JsonSerializer.Serialize(assosiationsAddresses, options);

            var insurances = insuranceRepo.FindAll();
            var insuranceNames = insurances.Select(a => a.Name).ToArray();
            ViewBag.insurances = JsonSerializer.Serialize(insuranceNames, options);
            return View("AddClinic");
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddClinic(AddClinicViewModel newclinic)
		{
            if (ModelState.IsValid)
            {
                var clinic = new Clinic();
                clinic.Name = newclinic.ClinicName;
                clinic.OpenTime = TimeOnly.FromTimeSpan(newclinic.OpenTime);
                clinic.CloseTime = TimeOnly.FromTimeSpan(newclinic.CloseTime);
                foreach (var phone in newclinic.PhoneNumbers)
                {
                    var phonenumber = new ClinicPhone()
                    {
                        PhoneNumber = phone,
                        ClinicId = clinic.ClinicId
                    };
                    clinic.clinicphones.Add(phonenumber);

                }
                foreach (var address in newclinic.Addresses)
                {
                    var Address = new ClinicAddress()
                    {
                        Address = address,
                        ClinicId = clinic.ClinicId
                    };
                    clinic.clinicaddreses.Add(Address);

                }
                var addedAssosiations = new HashSet<int>();
                for (int i = 0; i < newclinic.AssosiationBranches.Count; i++)
                {
                    var branch = newclinic.AssosiationBranches[i];
                    var discound = newclinic.AssosiationDiscounds[i];

                    // Find the corresponding AssosiationId for the current branch
                    var assosiationId = assosiationRepo.FindAll().First(d => d.Address == branch).AssosiationId;
                    if (assosiationId != null && !addedAssosiations.Contains(assosiationId))
                    {
                        // Create a new ClinicAssosiationDiscount for the current branch and discount
                        var Discound = new ClinicAssosiationDiscount()
                        {
                            AssosiationId = assosiationId,
                            DiscountPrecentage = discound,
                            ClinicId = clinic.ClinicId
                        };

                        // Add the discount to the clinic
                        clinic.branches.Add(Discound);
                        addedAssosiations.Add(assosiationId);
                    }
                }
                var addedinsurance=new HashSet<int>();
                for (int i = 0; i < newclinic.Insurances.Count; i++)
                {
                    var insurance = newclinic.Insurances[i];
                    var discound = newclinic.InsuranceDiscounds[i];

                    var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;
                    if (insuranceId != null && !addedinsurance.Contains(insuranceId))
                    {
                        var Discound = new ClinicInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            ClinicId = clinic.ClinicId
                        };

                        clinic.insurences.Add(Discound);
                        addedinsurance.Add(insuranceId);
                    }
                }

                clinicRepo.AddOne(clinic);
                return RedirectToAction("Index");
            }
                return View("AddClinic",newclinic);
        }
		[HttpGet]
		public IActionResult EditClinic(int id)
		{
            var clinic=clinicRepo.FindById(id);
            EditClinicViewModel model = new EditClinicViewModel();
            model.clinicid = clinic.ClinicId;
            model.ClinicName = clinic.Name;
            model.OpenTime=clinic.OpenTime.ToTimeSpan();
            model.CloseTime=clinic.CloseTime.ToTimeSpan();
            foreach(var phone in clinic.clinicphones)
            {
                model.PhoneNumbers.Add(phone.PhoneNumber);
            }
            foreach (var address in clinic.clinicaddreses)
            {
                model.Addresses.Add(address.Address);
            }
            foreach(var assosiation in clinic.branches)
            {
                model.AssosiationBranches.Add(assosiation.Assosiation.Address);
                model.AssosiationDiscounds.Add(assosiation.DiscountPrecentage);
            }
            foreach (var insurance in clinic.insurences)
            {
                model.Insurances.Add(insurance.Insurance.Name);
                model.InsuranceDiscounds.Add(insurance.DiscountPrecentage);
            }

            return View("EditClinic",model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditClinic(int id,EditClinicViewModel NewClinic)
		{
            if (ModelState.IsValid)
            {
                var clinic = clinicRepo.FindById(id);
                if (clinic != null) { 
                    clinic.OpenTime=TimeOnly.FromTimeSpan(NewClinic.OpenTime);
                    clinic.CloseTime = TimeOnly.FromTimeSpan(NewClinic.CloseTime);
                    clinic.clinicphones.Clear();
                    foreach (var phone in NewClinic.PhoneNumbers)
                    {
                        var phonenumber = new ClinicPhone()
                        {
                            PhoneNumber = phone,
                            ClinicId = clinic.ClinicId
                        };
                        clinic.clinicphones.Add(phonenumber);

                    }
                    clinic.clinicaddreses.Clear();
                    foreach (var address in NewClinic.Addresses)
                    {
                        var Address = new ClinicAddress()
                        {
                            Address = address,
                            ClinicId = clinic.ClinicId
                        };
                        clinic.clinicaddreses.Add(Address);

                    }

                    clinic.branches.Clear();
                    for (int i = 0; i < NewClinic.AssosiationBranches.Count; i++)
                    {
                        var branch = NewClinic.AssosiationBranches[i];
                        var discound = NewClinic.AssosiationDiscounds[i];

                        // Find the corresponding AssosiationId for the current branch
                        var assosiationId = assosiationRepo.FindAll().First(d => d.Address == branch).AssosiationId;

                        // Create a new ClinicAssosiationDiscount for the current branch and discount
                        var Discound = new ClinicAssosiationDiscount()
                        {
                            AssosiationId = assosiationId,
                            DiscountPrecentage = discound,
                            ClinicId = clinic.ClinicId
                        };

                        // Add the discount to the clinic
                        clinic.branches.Add(Discound);
                    }
                    clinic.insurences.Clear();
                    for (int i = 0; i < NewClinic.Insurances.Count; i++)
                    {
                        var insurance = NewClinic.Insurances[i];
                        var discound = NewClinic.InsuranceDiscounds[i];

                        var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;

                        var Discound = new ClinicInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            ClinicId = clinic.ClinicId
                        };

                        clinic.insurences.Add(Discound);
                    }

                    clinicRepo.UpdateOne(clinic);
                    return RedirectToAction("Index");
                }
            }
            return View("EditClinic", NewClinic);

        }
        public IActionResult DeleteClinic(int id)
		{
            var clinic=clinicRepo.FindById(id);
            clinicRepo.DeleteOne(clinic);
			return RedirectToAction("Index");
		}
	}
}
