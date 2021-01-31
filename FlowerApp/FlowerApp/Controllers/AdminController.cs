using FlowerApp.Auth;
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
    //available to the administrator only
    [Authorize(Roles = "Administrators")]

    //create class for admin
    //base class Controller
    public class AdminController : Controller
    {
        //create constant
        //for user
        private const string UManagement = "UserManagement";
        //for role
        private const string RManagement = "RoleManagement";
        //for flower
        private const string FManagement = "FlowerManagement";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IFlowerRepository _flowerRepository;
        private readonly ICategoryRepository _categoryRepository;

        //constructor 
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

        //action result user
        public IActionResult UserManagement()
        {
            var users = _userManager.Users;
            //view users
            return View(users);
        }

        //action result for add users
        public IActionResult AddUser()
        {
            return View();
        }

        //send data to a server to create an user
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addUserViewModel);
            }
            //for user
            var user = new ApplicationUser
            {
                // add user name
                UserName = addUserViewModel.UserName,
                // add email
                Email = addUserViewModel.Email,
                // add birthdate
                Birthdate = addUserViewModel.Birthdate,
                // add city
                City = addUserViewModel.City,
                // add country
                Country = addUserViewModel.Country
            };
            // password
            IdentityResult result = await _userManager.CreateAsync(user, addUserViewModel.Password);

            //the result is succeeded
            //redirect to user management
            if (result.Succeeded)
            {
                return RedirectToAction(UManagement, _userManager.Users);
            }

            //error description
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(addUserViewModel);
        }


        //edit user
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return RedirectToAction(UManagement, _userManager.Users);
            }

            var claims = await _userManager.GetClaimsAsync(user);
            var vm = new EditUserViewModel
            {

                // user id
                Id = user.Id,
                // user email
                Email = user.Email,
                // user name
                UserName = user.UserName,
                //user claims
                UserClaims = claims.Select(c => c.Value).ToList()
            };

            return View(vm);
        }

        //sand data to a server to update user
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel editUserViewModel)
        {
            //edit by Id
            var user = await _userManager.FindByIdAsync(editUserViewModel.Id);
            //user is available
            if (user != null)
            {
                //edit email
                user.Email = editUserViewModel.Email;
                //edit user name
                user.UserName = editUserViewModel.UserName;
                //edit birthdate
                user.Birthdate = editUserViewModel.Birthdate;
                //edit city
                user.City = editUserViewModel.City;
                //edit country
                user.Country = editUserViewModel.Country;

                var result = await _userManager.UpdateAsync(user);
                //the result is succeeded
                if (result.Succeeded)
                {
                    //redirect to the list of users
                    return RedirectToAction(UManagement, _userManager.Users);
                }
                //someting went wrong
                //view a message with the problem
                ModelState.AddModelError("", "User not updated, something went wrong.");
                return View(editUserViewModel);
            }
            //redirect to the list of users
            return RedirectToAction(UManagement, _userManager.Users);
        }
        //send data to a server for delete user
        [HttpPost]
        //delete user by id
        public async Task<IActionResult> DeleteUser(string userId)
        {
            //find user by Id
            var user = await _userManager.FindByIdAsync(userId);
            //the user is valid
            if (user != null)
            {
                //delete this user
                IdentityResult result = await _userManager.DeleteAsync(user);
                //result is a success
                if (result.Succeeded)
                {
                    //rediect to the user management
                    return RedirectToAction(UManagement);
                }
                else
                {
                    //else, view a message
                    ModelState.AddModelError("", "Something went wrong while deleting this user.");
                }

            }
            else
            {
                //the user can not be found
                ModelState.AddModelError("", "This user can't be found");
            }

            //redirect to list of users
            //from user management
            return View(UManagement, _userManager.Users);
        }

        //Roles management
        public IActionResult RoleManagement()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }
        //add a new role
        public IActionResult AddNewRole() => View();

        //send data to server
        [HttpPost]
        //add role
        public async Task<IActionResult> AddNewRole(AddRoleViewModel addRoleViewModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addRoleViewModel);
            }

            // new role name
            var role = new IdentityRole
            {
                Name = addRoleViewModel.RoleName
            };

            IdentityResult result = await _roleManager.CreateAsync(role);
            //result is a success
            if (result.Succeeded)
            {
                //redirect to a role list 
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            //somthing went wrong
            foreach (IdentityError error in result.Errors)
            {
                //send an error message
                ModelState.AddModelError("", error.Description);
            }
            return View(addRoleViewModel);
        }

        //edit role 
        public async Task<IActionResult> EditRole(string id)
        {
            //find by id
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            var editRoleViewModel = new EditRoleViewModel
            {
                //edit
                //id
                Id = role.Id,
                //role
                RoleName = role.Name,
                //user
                Users = new List<string>()
            };


            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    editRoleViewModel.Users.Add(user.UserName);
                }
            }

            return View(editRoleViewModel);
        }

        //send data to server
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel editRoleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(editRoleViewModel.Id);

            if (role != null)
            {
                role.Name = editRoleViewModel.RoleName;

                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction(RManagement, _roleManager.Roles);
                }
                //something went wrong
                ModelState.AddModelError("", "Role not updated, something went wrong.");

                return View(editRoleViewModel);
            }

            return RedirectToAction(RManagement, _roleManager.Roles);
        }

        //send data to a server
        [HttpPost]
        //delete role
        public async Task<IActionResult> DeleteRole(string id)
        {
            //find role by id
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                //delete
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction(RManagement, _roleManager.Roles);
                }
                //somthing went role
                //view message
                ModelState.AddModelError("", "Something went wrong while deleting this role.");
            }
            else
            {
                //when the role can not be found
                //view message
                ModelState.AddModelError("", "This role can't be found.");
            }
            return View(RManagement, _roleManager.Roles);
        }

        //Users in roles

        public async Task<IActionResult> AddUserToRole(string roleId)
        {
            //find by role id
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }


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
        //send data to a server
        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleViewModel userRoleViewModel)
        {
            //find user by id
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            //find role by id
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            var result = await _userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            //error description
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(userRoleViewModel);
        }

        //delete user from role
        public async Task<IActionResult> DeleteUserFromRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                return RedirectToAction(RManagement, _roleManager.Roles);
            }
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

        //send data to a server
        [HttpPost]
        public async Task<IActionResult> DeleteUserFromRole(UserRoleViewModel userRoleViewModel)
        {
            //find user by id
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            //find role by id
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            var result = await _userManager.RemoveFromRoleAsync(user, role.Name);

            //rhe result is success
            if (result.Succeeded)
            {
                //redirect to role management
                return RedirectToAction(RManagement, _roleManager.Roles);
            }

            foreach (IdentityError error in result.Errors)
            {
                //something went wrong
                //show error description
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

        //send data to a server
        [HttpPost]
        //add a new flower
        public IActionResult AddFlower(AddFlowerViewModel addFlowerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addFlowerViewModel);
            }
            var flower = new Flower
            {
                //add new 
                //name
                Name = addFlowerViewModel.Name,
                //short description
                ShortDescription = addFlowerViewModel.ShortDescription,
                //long description
                LongDescription = addFlowerViewModel.LongDescription,
                //price
                Price = addFlowerViewModel.Price,
                //image url
                ImageUrl = addFlowerViewModel.ImageUrl,
                //image thumbail
                ImageThumbnailUrl = addFlowerViewModel.ImageThumbnailUrl,
                //if it appears in the main presentation
                IsFlowerPresentation = addFlowerViewModel.IsFlowerPresentation,
                //if is in stock
                InStock = addFlowerViewModel.InStock,
                //category id
                CategoryId = addFlowerViewModel.CategoryId,

            };

            _flowerRepository.AddFlower(flower);

            return RedirectToAction(FManagement, _flowerRepository.Flowers);
        }

        //send data to server
        //delete flower
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


        //edit flower
        public IActionResult EditFlower(int id)
        {
            ViewData["categories"] = _categoryRepository.Categories.ToList();

            var flower = _flowerRepository.GetFlowerById(id);

            if (flower == null)
            {
                return View(FManagement, _flowerRepository.FlowersAsViewModel);
            }

            var editFlowerViewModel = new EditFlowerViewModel
            {
                //edit
                //name
                Name = flower.Name,
                //short description
                ShortDescription = flower.ShortDescription,
                //long description
                LongDescription = flower.LongDescription,
                //price
                Price = flower.Price,
                //image
                ImageUrl = flower.ImageUrl,
                //image thumbnail
                ImageThumbnailUrl = flower.ImageThumbnailUrl,
                //if it appears in the main presenation
                IsFlowerPresentation = flower.IsFlowerPresentation,
                //if it is in stock
                InStock = flower.InStock,
                //category id
                CategoryId = flower.CategoryId
            };

            return View(editFlowerViewModel);
        }

        //send data to a server
        //edit flower
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
            return new FlowerViewModel
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