using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;                                       // Needed To Fake Dependency Injection
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools;
using Microsoft.AspNetCore.Http;
using NJInsurancePlatform.Controllers;
using FluentAssertions;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Tests.Controller
{
    public class HomeControllerTest
    {
        private HomeController _homeController;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        private IHttpContextAccessor _httpContextAccessor;

        public HomeControllerTest()
        {
            // Return Fake Values To Check Consistency of Data Pipeline
            _userManager = A.Fake<UserManager<ApplicationUser>>();          
            _signInManager = A.Fake<SignInManager<ApplicationUser>>();  
            _roleManager = A.Fake<RoleManager<IdentityRole>>();
            _httpContextAccessor = A.Fake<IHttpContextAccessor>();
            
            // bring in HomeController with constructor
            _homeController = new HomeController(_userManager, _signInManager, _roleManager, _httpContextAccessor);
        }

        [Fact]
        public void HomeController_Login_ReturnSuccess()
        {
            //// Arrange
            //var logonModel = new LoginViewModel() { UserName = "newUser@mymail.com", PasswordHash = "Admin123@" };

            //// Validate model state start
            //var validationContext = new ValidationContext(logonModel, null, null);
            //var validationResults = new List<ValidationResult>();

            ////set validateAllProperties to true to validate all properties; if false, only required attributes are validated.
            //Validator.TryValidateObject(logonModel, validationContext, validationResults, true);
            //foreach (var validationResult in validationResults)
            //{
            //    _homeController.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            //}
            //// Validate model state end


            //// Act
            //var result = await _homeController.Login(logonModel) as RedirectToRouteResult;

            //// Assert
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Login", result.RouteValues["action"]);
            ////Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Home", result.RouteValues["controller"]);

            //var login = _homeController.Login()
            var result = _homeController.Login() as IActionResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Details", result.);
        }
    }
}
