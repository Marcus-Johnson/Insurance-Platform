using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NJInsurancePlatform.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BeneficiaryMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CurrentAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentZipcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CurrentState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CurrentEmployer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IsPrimaryPolicyHolder = table.Column<bool>(type: "bit", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MinimumPayment = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillMUID);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    ClaimMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyMUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimUserDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DateOfClaim = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.ClaimMUID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrentAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrentCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrentZipcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CurrentState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrentEmployer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsPrimaryPolicyHolder = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerMUID);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    FaqMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.FaqMUID);
                });

            migrationBuilder.CreateTable(
                name: "GroupRoomMessages",
                columns: table => new
                {
                    GroupRoomMessageMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupRoomMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRoomMessages", x => x.GroupRoomMessageMUID);
                });

            migrationBuilder.CreateTable(
                name: "GroupRooms",
                columns: table => new
                {
                    GroupMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRooms", x => x.GroupMUID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CardExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DebitOrCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoutingNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    CheckNumber = table.Column<int>(type: "int", nullable: false),
                    CheckImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentMUID);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameOfPolicy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PolicyOwner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deductible = table.Column<double>(type: "float", nullable: false),
                    OutOfPocketLimit = table.Column<double>(type: "float", nullable: false),
                    AnnualLimitOfCoverage = table.Column<double>(type: "float", nullable: false),
                    PolicyPaymentisDue = table.Column<bool>(type: "bit", nullable: false),
                    PolicyTotalAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyPaidOffAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyStart_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyEnd_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pending = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyMUID);
                });

            migrationBuilder.CreateTable(
                name: "PolicyRequests",
                columns: table => new
                {
                    RequestMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyRequests", x => x.RequestMUID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Deductible = table.Column<double>(type: "float", nullable: false),
                    AnnualLimitOfCoverage = table.Column<double>(type: "float", nullable: false),
                    OutOfPocketLimit = table.Column<double>(type: "float", nullable: false),
                    PolicyPaidOffAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyTotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductMUID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    isPaymentComplete = table.Column<bool>(type: "bit", nullable: false),
                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionMUID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    BeneficiaryMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    TransactionMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.BeneficiaryMUID);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Transactions_TransactionMUID",
                        column: x => x.TransactionMUID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionMUID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04633fd6-73ea-434a-8731-1f3b31b48469", "9005cc94-260d-4b66-a4b2-1aab1ff999aa", "Admin", "ADMIN" },
                    { "5eb974ad-4798-4aae-b52e-330233c685d9", "abf72631-bf35-4b28-b54e-c2433f59ec04", "Customer", "CUSTOMER" },
                    { "8ee7da31-a55b-43f2-9aef-25815081b946", "e26744f0-4979-474b-b0aa-1c8880c5c75d", "Beneficiary", "BENEFICIARY" },
                    { "9d8de9b7-d4d7-424d-8431-e74dc3111ebb", "6faeed85-a256-43e0-b6fc-c2d7b852e567", "Pending", "PENDING" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ff43d4f-59ea-4e60-be9b-a5f3731ffed2", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "ef19ca3e-38fd-41a8-8a26-83ecdfda09c0", new DateTime(2022, 12, 5, 13, 37, 25, 931, DateTimeKind.Local).AddTicks(4369), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEC0zsW0EOcKbPVgz9I3Htzcqo7KEMUYdChW5E7yc4PlCv+XXoFl8DM/L6q5As0l9PA==", "8790985467", false, null, "123456789", "f75d7369-330c-418a-a30e-1fb638c86a89", false, "JoanaM@mymail.com" },
                    { "18533899-13f4-420d-94f5-070f1f9a04d7", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "8f934b27-5c48-42b3-b399-cd5eeded05ce", new DateTime(2022, 12, 5, 13, 37, 25, 923, DateTimeKind.Local).AddTicks(1263), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEN3j1nWya6ZP9ihrs7TnDMJQp+vognOor9JB3nRm3PA51CD/2DvSh8mj4d8m7+Mkpw==", "8790985467", false, null, "123456789", "f8f00760-6b40-491e-8d4d-2ffaa920259d", false, "BritneyG@mymail.com" },
                    { "2551d5f3-691b-441d-b534-a71f5defc898", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "24698df2-051c-4dc2-8fa0-f4078d49b537", new DateTime(2022, 12, 5, 13, 37, 25, 914, DateTimeKind.Local).AddTicks(8833), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAENC21JOH7DDoEBjDIr3DM5qj3rm3P68IbUhn9R/OH9a74mxeKLXpkgmJT7F0L5iKzg==", "8790985467", false, null, "123456789", "a2538039-44e5-491a-85d8-bd0c7e150ae9", false, "CynthiaS@mymail.com" },
                    { "2f652a4b-b1d0-4d1a-883d-9952cea775be", 0, true, null, "c6f8757d-9917-4f90-8b41-73935dd9a98c", new DateTime(2022, 12, 5, 13, 37, 25, 889, DateTimeKind.Local).AddTicks(4093), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEKW9yOay+keExau99mx8xcFs/jq4R2naTM69+SANJn2xZ5K/sSbBU9v08Bk4HsJHvw==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "1a89ca8f-81ef-4c3c-aa9a-343b1e4feb61", false, "NikosiT@mymail.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "244d881d-92b7-43e0-b4e2-b37f2e0d3f11", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEDUo8HlYmSzLnBkQLnpb0GOXqJ+2IKvaX104KWoYLC+00TmL13p/uDS5CdDId8LHMg==", null, false, null, null, "ae3eff63-a626-4f56-9df2-a72b2f01c1d6", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "07afe3de-8010-4cbe-be4a-cfcf3c4fcdd2", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEMGMID02E9qkwS5iIRCIeGv1iP0CbOSyMV7eSAT3gW63AnIhyiAU+m9yiSY/GBg+wQ==", null, false, null, null, "eb411223-47fd-43d7-9ba1-acf6fcae40a4", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "dbe74cf4-d643-4729-a28e-3756c28e9fe6", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAELfes2aiUbVIpLN7BYjzRJTX036JaGXPXdgTSsCpwSJSK/Nm2bYCC02zcYYor6lOlg==", null, false, null, null, "2f5452f7-2baf-414f-9b4b-dc1f5f24e754", false, "admin" },
                    { "a467c8d1-3410-4206-824a-6aeffd0621e5", 0, true, null, "3f80755b-c688-403b-a27f-0bb304edb46a", new DateTime(2022, 12, 5, 13, 37, 25, 897, DateTimeKind.Local).AddTicks(4607), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAECHHap1vIVk+mJ48HHwWb47c/y5bpKTYxhg7HU70fBN4CMR3edrnrTP0ie3pnxFS+g==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "5cf5269f-3e1d-438b-8632-0f2b0177d6ef", false, "LeonaW@mymail.com" },
                    { "a94ee855-e2c8-477c-a862-e1c5a8db956b", 0, true, null, "74b55931-96a1-4edf-a4dc-f9e188dd266d", new DateTime(2022, 12, 5, 13, 37, 25, 881, DateTimeKind.Local).AddTicks(6664), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEPlTlL8OnM0zpjtNKnXxPnYFi4Ny7Vu3JFFXkOzdXoXfZNzW2360adogfbCNcVAe0g==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "4d30a28e-1508-442a-a1b5-320c3167535c", false, "EricD@mymail.com" },
                    { "bcda62ba-b5dc-4e53-8996-eafe2af499af", 0, true, null, "0c3955ef-3a5f-4dbc-ac3a-057d0fabac3a", new DateTime(2022, 12, 5, 13, 37, 25, 872, DateTimeKind.Local).AddTicks(3178), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEOoB4g3qk64asgWWo+C2bT4689DeikaExPybw2mjK1HSRzM+pm4NLFgoiOq37TEB6g==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "abe6f7f0-7a1f-4b1f-9485-bcaf02b70c68", false, "Pato" },
                    { "c4d3612e-ad61-420a-b7ca-b922b69ea30e", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "64b646e0-0d90-4a55-a239-7968f45d810d", new DateTime(2022, 12, 5, 13, 37, 25, 906, DateTimeKind.Local).AddTicks(1323), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEFCz9CGmdnaIAzSyLwCjL/OCs8yKMxDdtVj2194eexrxcU2Z1O8LP+HUAIpIgGlN5g==", "8790985467", false, null, "123456789", "262e58ba-8789-4712-b13a-4431c6e2e614", false, "AndreaB@mymail.com" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillMUID", "Balance", "CreatedDate", "MinimumPayment", "PolicyDueDate", "PolicyMUID", "Status" },
                values: new object[,]
                {
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6306), 283.99000000000001, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6304), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "status" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6315), 449.08999999999997, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6312), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "status" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6310), 129.09, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6309), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "status" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6302), 123.98999999999999, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6300), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "status" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqMUID", "Answer", "Question" },
                values: new object[,]
                {
                    { new Guid("1746f919-4ce7-437b-b75b-1cd25a109abc"), "Your policy must first be approved by an Admin, please check your policy again in a little while.", "Why is my policy listed as pending?" },
                    { new Guid("313116f0-0056-492b-8fc3-b9a5bbc79e49"), "Somerset, NJ", "Where Is our company based out of?" },
                    { new Guid("99c8a414-299a-40d0-a152-f558a7ff1954"), "That is your initial role when you first register.  An Admin will approve your account and set you to your appropriate role.", "Why is my role listed as pending?" }
                });

            migrationBuilder.InsertData(
                table: "GroupRoomMessages",
                columns: new[] { "GroupRoomMessageMUID", "CreatedDate", "FirstName", "GroupRoomMUID", "LastName", "Message", "SenderMUID" },
                values: new object[,]
                {
                    { new Guid("4db427d8-8084-4987-9783-ef1154a0627b"), new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6400), "Leona", new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Wilson", "Sure, What would you like to know?", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce") },
                    { new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a"), new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6396), "Eric", new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "Daley", "Good Morning!", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1") },
                    { new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237"), new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6392), "Patrick", new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Leon", "Hello, How Are you?", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb") },
                    { new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d"), new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6398), "Nikosi", new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "Thom", "I have a question About My Policy", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176") }
                });

            migrationBuilder.InsertData(
                table: "GroupRooms",
                columns: new[] { "GroupMUID", "Name" },
                values: new object[,]
                {
                    { new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "Leona's Group" },
                    { new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "Eric's Group" },
                    { new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Patrick's Group" },
                    { new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Nikosi's Group" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentMUID", "AccountNumber", "AdditionalInfo", "Amount", "BankName", "BillMUID", "CVV", "CardExpireDate", "CardNumber", "CheckImage", "CheckNumber", "CreatedDate", "DebitOrCredit", "PaidDate", "PayerFirstName", "PayerLastName", "PaymentMethod", "RoutingNumber", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), "123", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6358), "123498732", "check Image", 9870, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6360), "credit", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6356), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), "123", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6346), "123498732", "check Image", 345, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6348), "credit", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6343), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), "123", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6352), "123498732", "check Image", 4532, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6354), "credit", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6350), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), "123", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6337), "123498732", "check Image", 123, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6341), "debit", new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6332), "Jillian", "Flowers", "visa", "2345432", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyMUID", "AnnualLimitOfCoverage", "CustomerMUID", "Deductible", "NameOfPolicy", "OutOfPocketLimit", "Pending", "PolicyEnd_Date", "PolicyOwner", "PolicyPaidOffAmount", "PolicyPaymentisDue", "PolicyStart_Date", "PolicyTotalAmount", "ProductMUID" },
                values: new object[,]
                {
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 500.98000000000002, "Employee Individual Health", 2099.9899999999998, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6207), "Leona wilson", 0.0, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6205), 150000.0, new Guid("e50400a7-a673-4ff2-88f3-38965cb60f3f") },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6203), "Nikosi Thom", 0.0, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6201), 35000.0, new Guid("66e4553d-0c03-47ef-ae5e-ced4aad40b09") },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6192), "Patrick Leon", 0.0, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6164), 35000.0, new Guid("d27444c3-aeef-4c57-8e19-2aaa06d38818") },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6198), "Eric Daley", 0.0, false, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6196), 35000.0, new Guid("739dbe54-ee82-4d43-9c9a-aa7fcae4e5e4") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductMUID", "AnnualLimitOfCoverage", "Deductible", "Description", "OutOfPocketLimit", "PolicyPaidOffAmount", "PolicyTotalAmount", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("66e4553d-0c03-47ef-ae5e-ced4aad40b09"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 0.0, 2000.0, 789.0, "Eye Emerald" },
                    { new Guid("739dbe54-ee82-4d43-9c9a-aa7fcae4e5e4"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 0.0, 150000.0, 3343.0, "Health Platinum" },
                    { new Guid("d27444c3-aeef-4c57-8e19-2aaa06d38818"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 0.0, 10000.0, 2343.0, "DentalGold" },
                    { new Guid("e50400a7-a673-4ff2-88f3-38965cb60f3f"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 0.0, 100000.0, 1200.98, "Employee Individual Health" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionMUID", "CustomerMUID", "PaymentAmount", "PaymentDate", "PolicyMUID", "isPaymentComplete" },
                values: new object[,]
                {
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6274), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6270), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6267), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 12, 5, 13, 37, 25, 848, DateTimeKind.Local).AddTicks(6272), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8ee7da31-a55b-43f2-9aef-25815081b946", "0ff43d4f-59ea-4e60-be9b-a5f3731ffed2" },
                    { "8ee7da31-a55b-43f2-9aef-25815081b946", "18533899-13f4-420d-94f5-070f1f9a04d7" },
                    { "8ee7da31-a55b-43f2-9aef-25815081b946", "2551d5f3-691b-441d-b534-a71f5defc898" },
                    { "5eb974ad-4798-4aae-b52e-330233c685d9", "2f652a4b-b1d0-4d1a-883d-9952cea775be" },
                    { "5eb974ad-4798-4aae-b52e-330233c685d9", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "8ee7da31-a55b-43f2-9aef-25815081b946", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "04633fd6-73ea-434a-8731-1f3b31b48469", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "5eb974ad-4798-4aae-b52e-330233c685d9", "a467c8d1-3410-4206-824a-6aeffd0621e5" },
                    { "5eb974ad-4798-4aae-b52e-330233c685d9", "a94ee855-e2c8-477c-a862-e1c5a8db956b" },
                    { "5eb974ad-4798-4aae-b52e-330233c685d9", "bcda62ba-b5dc-4e53-8996-eafe2af499af" },
                    { "8ee7da31-a55b-43f2-9aef-25815081b946", "c4d3612e-ad61-420a-b7ca-b922b69ea30e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_TransactionMUID",
                table: "Beneficiaries",
                column: "TransactionMUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "GroupRoomMessages");

            migrationBuilder.DropTable(
                name: "GroupRooms");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "PolicyRequests");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
