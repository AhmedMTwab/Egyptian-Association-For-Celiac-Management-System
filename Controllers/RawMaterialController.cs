using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class RawMaterialController : Controller
    {
        private readonly ICRUDRepo<RawMaterial> materialrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
        private readonly IWebHostEnvironment hosting;

        public RawMaterialController(ICRUDRepo<RawMaterial> materialrepo, ICRUDRepo<AssosiationBranch> assosiation_crud, IWebHostEnvironment hosting)
        {
            this.materialrepo = materialrepo;
            assosiation_Crud = assosiation_crud;
            this.hosting = hosting;
        }
       

        public IActionResult Index()
        {
            var materialsList = materialrepo.FindAll();
            return View(materialsList);
        }

        public IActionResult Details(int Id)
        {
            var material = materialrepo.FindById(Id, "RawMaterialImage");
            return View(material);
        }
        [HttpGet]
        public IActionResult AddMaterial()
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            return View("AddMaterial");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMaterial(AddRawMaterialViewModel NewMaterialData)
        {
            if (ModelState.IsValid)
            {
                var material = new RawMaterial();
                if(NewMaterialData.Material_Image != null)
                {
					string ImageFolder = Path.Combine(hosting.WebRootPath, "images");
					string ImagePath = Path.Combine(ImageFolder, NewMaterialData.Material_Image.FileName);
					NewMaterialData.Material_Image.CopyTo(new FileStream(ImagePath, FileMode.Create));
					ImagePath = NewMaterialData.Material_Image.FileName;
				}
                material.Name = NewMaterialData.Name;
                material.Details = NewMaterialData.Details;
                material.Price = NewMaterialData.Price;
                materialrepo.AddOne(material);
                return RedirectToAction("Index");

            }
            return View("AddMaterial", NewMaterialData);
        }

        [HttpGet]
        public IActionResult EditMaterial(int id)
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            var material = materialrepo.FindById(id);
            AddRawMaterialViewModel MaterialView = new AddRawMaterialViewModel();
            MaterialView.Id = MaterialView.Id;
            MaterialView.Name = MaterialView.Name;
            MaterialView.Details = MaterialView.Details;
            MaterialView.Price = MaterialView.Price;

            return View("EditMaterial", MaterialView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMaterial(int id, AddRawMaterialViewModel newdata)
        {
            var material = materialrepo.FindById(id);

            material.Name = newdata.Name;
            material.Details = newdata.Details;
            material.Price = newdata.Price;
            materialrepo.UpdateOne(material);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteMaterial(int id)
        {
            var material = materialrepo.FindById(id);
            materialrepo.DeleteOne(material);
            return RedirectToAction("Index");
        }
    }
}
