using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICRUDRepo<Product> productrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
        private readonly IWebHostEnvironment hosting;

        public ProductController(ICRUDRepo<Product> productrepo, ICRUDRepo<AssosiationBranch> assosiation_crud, IWebHostEnvironment hosting)
        {
            this.productrepo = productrepo;
            assosiation_Crud = assosiation_crud;
            this.hosting = hosting;
        }
        public IActionResult Index()
        {
            var productsList = productrepo.FindAll();
            return View(productsList);
        }
        public IActionResult Details(int id)
        {
            var product = productrepo.FindById(id, "ProductImage");
            return View(product);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            return View("AddProduct");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(AddProductViewModel NewProductData)
        {
            if (ModelState.IsValid)
            {
                var product = new Product();
				if (NewProductData.Product_Image != null)
                {
                    string ImageFolder = Path.Combine(hosting.WebRootPath, "images");
                    string ImagePath = Path.Combine(ImageFolder, NewProductData.Product_Image.FileName);
                    NewProductData.Product_Image.CopyTo(new FileStream(ImagePath, FileMode.Create));
                    ImagePath = NewProductData.Product_Image.FileName;
                }
                product.Name = NewProductData.Name;
                product.Details = NewProductData.Details;
                product.Price = NewProductData.Price;
                productrepo.AddOne(product);
                return RedirectToAction("Index");

            }
            return View("AddProduct",NewProductData);
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            ViewBag.assosiations = assosiation_Crud.FindAll().ToList();
            var product = productrepo.FindById(id);
            AddProductViewModel ProductView = new AddProductViewModel();
            ProductView.Id = product.ProductId;
            ProductView.Name = product.Name;
            ProductView.Details = product.Details;
            ProductView.Price = product.Price;

            return View("EditProduct",ProductView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editproduct(int id, AddProductViewModel newdata)
        {
            var product = productrepo.FindById(id);

            product.Name = newdata.Name;
            product.Details = newdata.Details;
            product.Price = newdata.Price;
            productrepo.UpdateOne(product);

            return RedirectToAction("Index");
        }
        public IActionResult Deleteproduct(int id)
        {
            var product = productrepo.FindById(id);
            productrepo.DeleteOne(product);
            return RedirectToAction("Index");
        }
    }
}
