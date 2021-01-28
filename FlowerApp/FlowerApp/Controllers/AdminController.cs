﻿using FlowerApp.Auth;
using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Controllers
{
    [Authorize(Roles = "Administrators")]
    public class AdminController : Controller
    {
        private const string UManagement = "UserManagement";
        private const string RManagement = "RoleManagement";
        private const string FManagement = "FlowerManagement";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IFlowerRepository _flowerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AdminController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IFlowerRepository flowerRepository,
            ICategoryRepository categoryRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _flowerRepository = flowerRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            var users = _userManager.Users;

            return View(users);
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            if (!ModelState.IsValid)
                return View(addUserViewModel);

            var user = new ApplicationUser()
            {
                UserName = addUserViewModel.UserName,
                Email = addUserViewModel.Email,
                Birthdate = addUserViewModel.Birthdate,
                City = addUserViewModel.City,
                Country = addUserViewModel.Country
            };

            IdentityResult result = await _userManager.CreateAsync(user, addUserViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction(UManagement, _userManager.Users);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(addUserViewModel);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return RedirectToAction(UManagement, _userManager.Users);
            var claims = await _userManager.GetClaimsAsync(user);
            var vm = new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                UserClaims = claims.Select(c => c.Value).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel editUserViewModel)
        {
            var user = await _userManager.FindByIdAsync(editUserViewModel.Id);

            if (user != null)
            {
                user.Email = editUserViewModel.Email;
                user.UserName = editUserViewModel.UserName;
                user.Birthdate = editUserViewModel.Birthdate;
                user.City = editUserViewModel.City;
                user.Country = editUserViewModel.Country;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                    return RedirectToAction(UManagement, _userManager.Users);

                ModelState.AddModelError("", "User not updated, something went wrong.");

                return View(editUserViewModel);
            }

            return RedirectToAction(UManagement, _userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction(UManagement);
                else
                    ModelState.AddModelError("", "Something went wrong while deleting this user.");
            }
            else
            {
                ModelState.AddModelError("", "This user can't be found");
            }
            return View(UManagement, _userManager.Users);
        }

        //Roles management
        public IActionResult RoleManagement()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        public IActionResult AddNewRole() => View();

        [HttpPost]
        public async Task<IActionResult> AddNewRole(AddRoleViewModel addRoleViewModel)
        {

            if (!ModelState.IsValid)
                return View(addRoleViewModel);

            var role = new IdentityRole
            {
                Name = addRoleViewModel.RoleName
            };

            IdentityResult result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(addRoleViewModel);
        }

        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
                return RedirectToAction(RManagement, _roleManager.Roles);

            var editRoleViewModel = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name,
                Users = new List<string>()
            };


            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                    editRoleViewModel.Users.Add(user.UserName);
            }

            return View(editRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel editRoleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(editRoleViewModel.Id);

            if (role != null)
            {
                role.Name = editRoleViewModel.RoleName;

                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                    return RedirectToAction(RManagement, _roleManager.Roles);

                ModelState.AddModelError("", "Role not updated, something went wrong.");

                return View(editRoleViewModel);
            }

            return RedirectToAction(RManagement, _roleManager.Roles);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction(RManagement, _roleManager.Roles);
                ModelState.AddModelError("", "Something went wrong while deleting this role.");
            }
            else
            {
                ModelState.AddModelError("", "This role can't be found.");
            }
            return View(RManagement, _roleManager.Roles);
        }

        //Users in roles

        public async Task<IActionResult> AddUserToRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
                return RedirectToAction(RManagement, _roleManager.Roles);

            var addUserToRoleViewModel = new UserRoleViewModel { RoleId = role.Id };

            foreach (var user in _userManager.Users)
            {
                if (!await _userManager.IsInRoleAsync(user, role.Name))
                {
                    addUserToRoleViewModel.Users.Add(user);
                }
            }

            return View(addUserToRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleViewModel userRoleViewModel)
        {
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            var result = await _userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(userRoleViewModel);
        }

        public async Task<IActionResult> DeleteUserFromRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
                return RedirectToAction(RManagement, _roleManager.Roles);

            var addUserToRoleViewModel = new UserRoleViewModel { RoleId = role.Id };

            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    addUserToRoleViewModel.Users.Add(user);
                }
            }

            return View(addUserToRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserFromRole(UserRoleViewModel userRoleViewModel)
        {
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            var result = await _userManager.RemoveFromRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(userRoleViewModel);
        }

        //Flower management
        public IActionResult FlowerManagement()
        {
            var dbFlowers = _flowerRepository.Flowers;

            List<FlowerViewModel> flowers = new List<FlowerViewModel>();

            foreach (var dbFlower in dbFlowers)
            {
                flowers.Add(MapDbFlowerToFlowerViewModel(dbFlower));
            }

            return View(flowers);
        }

        public IActionResult AddFlower()
        {
            ViewData["categories"] = _categoryRepository.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddFlower(AddFlowerViewModel addFlowerViewModel)
        {
            if (!ModelState.IsValid)
                return View(addFlowerViewModel);

            var flower = new Flower()
            {
                Name = addFlowerViewModel.Name,
                ShortDescription = addFlowerViewModel.ShortDescription,
                LongDescription = addFlowerViewModel.LongDescription,
                Price = addFlowerViewModel.Price,
                ImageUrl = addFlowerViewModel.ImageUrl,
                ImageThumbnailUrl = addFlowerViewModel.ImageThumbnailUrl,
                IsFlowerPresentation = addFlowerViewModel.IsFlowerPresentation,
                InStock = addFlowerViewModel.InStock,
                CategoryId = addFlowerViewModel.CategoryId,

            };

            _flowerRepository.AddFlower(flower);

            return RedirectToAction(FManagement, _flowerRepository.Flowers);
        }

        [HttpPost]
        public IActionResult DeleteFlower(int id)
        {
            Flower flower = _flowerRepository.GetFlowerById(id);
            if (flower != null)
            {
                _flowerRepository.DeleteFlower(flower);

                return View(FManagement, _flowerRepository.FlowersAsViewModel);
            }
            else
            {
                ModelState.AddModelError("", "This flower can't be found.");
            }

            return View(FManagement, _flowerRepository.FlowersAsViewModel);
        }

        public IActionResult EditFlower(int id)
        {
            ViewData["categories"] = _categoryRepository.Categories.ToList();

            var flower = _flowerRepository.GetFlowerById(id);

            if (flower == null)
                return View(FManagement, _flowerRepository.FlowersAsViewModel);

            var editFlowerViewModel = new EditFlowerViewModel
            {
                Name = flower.Name,
                ShortDescription = flower.ShortDescription,
                LongDescription = flower.LongDescription,
                Price = flower.Price,
                ImageUrl = flower.ImageUrl,
                ImageThumbnailUrl = flower.ImageThumbnailUrl,
                IsFlowerPresentation = flower.IsFlowerPresentation,
                InStock = flower.InStock,
                CategoryId = flower.CategoryId
            };

            return View(editFlowerViewModel);
        }

        [HttpPost]
        public IActionResult EditFlower(EditFlowerViewModel editFlowerViewModel)
        {
            ViewData["categories"] = _categoryRepository.Categories.ToList();

            var flower = _flowerRepository.GetFlowerById(editFlowerViewModel.Id);

            if (flower != null)
            {
                flower.Name = editFlowerViewModel.Name;
                flower.ShortDescription = editFlowerViewModel.ShortDescription;
                flower.LongDescription = editFlowerViewModel.LongDescription;
                flower.Price = editFlowerViewModel.Price;
                flower.ImageUrl = editFlowerViewModel.ImageUrl;
                flower.ImageThumbnailUrl = editFlowerViewModel.ImageThumbnailUrl;
                flower.IsFlowerPresentation = editFlowerViewModel.IsFlowerPresentation;
                flower.InStock = editFlowerViewModel.InStock;
                flower.CategoryId = editFlowerViewModel.CategoryId;

                _flowerRepository.UpdateFlower(flower);

                return RedirectToAction(FManagement, _flowerRepository.FlowersAsViewModel);
            }

            return RedirectToAction(FManagement, _flowerRepository.FlowersAsViewModel);
        }

        private FlowerViewModel MapDbFlowerToFlowerViewModel(Flower dbFlower)
        {
            return new FlowerViewModel()
            {
                FlowerId = dbFlower.FlowerId,
                Name = dbFlower.Name,
                Price = dbFlower.Price,
                ShortDescription = dbFlower.ShortDescription,
                ImageThumbnailUrl = dbFlower.ImageThumbnailUrl
            };
        }
    }
}