using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class PatientController : Controller
    {
        private readonly ICRUDRepo<Patient> crudrepo;

        public PatientController(ICRUDRepo<Patient> crudrepo) 
        {
            this.crudrepo = crudrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult viewall()
        {
           var patientsList= crudrepo.FindAll();
            return View(patientsList);
        }
    }
}
