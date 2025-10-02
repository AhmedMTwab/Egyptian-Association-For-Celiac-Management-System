using Egyptian_association_of_cieliac_patients.IdentityModels;
using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleStore}")]
    public class OrderController : Controller
	{
		private readonly ICRUDRepo<Order> orderrepo;
		private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
		private readonly IWebHostEnvironment hosting;

		public OrderController(ICRUDRepo<Order> orderrepo, ICRUDRepo<AssosiationBranch> assosiation_crud, IWebHostEnvironment hosting)
		{
			this.orderrepo = orderrepo;
			assosiation_Crud = assosiation_crud;
			this.hosting = hosting;
		}
		public IActionResult Index()
		{
			var ordersList = orderrepo.FindAll();
			return View(ordersList);
		}

		public IActionResult Details(int id)
		{
			var order = orderrepo.FindById(id);
			return View(order);
		}
	}
}
