using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using NJInsurancePlatform.Models;
using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Interfaces;

namespace NJInsurancePlatform.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        //private readonly iPolicyRepository policyRepository;
        private readonly iFaqRepository faqRepository;

        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, iFaqRepository faqRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.faqRepository = faqRepository;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Customer");
            }

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult SignUp()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {

                // assign new record to "user" 
                // assign value from input field
                var user = new ApplicationUser
                {
                    CustomerMUID = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DOB = model.DOB,
                    UserName = model.UserName,
                    PhoneNumber = model.PhoneNumber,
                    CurrentAddress = model.CurrentAddress,
                    CurrentCity = model.CurrentCity,
                    CurrentZipcode = model.CurrentZipcode,
                    CurrentState = model.CurrentState,
                    CurrentEmployer = model.CurrentEmployer,
                    SSN = model.SSN,
                    LicenseNumber = model.LicenseNumber,
                    IsPrimaryPolicyHolder = model.IsPrimaryPolicyHolder,
                    Gender = model.Gender,
                    CreatedDate = model.CreatedDate
                };

                // Create new record in "(user, model.Password)". user = UserName, model.Password = Password
                var result = await userManager.CreateAsync(user, model.PasswordHash);

                // If Creation is Successful
                if (result.Succeeded)
                {
                    // Sign allow access. in "(isPersistent: false)" Means remove Cookie On sign out
                    await signInManager.SignInAsync(user, isPersistent: false);

                    if (!User.IsInRole("Customer")){
                        await userManager.AddToRoleAsync(user, "Pending");
                    }

                    return RedirectToAction("Index", "Home");
                }

                // If creation is NOT successful,
                // Password Exceptions Will appear in red
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Sign in with "signInManager". 
                // Get UserName and Password from View Input fields
                // is Persistent will be false. (We don't want to save Cookie)
                // last false is to prevent lockout if credentials are incorrect.
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.PasswordHash, isPersistent: false, false);


                // If Login is Successful
                if (result.Succeeded)
                {
                    var user = await userManager.FindByNameAsync(model.UserName);           // Assign UserName to a variable for the purpose Of checking Role Status Later

                    // If Admin Signs In, Redirect To Roles Page
                    if (await userManager.IsInRoleAsync(user, "Admin")) return RedirectToAction("GetRoles", "Administration");
                    if (await userManager.IsInRoleAsync(user, "Beneficiary")) return RedirectToAction("Index", "Customer");
                    if (await userManager.IsInRoleAsync(user, "Customer")) return RedirectToAction("Index", "Customer");
                    return RedirectToAction("Index", "Customer");
                }

                // If Model is not valid
                ModelState.AddModelError(String.Empty, "Invalid Login Attempt");


            }
            //// If user forgot password
            //if()
            return View(model);
        }



        [AllowAnonymous]
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AllowAnonymous]
        public IActionResult Message()
        {
            //MessagesViewModel messages = new MessagesViewModel();
            //messages.groupRooms = Gro
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> FAQ()
        {
            var getFaqs = await faqRepository.GetFaqs();

            List<Faq> faqs = new List<Faq>();

            foreach (var faq in getFaqs)
            {
                faqs.Add(faq);
            };
            System.Diagnostics.Debug.WriteLine(faqs);
            return View(faqs);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> FAQ(Faq faq)
        {
            var FaqMUID = new Guid(faq.FaqMUID.ToString());
            faqRepository.DeleteFaq(FaqMUID);
            faqRepository.Save();
            return RedirectToAction("Index", "Home");
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult CreateFAQ()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateFAQ(Faq model)
        {
            var faq = new Faq
            {
                FaqMUID = model.FaqMUID,
                Question = model.Question,
                Answer = model.Answer
            };
        
            faqRepository.InsertFaq(faq);
            faqRepository.Save();
            return RedirectToAction("FAQ", "Home");

        }

    }
}