using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Egyptian_association_of_cieliac_patients.IdentityModels;


namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleMedical}")]
    public class PharmacyController : Controller
    {
        private readonly ICRUDRepo<Pharmacy> pharmacyRepo;
		private readonly ICRUDRepo<AssosiationBranch> assosiationRepo;
		private readonly ICRUDRepo<HealthInsurance> insuranceRepo;

		public PharmacyController(ICRUDRepo<Pharmacy> PharmacyRepo,ICRUDRepo<AssosiationBranch> AssosiationRepo, ICRUDRepo<HealthInsurance> InsuranceRepo)
        {
            pharmacyRepo = PharmacyRepo;
			assosiationRepo = AssosiationRepo;
			insuranceRepo = InsuranceRepo;
		}
      
        public IActionResult Index()
        {
            var pharmacies=pharmacyRepo.FindAll();
            return View(pharmacies);
        }
        public IActionResult Details(int id)
        {
            var pharmacy = pharmacyRepo.FindById(id, "PhoneNumbers", "addresses", "AssosiationBranches", "insurances");
            return View(pharmacy);
        }
        [HttpGet]
        public IActionResult AddPharmacy()
        {
			// Serialize ViewBag.assosiations to JSON with ReferenceHandler.Preserve
			var options = new JsonSerializerOptions
			{
				ReferenceHandler = ReferenceHandler.Preserve
			};
			var assosiations = assosiationRepo.FindAll();
			var assosiationsAddresses = assosiations.Select(a => a.Address).ToArray();
			ViewBag.assosiations = JsonSerializer.Serialize(assosiationsAddresses, options);

			var insurances = insuranceRepo.FindAll();
			var insuranceNames = insurances.Select(a => a.Name).ToArray();
			ViewBag.insurances = JsonSerializer.Serialize(insuranceNames, options);
			return View("AddPharmacy");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPharmacy(AddPharmacyViewModel newpharmacy)
        {
            if (ModelState.IsValid)
            {
                var pharmacy = new Pharmacy();
                pharmacy.Name = newpharmacy.PharmacyName;
                pharmacy.OpenTime = TimeOnly.FromTimeSpan(newpharmacy.OpenTime);
                pharmacy.CloseTime = TimeOnly.FromTimeSpan(newpharmacy.CloseTime);
                foreach (var phone in newpharmacy.PhoneNumbers)
                {
                    var phonenumber = new PharmacyPhone()
                    {
                        PhoneNumber = phone,
                        PharmacyId = pharmacy.pharmacyId
                    };
                    pharmacy.PhoneNumbers.Add(phonenumber);

                }
                foreach (var address in newpharmacy.Addresses)
                {
                    var Address = new PharmacyAddress()
                    {
                        Address = address,
                        PharmacyId = pharmacy.pharmacyId
                    };
                    pharmacy.addresses.Add(Address);

                }
                var addedAssosiations = new HashSet<int>();
                for (int i = 0; i < newpharmacy.AssosiationBranches.Count; i++)
                {
                    var branch = newpharmacy.AssosiationBranches[i];
                    var discound = newpharmacy.AssosiationDiscounds[i];

                    // Find the corresponding AssosiationId for the current branch
                    var assosiationId = assosiationRepo.FindAll().First(d => d.Address == branch).AssosiationId;
                    if (assosiationId != null && !addedAssosiations.Contains(assosiationId))
                    {
                        // Create a new PharmacyAssosiationDiscount for the current branch and discount
                        var Discound = new PharmacyAssosiationDiscount()
                        {
                            AssosiationId = assosiationId,
                            DiscountPrecentage = discound,
                            PharmacyId = pharmacy.pharmacyId
                        };

                        // Add the discount to the pharmacy
                        pharmacy.AssosiationBranches.Add(Discound);
                        addedAssosiations.Add(assosiationId);
                    }
                }
                var addedinsurance= new HashSet<int>();
                for (int i = 0; i < newpharmacy.Insurances.Count; i++)
                {
                    var insurance = newpharmacy.Insurances[i];
                    var discound = newpharmacy.InsuranceDiscounds[i];

                    var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;
                    if (insuranceId != null && !addedinsurance.Contains(insuranceId))
                    {
                        var Discound = new PharmacyInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            PharmacyId = pharmacy.pharmacyId
                        };

                        pharmacy.insurances.Add(Discound);
                        addedinsurance.Add(insuranceId);
                    }
                }

                pharmacyRepo.AddOne(pharmacy);
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditPharmacy(int id)
        {
			var pharmacy = pharmacyRepo.FindById(id);
			EditPharmacyViewModel model = new EditPharmacyViewModel();
			model.pharmacyid = pharmacy.pharmacyId;
			model.PharmacyName = pharmacy.Name;
			model.OpenTime = pharmacy.OpenTime.ToTimeSpan();
			model.CloseTime = pharmacy.CloseTime.ToTimeSpan();
			foreach (var phone in pharmacy.PhoneNumbers)
			{
				model.PhoneNumbers.Add(phone.PhoneNumber);
			}
			foreach (var address in pharmacy.addresses)
			{
				model.Addresses.Add(address.Address);
			}
			foreach (var assosiation in pharmacy.AssosiationBranches)
			{
				model.AssosiationBranches.Add(assosiation.Assosiation.Address);
				model.AssosiationDiscounds.Add(assosiation.DiscountPrecentage);
			}
			foreach (var insurance in pharmacy.insurances)
			{
				model.Insurances.Add(insurance.Insurance.Name);
				model.InsuranceDiscounds.Add(insurance.DiscountPrecentage);
			}

			return View("EditPharmacy", model);
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPharmacy(int id,EditPharmacyViewModel NewPharmacy)
        {
            if (ModelState.IsValid)
            {
                var pharmacy = pharmacyRepo.FindById(id);
                if (pharmacy != null)
                {
                    pharmacy.OpenTime = TimeOnly.FromTimeSpan(NewPharmacy.OpenTime);
                    pharmacy.CloseTime = TimeOnly.FromTimeSpan(NewPharmacy.CloseTime);
                    pharmacy.PhoneNumbers.Clear();
                    foreach (var phone in NewPharmacy.PhoneNumbers)
                    {
                        var phonenumber = new PharmacyPhone()
                        {
                            PhoneNumber = phone,
                            PharmacyId = pharmacy.pharmacyId
                        };
                        pharmacy.PhoneNumbers.Add(phonenumber);

                    }
                    pharmacy.addresses.Clear();
                    foreach (var address in NewPharmacy.Addresses)
                    {
                        var Address = new PharmacyAddress()
                        {
                            Address = address,
                            PharmacyId = pharmacy.pharmacyId
                        };
                        pharmacy.addresses.Add(Address);

                    }

                    pharmacy.AssosiationBranches.Clear();
                    for (int i = 0; i < NewPharmacy.AssosiationBranches.Count; i++)
                    {
                        var branch = NewPharmacy.AssosiationBranches[i];
                        var discound = NewPharmacy.AssosiationDiscounds[i];

                        // Find the corresponding AssosiationId for the current branch
                        var assosiationId = assosiationRepo.FindAll().First(d => d.Address == branch).AssosiationId;

                        // Create a new PharmacyAssosiationDiscount for the current branch and discount
                        var Discound = new PharmacyAssosiationDiscount()
                        {
                            AssosiationId = assosiationId,
                            DiscountPrecentage = discound,
                            PharmacyId = pharmacy.pharmacyId
                        };

                        // Add the discount to the pharmacy
                        pharmacy.AssosiationBranches.Add(Discound);
                    }
                    pharmacy.insurances.Clear();
                    for (int i = 0; i < NewPharmacy.Insurances.Count; i++)
                    {
                        var insurance = NewPharmacy.Insurances[i];
                        var discound = NewPharmacy.InsuranceDiscounds[i];

                        var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;

                        var Discound = new PharmacyInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            PharmacyId = pharmacy.pharmacyId
                        };

                        pharmacy.insurances.Add(Discound);
                    }

                    pharmacyRepo.UpdateOne(pharmacy);
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult DeletePharmacy(int id)
        {
            var pharmacy=pharmacyRepo.FindById(id);
            pharmacyRepo.DeleteOne(pharmacy);
            return RedirectToAction("Index");
        }
    }
}
