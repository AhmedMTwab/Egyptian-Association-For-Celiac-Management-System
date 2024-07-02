using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Drawing;
using Microsoft.AspNetCore.Authorization;
using Egyptian_association_of_cieliac_patients.IdentityModels;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleDoctor}")]
    public class DisesController : Controller
    {
        private readonly ICRUDRepo<Dises> disesrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
        private readonly IWebHostEnvironment hosting;

        public DisesController(ICRUDRepo<Dises> disesrepo, ICRUDRepo<AssosiationBranch> assosiation_crud, IWebHostEnvironment hosting)
        {
            this.disesrepo = disesrepo;
            assosiation_Crud = assosiation_crud;
            this.hosting = hosting;
        }
        public IActionResult Index()
        {
            var disesList = disesrepo.FindAll();
            return View(disesList);
        }
        public IActionResult Details(int id)
        {
            var dises = disesrepo.FindById(id);
            return View(dises);
        }
        [HttpGet]
        public IActionResult Adddises()
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            return View("Adddises");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Adddises(AddDisesViewModel NewDisesData)
        {
            if (ModelState.IsValid)
            {
                var dises = new Dises();
                
                dises.Name = NewDisesData.Name;
                disesrepo.AddOne(dises);
                return RedirectToAction("Index");

            }
            return View("AddDises",NewDisesData);
        }

        [HttpGet]
        public IActionResult Editdises(int id)
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            var dises = disesrepo.FindById(id);
            EditDisesViewModel DisesView = new EditDisesViewModel();
            DisesView.DisesId = dises.DisesId;
            DisesView.Name = dises.Name;

            return View("EditDises",DisesView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editdises(int id, AddProductViewModel newdata)
        {
            var dises = disesrepo.FindById(id);

            dises.Name = newdata.Name;
            disesrepo.UpdateOne(dises);

            return RedirectToAction("Index");
        }
        public IActionResult Deletedises(int id)
        {
            var dises = disesrepo.FindById(id);
            disesrepo.DeleteOne(dises);
            return RedirectToAction("Index");
        }
    }
}
