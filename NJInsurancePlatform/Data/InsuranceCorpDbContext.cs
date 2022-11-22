using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Data
{
    public class InsuranceCorpDbContext : IdentityDbContext
    {
        public InsuranceCorpDbContext()
        {

        }

        public InsuranceCorpDbContext(DbContextOptions<InsuranceCorpDbContext> options) : base(options)
        {

        }

        public DbSet<GroupRoomMessage> GroupRoomMessages { get; set; }
        public DbSet<GroupRoom> GroupRooms { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;  // For the purpos of Migration
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Claim> Claims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=GFTHF-PF12QJ7D;Initial Catalog=InsuranceCorp;MultipleActiveResultSets=True;User Id=sa;Password=Galaxy@123");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // "PasswordHasher" to has "admin" user password before seeding
            var hasher = new PasswordHasher<ApplicationUser>();
            base.OnModelCreating(builder);

            var cust1 = new Guid("7e46ae9d-ff19-47da-ae69-922069555efb");
            var cust2 = new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1");
            var cust3 = new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce");
            var cust4 = new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce");

            var ben1 = new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd");
            var ben2 = new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff");
            var ben3 = new Guid("78d9cd41-acde-48fc-baa9-29b5065af159");
            var ben4 = new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1");

            var pol1 = new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea");
            var pol2 = new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5");
            var pol3 = new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f");
            var pol4 = new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d");

            var tran1 = new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018");
            var tran2 = new Guid("530f62a1-8730-4784-bb71-a257136dd9f6");
            var tran3 = new Guid("f752a2a0-7300-42ba-beab-dc65992ca945");
            var tran4 = new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da");

            var bill1 = new Guid("f46090ed-d574-4456-8e18-97150ff885ed");
            var bill2 = new Guid("417a8279-0227-43c4-8504-c4396860ada0");
            var bill3 = new Guid("c28330de-a718-465b-9772-5b28ad6395e8");
            var bill4 = new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4");

            var pay1 = new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693");
            var pay2 = new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72");
            var pay3 = new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae");
            var pay4 = new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218");

            var groupMes1 = new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237");
            var groupMes2 = new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a");
            var groupMes3 = new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d");
            var groupMes4 = new Guid("4db427d8-8084-4987-9783-ef1154a0627b");

            var group1 = new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a");
            var group2 = new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c");
            var group3 = new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1");
            var group4 = new Guid("858efa88-5226-47e5-8bd0-80546b2f469d");

            var groupSend1 = new Guid("d9ef788c-a3f8-48b3-92ce-804170aba836");
            var groupSend2 = new Guid("a7071f27-db08-47fb-a05a-0a7da44b44c4");
            var GroupSend3 = new Guid("bce87d97-e9b6-483f-8ed2-4200aeef26ba");
            var groupSend4 = new Guid("93fa9038-9c45-42cf-993b-fc3d15764f18");

            var prod1 = Guid.NewGuid();
            var prod2 = Guid.NewGuid();
            var prod3 = Guid.NewGuid();
            var prod4 = Guid.NewGuid();

            ////Seed "Admin" Role
            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
            //    Name = "Admin",
            //    NormalizedName = "ADMIN"
            //});

            ////Seed "Customer" Role
            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
            //    Name = "Customer",
            //    NormalizedName = "CUSTOMER"
            //});

            ////Seed "Beneficiary" Role
            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", // primary key
            //    Name = "Beneficiary",
            //    NormalizedName = "BENEFICIARY",
            //});




            ////Seed the "admin" User to AspNetUsers table
            //builder.Entity<ApplicationUser>().HasData(
            //    new ApplicationUser
            //    {
            //        Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
            //        UserName = "admin",
            //        EmailAddress = "admin",
            //        NormalizedUserName = "ADMIN",
            //        PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
            //    }
            //);

            ////Beneficiary
            //builder.Entity<ApplicationUser>().HasData(
            //   new ApplicationUser
            //   {
            //       Id = "8e445865-a24d-4543-a6c6-9443d048cdb8", // primary key
            //       UserName = "beneficiary",
            //       EmailAddress = "beneficiary",
            //       NormalizedUserName = "BENEFICIARY",
            //       PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
            //   }
            //);

            ////Customer
            //builder.Entity<ApplicationUser>().HasData(
            //   new ApplicationUser
            //   {
            //       Id = "8e445865-a24d-4543-a6c6-9443d048cdb7", // primary key
            //       UserName = "customer",
            //       EmailAddress = "customer",
            //       NormalizedUserName = "CUSTOMER",
            //       PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
            //   }
            //);



            ////Seeding the relation between our user and role to AspNetUserRoles table
            ////Admin
            //builder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
            //        UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            //    }
            //);

            ////Beneficiary
            //builder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212",
            //        UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"
            //    }
            //);

            ////Customer
            //builder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
            //        UserId = "8e445865-a24d-4543-a6c6-9443d048cdb7"
            //    }
            //);

            // Products
            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductMUID = prod1,
                    ProductName = "DentalGold",
                    Description = "Lorus Plorem enum taknut",
                    Price = 2343,
                    Deductible = 100.25,
                    AnnualLimitOfCoverage = 14999.99,
                    OutOfPocketLimit = 999.99,
                },
                new Product
                {
                    ProductMUID = prod2,
                    ProductName = "Health Platinum",
                    Description = "Enum Zelgar Phlnnub nilsup",
                    Price = 3343,
                    Deductible = 200.15,
                    AnnualLimitOfCoverage = 25999.99,
                    OutOfPocketLimit = 999.99,
                },
                new Product
                {
                    ProductMUID = prod3,
                    ProductName = "Eye Emerald",
                    Description = "Lorus Plorem enum taknut",
                    Price = 789,
                    Deductible = 50.67,
                    AnnualLimitOfCoverage = 1345.99,
                    OutOfPocketLimit = 1200.45,
                },
                new Product
                {
                    ProductMUID = prod4,
                    ProductName = "Empoyee Individual",
                    Description = "Bupka ladna velnup halstus",
                    Price = 1200.98,
                    Deductible = 160.69,
                    AnnualLimitOfCoverage = 5345.99,
                    OutOfPocketLimit = 5600.45,
                }
            );

            builder.Entity<Policy>().HasData(
                new Policy
                {
                    PolicyMUID = pol1,
                    PolicyNumber = 1234,
                    NameOfPolicy = "Dental Gold",
                    PolicyOwner = "Patrick Leon",
                    Deductible = 100.25,
                    OutOfPocketLimit = 999.99,
                    AnnualLimitOfCoverage = 14999.99,
                    PolicyPaymentisDue = false,
                    PolicyTotalAmount = 35000,
                    PolicyPaidOffAmount = 0,
                    PolicyStart_Date = DateTime.Now,
                    PolicyEnd_Date = DateTime.Now,
                },
                new Policy
                {
                    PolicyMUID = pol2,
                    PolicyNumber = 4567,
                    NameOfPolicy = "Health Platinum",
                    PolicyOwner = "Eric Daley",
                    Deductible = 100.25,
                    OutOfPocketLimit = 999.99,
                    AnnualLimitOfCoverage = 14999.99,
                    PolicyPaymentisDue = false,
                    PolicyTotalAmount = 35000,
                    PolicyPaidOffAmount = 0,
                    PolicyStart_Date = DateTime.Now,
                    PolicyEnd_Date = DateTime.Now,
                },
                new Policy
                {
                    PolicyMUID = pol3,
                    PolicyNumber = 78910,
                    NameOfPolicy = "Eye Emarald",
                    PolicyOwner = "Nikosi Thom",
                    Deductible = 100.25,
                    OutOfPocketLimit = 999.99,
                    AnnualLimitOfCoverage = 14999.99,
                    PolicyPaymentisDue = false,
                    PolicyTotalAmount = 35000,
                    PolicyPaidOffAmount = 0,
                    PolicyStart_Date = DateTime.Now,
                    PolicyEnd_Date = DateTime.Now,
                },
             new Policy
             {
                 PolicyMUID = pol4,
                 PolicyNumber = 769564,
                 NameOfPolicy = "Eye Emarald",
                 PolicyOwner = "Leona wilson",
                 Deductible = 100.25,
                 OutOfPocketLimit = 999.99,
                 AnnualLimitOfCoverage = 14999.99,
                 PolicyPaymentisDue = false,
                 PolicyTotalAmount = 35000,
                 PolicyPaidOffAmount = 0,
                 PolicyStart_Date = DateTime.Now,
                 PolicyEnd_Date = DateTime.Now,
             }
            );


            // Transactions
            builder.Entity<Transaction>().HasData(
                new Transaction
                {
                    TransactionMUID = tran1,
                    CustomerMUID = cust1,
                    PolicyMUID = pol1,
                    isPaymentComplete = true,
                    PaymentAmount = 1199.78,
                    PaymentDate = DateTime.Now,
                },
                new Transaction
                {
                    TransactionMUID = tran2,
                    CustomerMUID = cust2,
                    PolicyMUID = pol2,
                    isPaymentComplete = true,
                    PaymentAmount = 2109.78,
                    PaymentDate = DateTime.Now,
                },
                new Transaction
                {
                    TransactionMUID = tran3,
                    CustomerMUID = cust3,
                    PolicyMUID = pol3,
                    isPaymentComplete = false,
                    PaymentAmount = 109.08,
                    PaymentDate = DateTime.Now,
                },
                new Transaction
                {
                    TransactionMUID = tran4,
                    CustomerMUID = cust4,
                    PolicyMUID = pol4,
                    isPaymentComplete = false,
                    PaymentAmount = 189.05,
                    PaymentDate = DateTime.Now,
                }
            );

            // Bill
            builder.Entity<Bill>().HasData(
                new Bill
                {
                    BillMUID = bill1,
                    PolicyMUID = pol1,
                    PolicyDueDate = DateTime.Now,
                    MinimumPayment = 123.99,
                    CreatedDate = DateTime.Now,
                    Balance = 799.34,
                    Status = "status",
                },
                new Bill
                {
                    BillMUID = bill2,
                    PolicyMUID = pol2,
                    PolicyDueDate = DateTime.Now,
                    MinimumPayment = 283.99,
                    CreatedDate = DateTime.Now,
                    Balance = 509.34,
                    Status = "status",
                },
                new Bill
                {
                    BillMUID = bill3,
                    PolicyMUID = pol3,
                    PolicyDueDate = DateTime.Now,
                    MinimumPayment = 129.09,
                    CreatedDate = DateTime.Now,
                    Balance = 109.34,
                    Status = "status",
                },
                new Bill
                {
                    BillMUID = bill4,
                    PolicyMUID = pol4,
                    PolicyDueDate = DateTime.Now,
                    MinimumPayment = 449.09,
                    CreatedDate = DateTime.Now,
                    Balance = 278.34,
                    Status = "status",
                }
            );

            // Payment
            builder.Entity<Payment>().HasData(
                new Payment
                {
                    PaymentMUID = pay1,
                    BillMUID = bill1,
                    PaidDate = DateTime.Now,
                    Amount = 123.99,
                    PaymentMethod = "visa",
                    PayerFirstName = "Jillian",
                    PayerLastName = "Flowers",
                    CardNumber = "123498732",
                    ZipCode = "12345",
                    CardExpireDate = DateTime.Now,
                    DebitOrCredit = "debit",
                    BankName = "Spring Savings",
                    AccountNumber = "2345643",
                    RoutingNumber = "2345432",
                    CheckNumber = 123,
                    CheckImage = "check Image",
                    AdditionalInfo = "Additional info",
                    CreatedDate = DateTime.Now,
                },
                new Payment
                {
                    PaymentMUID = pay2,
                    BillMUID = bill2,
                    PaidDate = DateTime.Now,
                    Amount = 234.89,
                    PaymentMethod = "mastercard",
                    PayerFirstName = "Fred",
                    PayerLastName = "Sanders",
                    CardNumber = "123498732",
                    ZipCode = "12345",
                    CardExpireDate = DateTime.Now,
                    DebitOrCredit = "credit",
                    BankName = "Peoples Savings",
                    AccountNumber = "2345643",
                    RoutingNumber = "2345432",
                    CheckNumber = 345,
                    CheckImage = "check Image",
                    AdditionalInfo = "Additional info",
                    CreatedDate = DateTime.Now,
                },
                new Payment
                {
                    PaymentMUID = pay3,
                    BillMUID = bill3,
                    PaidDate = DateTime.Now,
                    Amount = 563.99,
                    PaymentMethod = "visa",
                    PayerFirstName = "Phillis",
                    PayerLastName = "McMahon",
                    CardNumber = "123498732",
                    ZipCode = "12345",
                    CardExpireDate = DateTime.Now,
                    DebitOrCredit = "credit",
                    BankName = "Bank of Nova Scotia",
                    AccountNumber = "2345643",
                    RoutingNumber = "2345432",
                    CheckNumber = 4532,
                    CheckImage = "check Image",
                    AdditionalInfo = "Additional info",
                    CreatedDate = DateTime.Now,
                },
                new Payment
                {
                    PaymentMUID = pay4,
                    BillMUID = bill4,
                    PaidDate = DateTime.Now,
                    Amount = 58.99,
                    PaymentMethod = "visa",
                    PayerFirstName = "katherine",
                    PayerLastName = "Rivera",
                    CardNumber = "123498732",
                    ZipCode = "12345",
                    CardExpireDate = DateTime.Now,
                    DebitOrCredit = "credit",
                    BankName = "Bank of the Oranges",
                    AccountNumber = "2345643",
                    RoutingNumber = "2345432",
                    CheckNumber = 9870,
                    CheckImage = "check Image",
                    AdditionalInfo = "Additional info",
                    CreatedDate = DateTime.Now,
                }
            );

            // Group Room messages
            builder.Entity<GroupRoomMessage>().HasData(
                new GroupRoomMessage
                {
                    GroupRoomMessageMUID = groupMes1,
                    GroupRoomMUID = group1,
                    SenderMUID = groupSend1,
                    Message = "Hello, Can you please Help Me?",
                },
                new GroupRoomMessage
                {
                    GroupRoomMessageMUID = groupMes2,
                    GroupRoomMUID = group2,
                    SenderMUID = groupSend2,
                    Message = "yes, How Can I Help you?",
                },
                new GroupRoomMessage
                {
                    GroupRoomMessageMUID = groupMes3,
                    GroupRoomMUID = group3,
                    SenderMUID = groupSend2,
                    Message = "I have a question About My Policy",
                },
                new GroupRoomMessage
                {
                    GroupRoomMessageMUID = groupMes4,
                    GroupRoomMUID = group4,
                    SenderMUID = groupSend4,
                    Message = "Sure, What would you like to know?",
                }
            );

            // build roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Beneficiary", NormalizedName = "BENEFICIARY" },
                new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" }
            };

            builder.Entity<IdentityRole>().HasData(roles);


            // Customers
            List<ApplicationUser> users = new List<ApplicationUser>()
            {
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = "admin",
                    EmailAddress = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },
               new ApplicationUser
               {
                   Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                   UserName = "customer",
                   EmailAddress = "customer",
                   NormalizedUserName = "CUSTOMER",
                   PasswordHash = hasher.HashPassword(null, "Password123@")
               },
               new ApplicationUser
               {
                   Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                   UserName = "beneficiary",
                   EmailAddress = "beneficiary",
                   NormalizedUserName = "BENEFICIARY",
                   PasswordHash = hasher.HashPassword(null, "Password123@")
               },
                new ApplicationUser
                {
                    CustomerMUID = cust1,
                    PolicyMUID = pol1,
                    FirstName = "Patrick",
                    LastName = "Leon",
                    EmailAddress = "PatrickL@mymail.com",
                    PhoneNumber = "2019878709",
                    CurrentAddress = "123 Elm street",
                    CurrentCity = "Milwaukee",
                    CurrentZipcode = "7897678",
                    CurrentState = "Wisconsin",
                    CurrentEmployer = "Alphabet Corp",
                    SSN = "123456789",
                    LicenseNumber = "39kh8087hf",
                    IsPrimaryPolicyHolder = true,
                    Gender = "male",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "Pato",
                    NormalizedUserName = "PATO",
                    PasswordHash = hasher.HashPassword(null, "Password123@")

                },
                new ApplicationUser
                {
                    CustomerMUID = cust2,
                    PolicyMUID = pol2,
                    FirstName = "Eric",
                    LastName = "Daley",
                    EmailAddress = "EricD@mymail.com",
                    PhoneNumber = "8790985467",
                    CurrentAddress = "456 main street",
                    CurrentCity = "Baltimore",
                    CurrentZipcode = "7897678",
                    CurrentState = "Maryland",
                    CurrentEmployer = "Xillon Co",
                    SSN = "123456789",
                    LicenseNumber = "39kh8087hf",
                    IsPrimaryPolicyHolder = true,
                    Gender = "male",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "EricD@mymail.com",
                    NormalizedUserName = "ERICD@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },
                new ApplicationUser
                {
                    CustomerMUID = cust3,
                    PolicyMUID = pol3,
                    FirstName = "Nikosi",
                    LastName = "Thom",
                    EmailAddress = "NikosiT@mymail.com",
                    PhoneNumber = "8790985467",
                    CurrentAddress = "789 Grove street",
                    CurrentCity = "Rockville",
                    CurrentZipcode = "7897678",
                    CurrentState = "Maryland",
                    CurrentEmployer = "techumseh International",
                    SSN = "123456789",
                    LicenseNumber = "39kh8087hf",
                    IsPrimaryPolicyHolder = true,
                    Gender = "female",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "NikosiT@mymail.com",
                    NormalizedUserName = "NIKOSIT@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },
                new ApplicationUser
                {
                    CustomerMUID = cust4,
                    PolicyMUID = pol4,
                    FirstName = "Leona",
                    LastName = "Wilson",
                    EmailAddress = "LeonaW@mymail.com",
                    PhoneNumber = "8790985467",
                    CurrentAddress = "3464 Brinkly street",
                    CurrentCity = "Gathersburg",
                    CurrentZipcode = "7897678",
                    CurrentState = "Maryland",
                    CurrentEmployer = "Brimson distributers",
                    SSN = "123456789",
                    LicenseNumber = "39kh8087hf",
                    IsPrimaryPolicyHolder = true,
                    Gender = "female",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "LeonaW@mymail.com",
                    NormalizedUserName = "LEONAW@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },

            // Beneficiaries
            //builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    BeneficiaryMUID = ben1,
                    CustomerMUID = cust1,
                    FirstName = "Andrea",
                    LastName = "Bogataw",
                    EmailAddress = "AndreaB@mymail.com",
                    PhoneNumber = "8790985467",
                    SSN = "123456789",
                    LicenseNumber = "39kh8087hf",
                    Gender = "female",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "AndreaB@mymail.com",
                    NormalizedUserName = "ANDREAB@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },
                new ApplicationUser
                {
                    BeneficiaryMUID = ben2,
                    CustomerMUID = cust2,
                    FirstName = "Cynthia",
                    LastName = "Smithers",
                    EmailAddress = "CynthiaS@mymail.com",
                    PhoneNumber = "8790985467",
                    SSN = "123456789",
                    LicenseNumber = "39k8ew8087hf",
                    Gender = "female",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "CynthiaS@mymail.com",
                    NormalizedUserName = "CYNTHIAS@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },
                new ApplicationUser
                {
                    BeneficiaryMUID = ben3,
                    CustomerMUID = cust3,
                    FirstName = "Brittney",
                    LastName = "Giles",
                    EmailAddress = "BritneyG@mymail.com",
                    PhoneNumber = "8790985467",
                    SSN = "123456789",
                    LicenseNumber = "39k8ew8087hf",
                    Gender = "female",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "BritneyG@mymail.com",
                    NormalizedUserName = "BRITNEYG@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                },
                new ApplicationUser
                {
                    BeneficiaryMUID = ben4,
                    CustomerMUID = cust4,
                    FirstName = "Joana",
                    LastName = "Martin",
                    EmailAddress = "JoanaM@mymail.com",
                    PhoneNumber = "8790985467",
                    SSN = "123456789",
                    LicenseNumber = "39k8ew8087hf",
                    Gender = "female",
                    CreatedDate = DateTime.Now,
                    Active = true,
                    UserName = "JoanaM@mymail.com",
                    NormalizedUserName = "JOANAM@MYMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123@")
                }
            };


            builder.Entity<ApplicationUser>().HasData(users);


            // Seed User in Roles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.First(q => q.Name == "Customer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = roles.First(q => q.Name == "Beneficiary").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[3].Id,
                RoleId = roles.First(q => q.Name == "Customer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[4].Id,
                RoleId = roles.First(q => q.Name == "Customer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[5].Id,
                RoleId = roles.First(q => q.Name == "Customer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[6].Id,
                RoleId = roles.First(q => q.Name == "Customer").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[7].Id,
                RoleId = roles.First(q => q.Name == "Beneficiary").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[8].Id,
                RoleId = roles.First(q => q.Name == "Beneficiary").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[9].Id,
                RoleId = roles.First(q => q.Name == "Beneficiary").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[10].Id,
                RoleId = roles.First(q => q.Name == "Beneficiary").Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);












        }
    }
}

//    //builder.Entity<AccountManager>().HasData(new AccountManager { AccountManagerMUID= Gui, FirstName = "Marlandis", LastName = "Unwellz", Gender = "M", CreatedDate = DateTime.Today, Active=true });
