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
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;  // For the purpos of Migration
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=GFTHF-PF12QJ7D;Initial Catalog=InsuranceCorp;MultipleActiveResultSets=True;User Id=sa;Password=Galaxy@123");
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    var Gui2 = new Guid();
        //    var AdminId = new Guid();
        //    // Add User Roles And Admin upon Migration
        //    builder.Entity<IdentityRole>().HasData(new IdentityRole
        //    {
        //        Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
        //        Name = "Admin",
        //        NormalizedName = "ADMIN"
        //    });
        //    builder.Entity<IdentityRole>().HasData(new IdentityRole
        //    {
        //        Name = "Customer",
        //        NormalizedName = "CUSTOMER"
        //    });
        //    builder.Entity<IdentityRole>().HasData(new IdentityRole
        //    {
        //        Name = "Beneficiary",
        //        NormalizedName = "BENEFICIARY"
        //    });
        //    //var gui = Gui;
        //    //builder.Entity<AccountManager>().HasData(new AccountManager { AccountManagerMUID= Gui, FirstName = "Marlandis", LastName = "Unwellz", Gender = "M", CreatedDate = DateTime.Today, Active=true });
        //    //builder.Entity<IdentityUserRole<string>>().HasData(
        //    //    new IdentityUserRole<string>
        //    //    {
        //    //        RoleId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
        //    //        UserId = Gui.ToString()
        //    //    }
        //    //);
        //    var hasher=PasswordHasher
        //    builder.Entity<ApplicationUser>().HasData(
        //       new ApplicationUser
        //       {
        //           Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
        //           UserName = "admin",
        //           NormalizedUserName = "ADMIN",
        //           PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
        //       }
        //   );

        //    //Seeding the relation between our user and role to AspNetUserRoles table
        //    builder.Entity<IdentityUserRole<string>>().HasData(
        //        new IdentityUserRole<string>
        //        {
        //            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
        //            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
        //        }
        //    );

        //    //builder.Entity<Customer>().HasData(new Customer { CustomerMUID= Gui, FirstName = "Demi", LastName = "Gnon", EmailAddress = "DemiG@gmail.com", PhoneNumber = "1234567898", CurrentAddress = "123 Senjin Way", CurrentCity = "Denver", CurrentZipcode = "78675", CurrentState = "Colorado", CurrentEmployer = "Broncos", SSN = "123-456-7878", LicenseNumber = "378", IsPrimaryPolicyHolder = true, Gender = true, CreatedDate = DateTime.Now.ToString(), Active = true });
        //    //builder.Entity<Customer>().HasData(new Customer { CustomerMUID = new Guid(), FirstName = "Kira", LastName = "Yamamoto", EmailAddress = "KYamaG@gmail.com", PhoneNumber = "1234567891", CurrentAddress = "126 Guardian Blvd", CurrentCity = "Chicago", CurrentZipcode = "38615", CurrentState = "Illinois", CurrentEmployer = "Bears", SSN = "123-456-7871", LicenseNumber = "478", IsPrimaryPolicyHolder = true, Gender = false, CreatedDate = DateTime.Now.ToString(), Active = true });

        //    //builder.Entity<Beneficiary>().HasData(new Beneficiary { BeneficiaryMUID=Gui2, FirstName = "Tamashi", LastName = "Leasor", EmailAddress = "TLeasor@gmail.com", PhoneNumber = "1234567890", SSN = "123-456-7890", LicenseNumber = "345", Gender = "F", CreatedDate = DateTime.Now, Active = true });
        //    //builder.Entity<Beneficiary>().HasData(new Beneficiary { BeneficiaryMUID = new Guid(), FirstName = "Martin", LastName = "Fernandez", EmailAddress = "MFern@gmail.com", PhoneNumber = "1234567899", SSN = "123-456-7899", LicenseNumber = "346", Gender = "M", CreatedDate = DateTime.Now, Active = true });

        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // "PasswordHasher" to has "admin" user password before seeding
            var hasher = new PasswordHasher<ApplicationUser>();
            base.OnModelCreating(builder);

            //Seed "Admin" Role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            //Seed "Customer" Role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            });

            //Seed "Beneficiary" Role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", // primary key
                Name = "Beneficiary",
                NormalizedName = "BENEFICIARY",
            });




            //Seed the "admin" User to AspNetUsers table
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
                }
            );

            //Beneficiary
            builder.Entity<ApplicationUser>().HasData(
               new ApplicationUser
               {
                   Id = "8e445865-a24d-4543-a6c6-9443d048cdb8", // primary key
                   UserName = "beneficiary",
                   NormalizedUserName = "BENEFICIARY",
                   PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
               }
            );

            //Customer
            builder.Entity<ApplicationUser>().HasData(
               new ApplicationUser
               {
                   Id = "8e445865-a24d-4543-a6c6-9443d048cdb7", // primary key
                   UserName = "customer",
                   NormalizedUserName = "CUSTOMER",
                   PasswordHash = hasher.HashPassword(null, "Password123@")  // Initial admin password
               }
            );



            //Seeding the relation between our user and role to AspNetUserRoles table
            //Admin
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );

            //Beneficiary
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"
                }
            );

            //Customer
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb7"
                }
            );

            var Gui = new Guid();
            builder.Entity<Policy>().HasData(
                new Policy
                {
                    PolicyMUID = Guid.NewGuid(),
                    PolicyNumber = 10101,
                    NameOfPolicy = "Dental Gold",
                    PolicyOwner = "Customer",
                    Deductible = 100.25,
                    OutOfPocketLimit = 999.99,
                    AnnualLimitOfCoverage = 14999.99,
                    PolicyPaymentisDue = false,
                    PolicyTotalAmount=35000,
                    PolicyPaidOffAmount=0,
                    PolicyStart_Date=DateTime.Now,
                    PolicyEnd_Date=DateTime.Now,
                }

            ) ;
        }
    }
}

//    //builder.Entity<AccountManager>().HasData(new AccountManager { AccountManagerMUID= Gui, FirstName = "Marlandis", LastName = "Unwellz", Gender = "M", CreatedDate = DateTime.Today, Active=true });
