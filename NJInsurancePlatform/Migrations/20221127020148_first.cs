using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NJInsurancePlatform.Migrations
{
    public partial class first : Migration
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
                    Gender = table.Column<bool>(type: "bit", nullable: false),
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
                    Message = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false)
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
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyNumber = table.Column<int>(type: "int", nullable: false),
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
                    OutOfPocketLimit = table.Column<double>(type: "float", nullable: false)
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
                    { "338886c9-78c4-46a5-b23a-79dbc63b195d", "f3c1359d-3911-4bf6-9781-01de98c6dd14", "Admin", "ADMIN" },
                    { "57c4b81b-59a9-4be3-a2be-6fb358c4b34d", "165085e5-b4ce-4b54-8f85-fa0928e7ee94", "Customer", "CUSTOMER" },
                    { "6352c078-9468-4532-a432-b134c8711b85", "3a4c1bbe-7431-4f3b-96e6-5cab8eeac9ac", "Pending", "PENDING" },
                    { "fe2f1c88-8744-4639-9ee6-685b507eb74a", "281f2ca3-6849-45e5-9632-f33aeef66935", "Beneficiary", "BENEFICIARY" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "029c4321-986b-4209-aa90-13e634f69302", 0, true, null, "436c844e-7b6d-4acb-9701-002ffdc24c53", new DateTime(2022, 11, 26, 21, 1, 48, 145, DateTimeKind.Local).AddTicks(25), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEKca5AvthbLJy48yROU/g0emyHJM+/XW5+FwRHsgSqv8n0c8/7a3cXMZn6+t+g8vUg==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "f3fa2e7c-7495-48cc-b95c-6568bec31fe9", false, "Pato" },
                    { "19c93a7c-1bbb-4162-9e7a-14e7aedf1e12", 0, true, null, "786204f6-d5fa-4ae9-bd38-b0736cb9b517", new DateTime(2022, 11, 26, 21, 1, 48, 169, DateTimeKind.Local).AddTicks(4315), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEDgL/LObOldCfFvrvpCzGtfjGycu6RGCCEwjW/C/7PaHo+JRB3lYpTpuowi71bt1cg==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "ad0cd7e7-6b65-48fa-9985-262228a4a6d2", false, "NikosiT@mymail.com" },
                    { "203070af-213e-4d95-abe0-c598f39c1661", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "acd0bc2c-b66b-484f-bae4-0b67ce26accc", new DateTime(2022, 11, 26, 21, 1, 48, 200, DateTimeKind.Local).AddTicks(9429), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEFoSYSayBEb5kMN92Mjd9AWt+z/bO88J6Kk8MCtww5AMjnMsHGKYOJgUDJM9YbL1uw==", "8790985467", false, null, "123456789", "8e6104b2-dc98-41dd-b398-5c57ed1b89ef", false, "BritneyG@mymail.com" },
                    { "2bea8f0f-b141-420d-975e-202597deba0c", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "888e9e2a-d7d4-4a8c-b84b-0421f345345c", new DateTime(2022, 11, 26, 21, 1, 48, 193, DateTimeKind.Local).AddTicks(3312), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEPzHDg5d2w+3cgMCrmCSLbOedprseQsGsT92lAbx/3I1qvTmaqoBykTqdyn3qkRr+Q==", "8790985467", false, null, "123456789", "bf343d99-548c-45b1-93cd-8fbfb505c88b", false, "CynthiaS@mymail.com" },
                    { "4cff82da-be8f-4749-af3a-576ed317ae5a", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "b41b01b4-a106-4676-a7bc-fed5dce00d52", new DateTime(2022, 11, 26, 21, 1, 48, 186, DateTimeKind.Local).AddTicks(4029), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEFrNuiA501X4Cna3rCqKnzmKB0sjT3H2fGBE6jPimX0/+kyJdm7w0XuUQVvyXwLIWw==", "8790985467", false, null, "123456789", "cadc505a-f7ea-4ef2-b5e6-cff20be9276b", false, "AndreaB@mymail.com" },
                    { "88a54bdf-d311-40c3-8db1-f432fb7d8a61", 0, true, null, "8a002810-f15b-4fd1-9549-50857421a713", new DateTime(2022, 11, 26, 21, 1, 48, 158, DateTimeKind.Local).AddTicks(7330), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEJoj+0pt5feweIuM/X/H1QVXgbo4Qae2fpI7uEfA5RLHfmIz1UM21s+BgQ+MgxQUxw==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "5cc6c0ea-8065-4d9b-bcb5-e750e19e875b", false, "EricD@mymail.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "67a2d94b-cb08-48ae-abe4-e11fcf6862e5", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEGGpuuatBblwauX9i20AQVVZ3soN022AnwavxBEABwTLL9eV+HxyX4u0TWf0If7bXA==", null, false, null, null, "584aabc9-a784-46f1-a6e1-d41da957d6b3", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "a93e27fc-ee7c-4f9c-a0c2-fbef9d69f31d", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEJ2WP7QddHq8mey4Pp9TjW/eyXxe9FVRqA1kZfXy4M1/OaTsjZvokkKGTKz+66Xaew==", null, false, null, null, "7fb3305c-75bf-47d6-828c-c424b4672b30", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "b30288e2-4344-4d9b-ae10-ad32ae41a2c9", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAENB1FURlhrfKO8Id2mmUQyyvHC3UiE6ki5wCGjJt5f5D368BS3FGAsk20VRgyBHbUw==", null, false, null, null, "73ae88de-a314-41af-8a59-6d2f4bb9501c", false, "admin" },
                    { "94523f26-4d84-4498-a60c-ac20ba09cef1", 0, true, null, "25d45f20-79c5-477e-816a-f0c4356f12cc", new DateTime(2022, 11, 26, 21, 1, 48, 178, DateTimeKind.Local).AddTicks(2579), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEBQC98fr3ctkplYRR8jS0Rl4zUEADeIgm0/IlzOJdfVmknnqKqAtgsI9EIEsrB7W1g==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "efc5dd3d-1902-4c00-b1f4-f5d24cadcbad", false, "LeonaW@mymail.com" },
                    { "cb17811f-48ea-4df9-a7d1-16787b21ee5a", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "db6729f9-ef78-45ef-b3a8-cad86075fee6", new DateTime(2022, 11, 26, 21, 1, 48, 209, DateTimeKind.Local).AddTicks(3921), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEMQqz4shkddzAV9kJ/c3CsGg+ZuASlUCx1UkkBc+WNj8f6m6tgUfFX/nYo0OJHAOuw==", "8790985467", false, null, "123456789", "b455fdc0-5387-400d-be5f-c1c209b3b257", false, "JoanaM@mymail.com" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillMUID", "Balance", "CreatedDate", "MinimumPayment", "PolicyDueDate", "PolicyMUID", "Status" },
                values: new object[,]
                {
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8698), 283.99000000000001, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8693), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "status" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8716), 449.08999999999997, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8712), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "status" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8707), 129.09, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8703), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "status" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8686), 123.98999999999999, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8681), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "status" }
                });

            migrationBuilder.InsertData(
                table: "GroupRoomMessages",
                columns: new[] { "GroupRoomMessageMUID", "GroupRoomMUID", "Message", "SenderMUID" },
                values: new object[,]
                {
                    { new Guid("4db427d8-8084-4987-9783-ef1154a0627b"), new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Sure, What would you like to know?", new Guid("93fa9038-9c45-42cf-993b-fc3d15764f18") },
                    { new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a"), new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "yes, How Can I Help you?", new Guid("a7071f27-db08-47fb-a05a-0a7da44b44c4") },
                    { new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237"), new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Hello, Can you please Help Me?", new Guid("d9ef788c-a3f8-48b3-92ce-804170aba836") },
                    { new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d"), new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "I have a question About My Policy", new Guid("a7071f27-db08-47fb-a05a-0a7da44b44c4") }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentMUID", "AccountNumber", "AdditionalInfo", "Amount", "BankName", "BillMUID", "CardExpireDate", "CardNumber", "CheckImage", "CheckNumber", "CreatedDate", "DebitOrCredit", "PaidDate", "PayerFirstName", "PayerLastName", "PaymentMethod", "RoutingNumber", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8819), "123498732", "check Image", 9870, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8825), "credit", new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8814), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8788), "123498732", "check Image", 345, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8794), "credit", new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8783), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8804), "123498732", "check Image", 4532, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8808), "credit", new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8799), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8770), "123498732", "check Image", 123, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8778), "debit", new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8763), "Jillian", "Flowers", "visa", "2345432", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyMUID", "AnnualLimitOfCoverage", "CustomerMUID", "Deductible", "NameOfPolicy", "OutOfPocketLimit", "Pending", "PolicyEnd_Date", "PolicyNumber", "PolicyOwner", "PolicyPaidOffAmount", "PolicyPaymentisDue", "PolicyStart_Date", "PolicyTotalAmount" },
                values: new object[,]
                {
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8573), 769564, "Leona wilson", 0.0, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8569), 35000.0 },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8563), 78910, "Nikosi Thom", 0.0, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8559), 35000.0 },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8538), 1234, "Patrick Leon", 0.0, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8486), 35000.0 },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8553), 4567, "Eric Daley", 0.0, false, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8549), 35000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductMUID", "AnnualLimitOfCoverage", "Deductible", "Description", "OutOfPocketLimit", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("906937c1-d68e-4941-a0ee-04f5fa9cf9d6"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 3343.0, "Health Platinum" },
                    { new Guid("909b2977-c5f0-4b7c-9702-55751bfe9bb6"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 2343.0, "DentalGold" },
                    { new Guid("97585f1f-19f1-495e-b7f2-6f316a9c163c"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 1200.98, "Empoyee Individual" },
                    { new Guid("e124d9e9-30ed-40ce-a6fd-5f90338b27a4"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 789.0, "Eye Emerald" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionMUID", "CustomerMUID", "PaymentAmount", "PaymentDate", "PolicyMUID", "isPaymentComplete" },
                values: new object[,]
                {
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8635), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8624), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8618), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 11, 26, 21, 1, 48, 97, DateTimeKind.Local).AddTicks(8630), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "57c4b81b-59a9-4be3-a2be-6fb358c4b34d", "029c4321-986b-4209-aa90-13e634f69302" },
                    { "57c4b81b-59a9-4be3-a2be-6fb358c4b34d", "19c93a7c-1bbb-4162-9e7a-14e7aedf1e12" },
                    { "fe2f1c88-8744-4639-9ee6-685b507eb74a", "203070af-213e-4d95-abe0-c598f39c1661" },
                    { "fe2f1c88-8744-4639-9ee6-685b507eb74a", "2bea8f0f-b141-420d-975e-202597deba0c" },
                    { "fe2f1c88-8744-4639-9ee6-685b507eb74a", "4cff82da-be8f-4749-af3a-576ed317ae5a" },
                    { "57c4b81b-59a9-4be3-a2be-6fb358c4b34d", "88a54bdf-d311-40c3-8db1-f432fb7d8a61" },
                    { "57c4b81b-59a9-4be3-a2be-6fb358c4b34d", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "fe2f1c88-8744-4639-9ee6-685b507eb74a", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "338886c9-78c4-46a5-b23a-79dbc63b195d", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "57c4b81b-59a9-4be3-a2be-6fb358c4b34d", "94523f26-4d84-4498-a60c-ac20ba09cef1" },
                    { "fe2f1c88-8744-4639-9ee6-685b507eb74a", "cb17811f-48ea-4df9-a7d1-16787b21ee5a" }
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
