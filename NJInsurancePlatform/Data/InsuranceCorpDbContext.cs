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

        public DbSet<Policy> Policies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<AccountManager> AccountManagers { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;  // For the purpos of Migration


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=GFTHF-PF12QJ7D;Initial Catalog=InsuranceCorp;MultipleActiveResultSets=True;User Id=sa;Password=Galaxy@123");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Add User Roles On Migration;
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Guest",
                NormalizedName = "GUEST"
            });
        }
    }
}
