using Egyptian_association_of_cieliac_patients.IdentityModels;
using Egyptian_association_of_cieliac_patients.Models;
using Egyptian_association_of_cieliac_patients.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = $"{Roles.roleAdmin} , {Roles.roleDoctor}")]
    public class ReservationController : Controller
    {
        private readonly ICRUDRepo<Reservation> reservrepo;
        private readonly ICRUDRepo<AssosiationBranch> assosiation_Crud;
        private readonly IWebHostEnvironment hosting;

        public ReservationController(ICRUDRepo<Reservation> reservrepo, ICRUDRepo<AssosiationBranch> assosiation_crud, IWebHostEnvironment hosting)
        {
            this.reservrepo = reservrepo;
            assosiation_Crud = assosiation_crud;
            this.hosting = hosting;
        }
        public IActionResult Index()
        {
            var reservsList = reservrepo.FindAll();
            return View(reservsList);
        }

        public IActionResult Details(int id)
        {
            var reserve = reservrepo.FindById(id);
            return View(reserve);
        }
    }
}
