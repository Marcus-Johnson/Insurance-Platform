using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Controllers
{
    [Authorize(Roles = "Admin")] // NEED TO CREAT ROLE THEN RENABLE
    //[AllowAnonymous]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        // Create a Contructure to Inject RoleManager Service
        // Pass Identity Role as generic argument to Role Manager Class
        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]                                                                        // Routes user to create Role login (If Authorized)
        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpPost]                                                                        // Post to database
        public async Task <IActionResult> CreateRole(CreateRoleViewModel model)          // Binding did not work in this context
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole()                              // create a new instance of identity
                {
                    Name = model.RoleName,                                                  // pass "RoleName" from input field in the View
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);       // add new role to database

                if (result.Succeeded)                                 
                {
                    return RedirectToAction("GetRoles", "Administration");                      // Reroute to (Action, Controller)
                }

                foreach (var error in result.Errors)                                            // if there is an error loop through Errors stored in "result"
                {
                    ModelState.AddModelError(string.Empty, error.Description);               //  utilize "asp-validate-summary" in View to show errors
                }
            }
            return View(model);
        }

        
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult GetRoles()                                                          // Method to get all roles
        {
            var roles = roleManager.Roles;                                                        // Assign Roles to a variable
            return View(roles);                                                                    // Pass value as "IEnumberable<IdentityRole>" To The View
        }


        [HttpGet]
        public async Task<IActionResult> EditRole(string Id)
        {
            var role = await roleManager.FindByIdAsync(Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"the role with id {Id} was not found";
                return View("notfound");
            }

            var model = new EditRoleModelView()         //  
            {
                Id = role.Id,
                RoleName = role.Name,
            };

            // Because we iterating Registerd Users As Well As Roles, We Need To enable "Multiple Results" ---> Add "MultipleActiveResultSets=true" To Connect String
            foreach (var user in userManager.Users)                             // Loop through Registered "Users"
            {

                if (await userManager.IsInRoleAsync(user, role.Name))           //  Check if 'user' is assigned to given 'role'
                {
                    model.Users.Add(user.UserName);                             // Add user to the "EditRoleModel.Users" collection
                }   
            }
            return View(model);
        }


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
                role.Name = model.RoleName;                                         // Reassign Value of "Role.Name"
                var result = await roleManager.UpdateAsync(role);                   // Update Roles Table

                if (result.Succeeded)
                {
                    return RedirectToAction("GetRoles");                            // If it action is successful, let go back to list of roles and take a look
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);      // If There is an error, iterate through Errors and Print them in View
                }
            }
            return View(model);                                                     // Default to "Edit Role" To See Validation Errors
        }



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


        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;                                                // store roleId in "ViewBag" To acces in the view
            var role = await roleManager.FindByIdAsync(roleId);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"Role with id of {roleId} NOT FOUND";
            }

            var model = new List<UserRoleViewModel>();

            foreach(var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    Userid = user.Id,
                    userName = user.UserName,
                };

                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)        // Note: "string roleId" Parameter is coming from the url

        {
            var role = await roleManager.FindByIdAsync(roleId);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id {roleId} Cannot BE FOUND";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].Userid);
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

                if (result.Succeeded)                                                                           // If Added or Deleted Successfully
                {
                    if (i < (model.Count - 1)) continue;                                                        // AND iteration is NOT complete, continue to next iteration
                    else return RedirectToAction("EditRole", new {id = role.Id});                               // If iteration is complete redirect to Current Role using "role.Id"
                }
            }   
            return RedirectToAction("EditRole", new { id = role.Id });                                          //If Nothing is selected, redirect to Edit Role View
        }

        // ACCESS DENIED
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }


    }
}
