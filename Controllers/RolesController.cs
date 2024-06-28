﻿using Egyptian_association_of_cieliac_patients.IdentityModels;
using Egyptian_association_of_cieliac_patients.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Egyptian_association_of_cieliac_patients.Controllers
{
    [Authorize(Roles = Roles.roleAdmin)]
    public class RolesController : Controller
    {
        public RolesController(UserManager<IdentityUser> user, RoleManager<IdentityRole> roles)
        {
            _user = user;
            _roles = roles;
        }

        private readonly UserManager<IdentityUser> _user;
        private readonly RoleManager<IdentityRole> _roles;

        public async Task<IActionResult> Index()
        {
            var _users = await _user.Users.ToListAsync();
            return View(_users);
        }
        [HttpGet]
        public async Task<IActionResult> AddRoles(string userId)
        {
            var user = await _user.FindByIdAsync(userId);
            var userRoles = await _user.GetRolesAsync(user);

            var allRoles = await _roles.Roles.ToListAsync();
            if (allRoles != null)
            {
                var roleList = allRoles.Select(r => new RoleViewModel()
                {
                    RoleId = r.Id,
                    RoleName = r.Name,
                    UseRole = userRoles.Any(x => x == r.Name)
                });
                ViewBag.userName = user.UserName;
                ViewBag.userId = userId;
                return View(roleList);
            }
            else
                return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRoles(string userId, string jsonRoles)
        {
            var user = await _user.FindByIdAsync(userId);

            List<RoleViewModel> myRoles =
                JsonConvert.DeserializeObject<List<RoleViewModel>>(jsonRoles);

            if (user != null)
            {
                var userRoles = await _user.GetRolesAsync(user);

                foreach (var role in myRoles)
                {
                    if (userRoles.Any(x => x == role.RoleName.Trim()) && !role.UseRole)
                    {
                        await _user.RemoveFromRoleAsync(user, role.RoleName.Trim());
                    }

                    if (!userRoles.Any(x => x == role.RoleName.Trim()) && role.UseRole)
                    {
                        await _user.AddToRoleAsync(user, role.RoleName.Trim());
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            else
                return NotFound();
        }
    }
}
