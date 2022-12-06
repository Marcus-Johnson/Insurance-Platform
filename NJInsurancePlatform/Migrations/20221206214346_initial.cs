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
                    CurrentZipcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
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
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    { "606d7c8d-b26b-4a70-848a-5086ffaabea9", "f558c3b0-040a-4fcd-91ba-637a261a3fd4", "Beneficiary", "BENEFICIARY" },
                    { "6084c02c-838a-4f85-9361-a8210fb9576c", "a4cf0200-9336-48c2-9c2e-0274ded92714", "Admin", "ADMIN" },
                    { "b979d44f-0a45-4134-8f72-dc82b084c86a", "7ec5664d-7cdf-45f8-9f30-e95abc4672a8", "Pending", "PENDING" },
                    { "fbb1e3e0-3c69-40af-8b75-f4274c77ab0a", "1455d94c-2b7d-4a57-8c01-1b86fb7361d5", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bf592ec-be76-44bb-b869-40875f0bdeeb", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "a63f78fb-61de-4319-91e2-5b48228dbbe0", new DateTime(2022, 12, 6, 16, 43, 45, 965, DateTimeKind.Local).AddTicks(3391), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEFc38kkZe9ZnU39sV0FsOLgNB9t2Bi3qGRSBLv1NjZDJvvLLZ3NolHrkEmYsTU26XQ==", "8790985467", false, null, "123456789", "7d345324-a676-4412-9b1d-168122c2c37d", false, "BritneyG@mymail.com" },
                    { "5bf179d3-90e9-4954-8777-8974702bb167", 0, true, null, "7514fa9d-04b4-4b26-b904-50ba3e810f91", new DateTime(2022, 12, 6, 16, 43, 45, 931, DateTimeKind.Local).AddTicks(1274), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAELcx6JbokXbQBL2N/p5csLFpUzbIPS/MGB6c6UNXvnHlwkV8wahnQlllJk43OXpscw==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "673d4959-e1ca-4c0b-a376-7d7a19b2aafd", false, "NikosiT@mymail.com" },
                    { "5e091029-20fd-4f9d-8b14-f18d23515e72", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "f7d15427-4208-40e3-bf29-cbe71bd7e17a", new DateTime(2022, 12, 6, 16, 43, 45, 956, DateTimeKind.Local).AddTicks(7402), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEJa3tSDvaQiiSsoJAwCUcYMSwDf7aj8kMQ+XMl/atkTaSlXTu2Mcchwr4nV8Di8Ryg==", "8790985467", false, null, "123456789", "cb251045-8156-46fe-982f-d9792a256354", false, "CynthiaS@mymail.com" },
                    { "5fa154f1-8d58-436a-bb59-98b309593101", 0, true, null, "7152e726-6b5f-4d05-8395-b22ad7b4c4d3", new DateTime(2022, 12, 6, 16, 43, 45, 939, DateTimeKind.Local).AddTicks(2698), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEGfI3QaPtMBD3ywe7szna+NBw8Fn9uJFhrsWyShC1CTgMOdWXskT4WkjQBXYm9esQw==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "fe9d5d6f-2225-4dba-be26-7659096aae24", false, "LeonaW@mymail.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "b7234c47-9c60-4ebf-a752-d01a91b88b74", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEPBQyGb17bnkeDOAPSCPT0INzQ0542qVK4MxWFZT7hTqActUOneC5HnOwioXnE3mDw==", null, false, null, null, "aa5403c9-f4ed-41fe-a3cf-1299371ef9c5", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "d194ee29-538f-4177-a1e5-2d0de6c0d9a3", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEN/VK4LxxHtUhTADnAghyUk2iLMshZ4SMUwPUS27MQnBpGtf8IHctxG/2i1xfmsLDA==", null, false, null, null, "5249a49a-d449-41cd-b9e8-5cba0f6e296d", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "1f8c626c-16fa-4801-8c56-1654286111ae", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEJq2rhOYjotbtiaFHbMDJwIO7vkoH9GKHxgQu8RolAxT1KLLa82XbKFcxwQTU9IRMA==", null, false, null, null, "706f534c-5364-425b-9f93-ca429be9fb91", false, "admin" },
                    { "957b7975-6831-4328-96d8-5100ad96e20e", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "fbfc234a-d6b5-4bff-8010-194f7b061fa1", new DateTime(2022, 12, 6, 16, 43, 45, 947, DateTimeKind.Local).AddTicks(4938), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEJfCeNIBwgxHcpyxTXiHE7jedJ1hXhUOZQ/hA2iN4pq3x8Xj1mZqiknGD5da6s7FyQ==", "8790985467", false, null, "123456789", "f404a439-4120-4896-bd80-4b0cff1a0ea1", false, "AndreaB@mymail.com" },
                    { "a767a499-9518-44ee-9310-b1074355f017", 0, true, null, "ac3a95cd-69ed-4ac5-a878-087eaae2b134", new DateTime(2022, 12, 6, 16, 43, 45, 922, DateTimeKind.Local).AddTicks(8996), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEKI61ESBrrf8hJq2iXr39TiU+NjUIbTr1gQS7vz1/yMKYBFSPYufB76QmfOj+crA/w==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "9ec554f6-1573-47ef-83c3-817b346d4f77", false, "EricD@mymail.com" },
                    { "ecc5c64b-4990-49ed-b4e3-7638cfc68ead", 0, true, null, "a09cd8e0-6085-42f2-b459-7bb1e007bba1", new DateTime(2022, 12, 6, 16, 43, 45, 914, DateTimeKind.Local).AddTicks(7369), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEEj5JD85v6qwsLKpy35WQEeHcjYzGx4Z2yjZKbYwBDxi9QCw5T8zR0oJcb7OJa6YcA==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "c66b29a3-c512-4da6-b65e-5f31f11c206f", false, "Pato" },
                    { "edc46952-542f-40a0-a6af-46b7d3685f5d", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "eb7376ee-1758-4d0d-a15e-7fa5692d12da", new DateTime(2022, 12, 6, 16, 43, 45, 973, DateTimeKind.Local).AddTicks(5607), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEOmigbTrS+QmT2ywcjRG8jnopN0Pw+Gc+VK6mu6RHB+CbaScthj/JN2O/sXz8vFAeA==", "8790985467", false, null, "123456789", "6bf65a65-19bb-4961-b1ce-95c197fc6f30", false, "JoanaM@mymail.com" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillMUID", "Balance", "CreatedDate", "MinimumPayment", "PolicyDueDate", "PolicyMUID", "Status" },
                values: new object[,]
                {
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2817), 283.99000000000001, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2815), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "Due" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2829), 449.08999999999997, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2827), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "Due" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2824), 129.09, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2822), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "Due" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2811), 123.98999999999999, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2807), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "Due" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqMUID", "Answer", "Question" },
                values: new object[,]
                {
                    { new Guid("3dea760e-d176-4093-b992-35eadf7d84ad"), "Your policy must first be approved by an Admin, please check your policy again in a little while.", "Why is my policy listed as pending?" },
                    { new Guid("9fb770f8-6899-4617-8550-5b9e599ba359"), "That is your initial role when you first register.  An Admin will approve your account and set you to your appropriate role.", "Why is my role listed as pending?" },
                    { new Guid("ac5cfe54-31a6-4cae-9d34-e923751f7551"), "Somerset, NJ", "Where Is our company based out of?" }
                });

            migrationBuilder.InsertData(
                table: "GroupRoomMessages",
                columns: new[] { "GroupRoomMessageMUID", "CreatedDate", "FirstName", "GroupRoomMUID", "LastName", "Message", "SenderMUID" },
                values: new object[,]
                {
                    { new Guid("4db427d8-8084-4987-9783-ef1154a0627b"), new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2985), "Leona", new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Wilson", "Sure, What would you like to know?", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce") },
                    { new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a"), new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2979), "Eric", new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "Daley", "Good Morning!", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1") },
                    { new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237"), new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2973), "Patrick", new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Leon", "Hello, How Are you?", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb") },
                    { new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d"), new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2982), "Nikosi", new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "Thom", "I have a question About My Policy", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176") }
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
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), "123", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2905), "123498732", "check Image", 9870, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2907), "credit", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2903), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), "123", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2888), "123498732", "check Image", 345, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2891), "credit", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2885), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), "123", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2897), "123498732", "check Image", 4532, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2900), "credit", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2894), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), "123", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2875), "123498732", "check Image", 123, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2879), "debit", new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2867), "Jillian", "Flowers", "visa", "2345432", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyMUID", "AnnualLimitOfCoverage", "CustomerMUID", "Deductible", "NameOfPolicy", "OutOfPocketLimit", "Pending", "PolicyEnd_Date", "PolicyOwner", "PolicyPaidOffAmount", "PolicyPaymentisDue", "PolicyStart_Date", "PolicyTotalAmount", "ProductMUID" },
                values: new object[,]
                {
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 500.98000000000002, "Employee Individual Health", 2099.9899999999998, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2735), "Leona wilson", 0.0, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2733), 150000.0, new Guid("7415ee9a-9536-4f92-bbf3-0391402be8c0") },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2730), "Nikosi Thom", 0.0, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2727), 35000.0, new Guid("ae0f77d0-3316-4bec-bdff-034514935c19") },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2714), "Patrick Leon", 0.0, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2679), 35000.0, new Guid("537014b1-9952-41cb-976f-993db1766c54") },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2723), "Eric Daley", 0.0, false, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2721), 35000.0, new Guid("334964e6-d880-439e-bbe8-7fb85fc94687") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductMUID", "AnnualLimitOfCoverage", "Deductible", "Description", "OutOfPocketLimit", "PolicyPaidOffAmount", "PolicyTotalAmount", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("334964e6-d880-439e-bbe8-7fb85fc94687"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 0.0, 150000.0, 3343.0, "Health Platinum" },
                    { new Guid("537014b1-9952-41cb-976f-993db1766c54"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 0.0, 10000.0, 2343.0, "DentalGold" },
                    { new Guid("7415ee9a-9536-4f92-bbf3-0391402be8c0"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 0.0, 100000.0, 1200.98, "Employee Individual Health" },
                    { new Guid("ae0f77d0-3316-4bec-bdff-034514935c19"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 0.0, 2000.0, 789.0, "Eye Emerald" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionMUID", "CustomerMUID", "PaymentAmount", "PaymentDate", "PolicyMUID", "isPaymentComplete" },
                values: new object[,]
                {
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2778), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2772), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2768), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 12, 6, 16, 43, 45, 890, DateTimeKind.Local).AddTicks(2775), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "606d7c8d-b26b-4a70-848a-5086ffaabea9", "1bf592ec-be76-44bb-b869-40875f0bdeeb" },
                    { "fbb1e3e0-3c69-40af-8b75-f4274c77ab0a", "5bf179d3-90e9-4954-8777-8974702bb167" },
                    { "606d7c8d-b26b-4a70-848a-5086ffaabea9", "5e091029-20fd-4f9d-8b14-f18d23515e72" },
                    { "fbb1e3e0-3c69-40af-8b75-f4274c77ab0a", "5fa154f1-8d58-436a-bb59-98b309593101" },
                    { "fbb1e3e0-3c69-40af-8b75-f4274c77ab0a", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "606d7c8d-b26b-4a70-848a-5086ffaabea9", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "6084c02c-838a-4f85-9361-a8210fb9576c", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "606d7c8d-b26b-4a70-848a-5086ffaabea9", "957b7975-6831-4328-96d8-5100ad96e20e" },
                    { "fbb1e3e0-3c69-40af-8b75-f4274c77ab0a", "a767a499-9518-44ee-9310-b1074355f017" },
                    { "fbb1e3e0-3c69-40af-8b75-f4274c77ab0a", "ecc5c64b-4990-49ed-b4e3-7638cfc68ead" },
                    { "606d7c8d-b26b-4a70-848a-5086ffaabea9", "edc46952-542f-40a0-a6af-46b7d3685f5d" }
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
