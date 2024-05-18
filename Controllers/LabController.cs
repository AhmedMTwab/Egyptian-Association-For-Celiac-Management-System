using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using Egyptian_association_of_cieliac_patients.ViewModels;
using static System.Net.Mime.MediaTypeNames;


namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class LabController : Controller
    {
        private readonly ICRUDRepo<Lab> labRepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiationRepo;
        private readonly ICRUDRepo<HealthInsurance> insuranceRepo;

        public LabController(ICRUDRepo<Lab> LabRepo, ICRUDRepo<AssosiationBranch> AssosiationRepo, ICRUDRepo<HealthInsurance> InsuranceRepo)
        {
            labRepo = LabRepo;
            assosiationRepo = AssosiationRepo;
            insuranceRepo = InsuranceRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult viewall()
        {
            var labs = labRepo.FindAll();
            return View(labs);
        }
        public IActionResult viewone(int id)
        {
            var lab = labRepo.FindById(id, "PhoneNumbers", "addresses", "AssosiationBranches", "insurances", "types");
            return View(lab);
        }
        [HttpGet]
        public IActionResult AddLab()
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
            return View("AddLab");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLab(AddLabViewModel newlab)
        {
            if (ModelState.IsValid)
            {
                var lab = new Lab();
                lab.Name = newlab.LabName;
                lab.OpenTime = TimeOnly.FromTimeSpan(newlab.OpenTime);
                lab.CloseTime = TimeOnly.FromTimeSpan(newlab.CloseTime);
                if(newlab.LabType == "Both")
                {
                    var type1 = new LabType()
                    {
                        Type = "Tests",
                        LabId = lab.LabId
                    };
                    lab.types.Add(type1);

                    var type2 = new LabType()
                    {
                        Type = "Radiology",
                        LabId = lab.LabId
                    };
                    lab.types.Add(type2);
                }
                else
                {
                    var type = new LabType()
                    {
                        Type = newlab.LabType,
                        LabId = lab.LabId
                    };
                    lab.types.Add(type);
                }

                foreach (var phone in newlab.PhoneNumbers)
                {
                    var phonenumber = new LabPhone()
                    {
                        PhoneNumber = phone,
                        LabId = lab.LabId
                    };
                    lab.PhoneNumbers.Add(phonenumber);

                }
                foreach (var address in newlab.Addresses)
                {
                    var Address = new LabAddress()
                    {
                        Address = address,
                        LabId = lab.LabId
                    };
                    lab.addresses.Add(Address);

                }
                var addedAssosiations = new HashSet<int>();
                for (int i = 0; i < newlab.AssosiationBranches.Count; i++)
                {
                    var branch = newlab.AssosiationBranches[i];
                    var discound = newlab.AssosiationDiscounds[i];

                    // Find the corresponding AssosiationId for the current branch
                    var assosiationId = assosiationRepo.FindAll().First(d => d.Address == branch).AssosiationId;
                    if (assosiationId != null && !addedAssosiations.Contains(assosiationId))
                    {
                        // Create a new LabAssosiationDiscount for the current branch and discount
                        var Discound = new LabAssosiationDiscount()
                        {
                            AssosiationId = assosiationId,
                            DiscountPrecentage = discound,
                            LabId = lab.LabId
                        };

                        // Add the discount to the lab
                        lab.AssosiationBranches.Add(Discound);
                        addedAssosiations.Add(assosiationId);
                    }
                }
                var addedinsurance = new HashSet<int>();
                for (int i = 0; i < newlab.Insurances.Count; i++)
                {
                    var insurance = newlab.Insurances[i];
                    var discound = newlab.InsuranceDiscounds[i];

                    var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;
                    if (insuranceId != null && !addedinsurance.Contains(insuranceId))
                    {
                        var Discound = new LabInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            LabId = lab.LabId
                        };

                        lab.insurances.Add(Discound);
                        addedinsurance.Add(insuranceId);
                    }
                }

                labRepo.AddOne(lab);
            }
            return RedirectToAction("viewall");

        }
        [HttpGet]
        public IActionResult EditLab(int id)
        {
            var lab = labRepo.FindById(id);
            EditLabViewModel model = new EditLabViewModel();
            model.Labid = lab.LabId;
            model.LabName = lab.Name;
            model.OpenTime = lab.OpenTime.ToTimeSpan();
            model.CloseTime = lab.CloseTime.ToTimeSpan();
            if (lab.types.Count > 1)
            {
                model.LabType="Both";
            }
            else
            {
                foreach (var type in lab.types)
                {
                    model.LabType=type.Type;
                }
            }
            foreach (var phone in lab.PhoneNumbers)
            {
                model.PhoneNumbers.Add(phone.PhoneNumber);
            }
            foreach (var address in lab.addresses)
            {
                model.Addresses.Add(address.Address);
            }
            foreach (var assosiation in lab.AssosiationBranches)
            {
                model.AssosiationBranches.Add(assosiation.Assosiation.Address);
                model.AssosiationDiscounds.Add(assosiation.DiscountPrecentage);
            }
            foreach (var insurance in lab.insurances)
            {
                model.Insurances.Add(insurance.Insurance.Name);
                model.InsuranceDiscounds.Add(insurance.DiscountPrecentage);
            }

            return View("EditLab", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditLab(int id, EditLabViewModel NewLab)
        {
            if (ModelState.IsValid)
            {
                var lab = labRepo.FindById(id);
                if (lab != null)
                {
                    lab.OpenTime = TimeOnly.FromTimeSpan(NewLab.OpenTime);
                    lab.CloseTime = TimeOnly.FromTimeSpan(NewLab.CloseTime);
                    lab.types.Clear();
                    if (NewLab.LabType == "Both")
                    {
                        var type1 = new LabType()
                        {
                            Type = "Tests",
                            LabId = lab.LabId
                        };
                        lab.types.Add(type1);

                        var type2 = new LabType()
                        {
                            Type = "Radiology",
                            LabId = lab.LabId
                        };
                        lab.types.Add(type2);
                    }
                    else
                    {
                        var type = new LabType()
                        {
                            Type = NewLab.LabType,
                            LabId = lab.LabId
                        };
                        lab.types.Add(type);
                    }
                   
                    lab.PhoneNumbers.Clear();
                    foreach (var phone in NewLab.PhoneNumbers)
                    {
                        var phonenumber = new LabPhone()
                        {
                            PhoneNumber = phone,
                            LabId = lab.LabId
                        };
                        lab.PhoneNumbers.Add(phonenumber);

                    }
                    lab.addresses.Clear();
                    foreach (var address in NewLab.Addresses)
                    {
                        var Address = new LabAddress()
                        {
                            Address = address,
                            LabId = lab.LabId
                        };
                        lab.addresses.Add(Address);

                    }

                    lab.AssosiationBranches.Clear();
                    for (int i = 0; i < NewLab.AssosiationBranches.Count; i++)
                    {
                        var branch = NewLab.AssosiationBranches[i];
                        var discound = NewLab.AssosiationDiscounds[i];

                        // Find the corresponding AssosiationId for the current branch
                        var assosiationId = assosiationRepo.FindAll().First(d => d.Address == branch).AssosiationId;

                        // Create a new LabAssosiationDiscount for the current branch and discount
                        var Discound = new LabAssosiationDiscount()
                        {
                            AssosiationId = assosiationId,
                            DiscountPrecentage = discound,
                            LabId = lab.LabId
                        };

                        // Add the discount to the lab
                        lab.AssosiationBranches.Add(Discound);
                    }
                    lab.insurances.Clear();
                    for (int i = 0; i < NewLab.Insurances.Count; i++)
                    {
                        var insurance = NewLab.Insurances[i];
                        var discound = NewLab.InsuranceDiscounds[i];

                        var insuranceId = insuranceRepo.FindAll().First(d => d.Name == insurance).InsuranceId;

                        var Discound = new LabInsuranceDiscount()
                        {
                            InsuranceId = insuranceId,
                            DiscountPrecentage = discound,
                            LabId = lab.LabId
                        };

                        lab.insurances.Add(Discound);
                    }

                    labRepo.UpdateOne(lab);
                }
            }

            return RedirectToAction("viewall");
        }
        public IActionResult DeleteLab(int id)
        {
            var lab = labRepo.FindById(id);
            labRepo.DeleteOne(lab);
            return RedirectToAction("viewall");
        }
    }
}
