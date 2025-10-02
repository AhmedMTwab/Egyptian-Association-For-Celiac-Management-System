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
    public class InsuranceController : Controller
	{
        private readonly ICRUDRepo<AssosiationBranch> assosiationRepo;
        private readonly ICRUDRepo<HealthInsurance> insuranceRepo;

        public InsuranceController(ICRUDRepo<AssosiationBranch> AssosiationRepo,ICRUDRepo<HealthInsurance> InsuranceRepo)
		{
            assosiationRepo = AssosiationRepo;
            insuranceRepo = InsuranceRepo;
        }

		public IActionResult Index()
		{
            var insure = insuranceRepo.FindAll();
            return View(insure);
        }

		public IActionResult Details(int id)
		{
			var insure = insuranceRepo.FindById(id, "addresses", "PhoneNumbers");
			return View(insure);
		}
		[HttpGet]
		public IActionResult AddInsurance()
		{

			ViewBag.assosiations = assosiationRepo.FindAll().ToList();
			return View("AddInsurance");
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddInsurance(AddInsuranceViewModel newinsure)
		{
            if (ModelState.IsValid)
            {
                var insure = new HealthInsurance();
                insure.Name = newinsure.InsuranceName;
                insure.LicenseCode = newinsure.LicenseCode;
                foreach (var phone in newinsure.PhoneNumbers)
                {
                    var phonenumber = new InsurancePhone()
                    {
                        PhoneNumber = phone,
                        InsuranceId = insure.InsuranceId
                    };
                    insure.PhoneNumbers.Add(phonenumber);
                }

                foreach (var address in newinsure.Addresses)
                {
                    var Address = new InsuranceAddress()
                    {
                        Address = address,
                        InsuranceId = insure.InsuranceId
                    };
                    insure.addresses.Add(Address);
                }

				insuranceRepo.AddOne(insure);

				return RedirectToAction("Index");
			}
                
			return View("AddInsurance", newinsure);

		}
		[HttpGet]
		public IActionResult EditInsurance(int id)
		{
			ViewBag.assosiations = assosiationRepo.FindAll().ToList();
			var insure = insuranceRepo.FindById(id);
            EditInsuranceViewModel model = new EditInsuranceViewModel();
            model.Insuranceid = id;
            model.InsuranceName = insure.Name;
            model.LicenseCode = insure.LicenseCode;
            foreach(var phone in insure.PhoneNumbers)
            {
                model.PhoneNumbers.Add(phone.PhoneNumber);
            }
            foreach (var address in insure.addresses)
            {
                model.Addresses.Add(address.Address);
            }
            return View("EditInsurance",model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditInsurance(int id,EditInsuranceViewModel NewInsure)
		{
            if (ModelState.IsValid)
            {
                var insure = insuranceRepo.FindById(id);
				
				if (insure != null) {
					List<InsurancePhone> newphones = new List<InsurancePhone>();
					insure.PhoneNumbers.Clear();
                    foreach (var phone in NewInsure.PhoneNumbers)
                    {
                        var phonenumber = new InsurancePhone()
                        {
                            PhoneNumber = phone,
                            InsuranceId = insure.InsuranceId
                        };
						newphones.Add(phonenumber);

                    }
                    insure.PhoneNumbers = newphones;

					List<InsuranceAddress> newaddresses = new List<InsuranceAddress>();
					insure.addresses.Clear();
                    foreach (var address in NewInsure.Addresses)
                    {
                        var Address = new InsuranceAddress()
                        {
                            Address = address,
                            InsuranceId = insure.InsuranceId
                        };
						newaddresses.Add(Address);

                    }
                    insure.addresses = newaddresses;

                    insuranceRepo.UpdateOne(insure);
                }
            }

			return RedirectToAction("Index");
		}
		public IActionResult DeleteInsurance(int id)
		{
            var insure=insuranceRepo.FindById(id);
            insuranceRepo.DeleteOne(insure);
			return RedirectToAction("Index");
		}
	}
}
