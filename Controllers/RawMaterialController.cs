using Egyptian_association_of_cieliac_patients.IdentityModels;
using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleStore}")]
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
            var material = materialrepo.FindById(Id, "Images");
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
                
					string ImageFolder = Path.Combine(hosting.WebRootPath, "images");
					string ImagePath = Path.Combine(ImageFolder, NewMaterialData.Material_Image.FileName);
					NewMaterialData.Material_Image.CopyTo(new FileStream(ImagePath, FileMode.Create));
                    var Image = new RawMaterialImage()
                    {
                        ImagePath = NewMaterialData.Material_Image.FileName,
                        MaterialId = material.MaterialId
                    };
                material.Name = NewMaterialData.Name;
                material.Details = NewMaterialData.Details;
                material.Price = NewMaterialData.Price;
                material.Images.Add(Image);
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
            EditRawMaterialViewModel MaterialView = new EditRawMaterialViewModel();
            MaterialView.Id = material.MaterialId;
            MaterialView.Name = material.Name;
            MaterialView.Details = material.Details;
            MaterialView.Price = material.Price;

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
