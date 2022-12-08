using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System.Data;
using System.Diagnostics;

namespace NJInsurancePlatform.Controllers
{

    //[Authorize(Roles = "Admin")] // NEED TO CREAT ROLE THEN RENABLE
    //[AllowAnonymous]
    public partial class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IPolicyRepository _policyRepository;

        // Create a Contructure to Inject RoleManager Service
        // Pass Identity Role as generic argument to Role Manager Class
        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ITransactionRepository transactionRepository,IPolicyRepository policyRepository)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this._transactionRepository = transactionRepository;
            this._policyRepository = policyRepository;
        }

        // CREATE ROLES "GET REQUEST"
        [Authorize(Roles = "Admin")]
        [HttpGet]                                                                                         // Routes user to create Role login (If Authorized)
        public IActionResult CreateRole()
        {
            return View();
        }

        // GET ROLES "POST REQUEST" ------------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpPost]                                                                                        // Post to database
        public async Task <IActionResult> CreateRole(CreateRoleViewModel model)                           // Binding did not work in this context
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole()                                            // create a new instance of identity
                {
                    Name = model.RoleName,                                                                // pass "RoleName" from input field in the View
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);                      // add new role to database

                if (result.Succeeded)                                 
                {
                    return RedirectToAction("GetRoles", "Administration");                                // Reroute to (Action, Controller)
                }

                foreach (var error in result.Errors)                                                      // if there is an error loop through Errors stored in "result"
                {
                    ModelState.AddModelError(string.Empty, error.Description);                            //  utilize "asp-validate-summary" in View to show errors
                }
            }
            return View(model);
        }


        // GET ROLES "GET REQUEST" --------------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult GetRoles()                                                                   // Method to get all roles
        {
            var roles = roleManager.Roles;                                                                // Assign Roles to a variable
            return View(roles);                                                                           // Pass value as "IEnumberable<IdentityRole>" To The View
        }



        // EDIT ROLES "GET REQUEST" --------------------------------------------------------------------------------
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public async Task<IActionResult> EditRole(string Id)
        {
            //if (Id == null) return Content("RETURN TO EDIT ROLES DASHBOARD AND CLICK ON A ROLE TO EDIT");
            var role = await roleManager.FindByIdAsync(Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"the role with id {Id} was not found";
                return View("notfound");
            }

            var model = new EditRoleModelView()        
            {
                Id = role.Id,
                RoleName = role.Name,
            };
            // Because we iterating Registerd Users As Well As Roles, We Need To enable "Multiple Results" ---> Add "MultipleActiveResultSets=true" To Connect String
            foreach (var user in userManager.Users)                                                       // Loop through Registered "Users"
            {

                if (await userManager.IsInRoleAsync(user, role.Name))                                     //  Check if 'user' is assigned to given 'role'
                {
                    model.Users.Add(user.UserName);                                                       // Add user to the "EditRoleModel.Users" collection
                }   
            }
            return View(model);
        }



        // EDIT ROLES "POST REQUEST" ----------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleModelView model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"the role with id {model.Id} was not found";
                return View("notfound");
            }
            else
            {
                role.Name = model.RoleName;                                                                 // Reassign Value of "Role.Name"
                var result = await roleManager.UpdateAsync(role);                                           // Update Roles Table

                if (result.Succeeded)
                {
                    return RedirectToAction("GetRoles");                                                    // If it action is successful, let go back to list of roles and take a look
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);                              // If There is an error, iterate through Errors and Print them in View
                }
            }
            return View(model);                                                                             // Default to "Edit Role" To See Validation Errors
        }


        // DELETE ROLES "GET REQUEST" ---------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id of {id} NOT FOUND";
                return View("NotFound");
            }

            else
            {
                var result = await roleManager.DeleteAsync(role);

                if (result.Succeeded) return RedirectToAction("GetRoles");

                foreach (var error in result.Errors)
                {

                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View("GetRoles");

            }
        }


        // EDIT USER ROLES "GET REQUEST" ------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string Id)                                       // Search role by id
        {
            if (Id != null)
            {
                ViewBag.roleId = Id;                                                                          // store roleId in "ViewBag" To acces in the view

                var role = await roleManager.FindByIdAsync(Id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with id of {Id} NOT FOUND";
                }

                var model = new List<UserRoleViewModel>();                                                        // instantiate a list of "UserRoleViewModel" Objects

                foreach (var user in userManager.Users)                                                            // create "UserRoleViewModel" Object for each user
                {
                    var userRoleViewModel = new UserRoleViewModel
                    {
                        Userid = user.Id,
                        userName = user.UserName,
                    };

                    if (await userManager.IsInRoleAsync(user, role.Name))                                          // access if user is in role
                    {
                        userRoleViewModel.IsSelected = true;
                    }
                    else
                    {
                        userRoleViewModel.IsSelected = false;
                    }

                    model.Add(userRoleViewModel);                                                                 // after "IsSelected" status is accessed, add to "model" list.
                }
                return View(model);
            } else
            {
                return RedirectToAction("Index", "Home");                                          //If Nothing is selected, redirect to current role Edit page View
            }
            // pass "model" list to the view to display "checked" or "unchecked"
        }


        // EDIT USER ROLES "POST REQUEST" ----------------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpPost]                                                                                            // when submit is clicked from "EditUsersInRole" View Model, the full list of iterated objects is passed
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string Id)        // Note: "string roleId" Parameter is coming from the url

        {
            var role = await roleManager.FindByIdAsync(Id);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id {Id} Cannot BE FOUND";
                return View("NotFound");
            }

            // iterate over the entire list of users to check the updated status of the "IsSelected" attribute
            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].Userid);                                    // check each "UserRoleViewModel" object                       
                
                IdentityResult result = null;                                                                   // Initialize null variable for result

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))                 // If User is Selected, And NOT already in this role
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);                                 // Add User To this Role
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))              // If The user is not Selected and is already in the Role
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);                            // Remove User From the role
                }
                else
                {
                    // If user is selected and is already in the role, DO NOTHING, Continue to NEXT iteration.
                    // Also if user is  NOT selected and is already in the role, DO NOTHING, Continue to NEXT iteration.
                    continue;       
                }

                // continue iteration to check "IsSelected" status until you reach the end
                if (result.Succeeded)                                                                           // After each user is added or deleted from the role, check if iteration is complete
                {
                    if (i < (model.Count - 1)) continue;                                                        // if iteration is NOT complete, continue iteration
                    else return RedirectToAction("EditRole", new {id = role.Id});                               // If iteration is complete redirect to Current Role Edit Page using "role.Id"
                }
            }   
            return RedirectToAction("EditRole", new { id = role.Id });                                          //If Nothing is selected, redirect to current role Edit page View
        }


    }
}
