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
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleStore}")]
    public class ProductController : Controller
    {
        private readonly ICRUDRepo<Product> productrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
        private readonly IWebHostEnvironment hosting;
        private readonly ISftpService sftpService;

        public ProductController(ICRUDRepo<Product> productrepo, ICRUDRepo<AssosiationBranch> assosiation_crud, IWebHostEnvironment hosting,ISftpService sftpService)
        {
            this.productrepo = productrepo;
            assosiation_Crud = assosiation_crud;
            this.hosting = hosting;
            this.sftpService = sftpService;
        }
        public IActionResult Index()
        {
            var productsList = productrepo.FindAll();
            return View(productsList);
        }
        public IActionResult Details(int id)
        {
            var product = productrepo.FindById(id, "Images");
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

                //string imageFolder = Path.Combine(hosting.WebRootPath, "images");
                //string imagePath = Path.Combine(imageFolder, NewProductData.Product_Image.FileName);
                //NewProductData.Product_Image.CopyTo(new FileStream(imagePath, FileMode.Create));
                //var Image = new ProductImage()
                //{
                //    ImagePath = NewProductData.Product_Image.FileName,
                //    ProductId=product.ProductId
                //};

               var filename = Guid.NewGuid().ToString() + Path.GetExtension(NewProductData.Product_Image.FileName);
                sftpService.UploadFile("/wwwroot/wwwroot/images", filename, NewProductData.Product_Image.OpenReadStream());
                var Image = new ProductImage()
                {
                    ImagePath = Path.Combine(filename),
                    ProductId = product.ProductId
                };

                product.Name = NewProductData.Name;
                product.Details = NewProductData.Details;
                product.Price = NewProductData.Price;
                product.Images.Add(Image);
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
            EditProductViewModel ProductView = new EditProductViewModel();
            ProductView.Id = product.ProductId;
            ProductView.Name = product.Name;
            ProductView.Details = product.Details;
            ProductView.Price = product.Price;

            return View("EditProduct",ProductView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editproduct(int id, EditProductViewModel newdata)
        {
            if (ModelState.IsValid)
            {
                var product = productrepo.FindById(id);

                product.Name = newdata.Name;
                product.Details = newdata.Details;
                product.Price = newdata.Price;
                productrepo.UpdateOne(product);

                return RedirectToAction("Index");
            }
            return View("EditProduct", newdata);
        }
        public IActionResult Deleteproduct(int id)
        {
            var product = productrepo.FindById(id);
            productrepo.DeleteOne(product);
            return RedirectToAction("Index");
        }
    }
}
