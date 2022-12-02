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
                    { "422d4e7c-5e6b-4e87-98b6-63f8111381e9", "511e9ea3-60c8-4241-aec7-c7de96ec7db7", "Beneficiary", "BENEFICIARY" },
                    { "de8f69bf-23e2-4cd8-ab79-5248c31e4eae", "925a7736-9bbf-469d-9488-0281a15d88c4", "Admin", "ADMIN" },
                    { "def4bb68-5cb2-4f44-9b09-28e85b0473f0", "d8498e48-c91e-46ae-97b8-d790a06c706b", "Pending", "PENDING" },
                    { "e7d78896-ddb6-46af-a773-0213a09ef40c", "f1bd2c99-aa95-4291-bc7d-36fc3a1da226", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "161f8c40-6362-4725-b74d-21c627686d91", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "c6cee1bf-c135-44d6-9351-3f5445b68cc7", new DateTime(2022, 12, 2, 9, 57, 48, 536, DateTimeKind.Local).AddTicks(9524), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEDFKBqUAn1oixJIKY7i4Nk1mgVx0mu8nAEDEcHSct91sgyPyQWC/zpZCoy6zlCPBOg==", "8790985467", false, null, "123456789", "eaab486f-724d-46c9-98c9-f252933cf762", false, "CynthiaS@mymail.com" },
                    { "2db7ddd2-579e-4975-870b-b111412db610", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "96ecfaf9-3397-4bdc-bdd2-046a988e909b", new DateTime(2022, 12, 2, 9, 57, 48, 546, DateTimeKind.Local).AddTicks(3348), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAECjD55kemhrtTX+khfDLd/K5N+rIcCDyKZdY6/oq6OTqTvb65XP+gNCUw/6rZer3FA==", "8790985467", false, null, "123456789", "c12c77e4-da48-4f34-b3e9-0118e3be4058", false, "BritneyG@mymail.com" },
                    { "477bef17-5d7a-4a10-b59f-b6b6ff801264", 0, true, null, "1cb937cb-e5d6-4981-b89c-2bcee6d25771", new DateTime(2022, 12, 2, 9, 57, 48, 487, DateTimeKind.Local).AddTicks(3855), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEKbwJwfdCiAYCMbEB+9TGRrQelvj3no+ppQ0687KBaKimXeaB5xMewa1+LB2X/rUxg==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "eadb1191-1704-4b42-b73a-9c1cc917a097", false, "EricD@mymail.com" },
                    { "4c26a4cf-1364-4ed6-b8e6-8e1e23c1794e", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "64dbd106-ca16-447e-b0c6-c552972bf9cf", new DateTime(2022, 12, 2, 9, 57, 48, 528, DateTimeKind.Local).AddTicks(1574), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEPsZnfrayhkW3PvML9DKhXKAx/Nwva8JZh5ewApUxCjFdJWLWTF43c9cZAmrKF5Flw==", "8790985467", false, null, "123456789", "d5a56014-3357-441f-b8af-3141bd9a49dc", false, "AndreaB@mymail.com" },
                    { "5e7d78de-76fb-479e-a2e1-d8886e46b311", 0, true, null, "4eef866c-6b68-466a-a397-ec8a3340b350", new DateTime(2022, 12, 2, 9, 57, 48, 516, DateTimeKind.Local).AddTicks(1203), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEB8gCAgA8218GRvNnIvyBQFQlSharA7Eb4ykq3b8XhpQNvb7NvSI0i1tg0BSvxyHmw==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "4a45ccfa-46be-42dd-acc7-84aed4de567e", false, "LeonaW@mymail.com" },
                    { "8769b938-a65f-4141-9e40-70beca51e382", 0, true, null, "0a424736-2d1c-4af7-9294-7e372b110f6b", new DateTime(2022, 12, 2, 9, 57, 48, 476, DateTimeKind.Local).AddTicks(6033), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEJC+Z6c58ynsvtY6Mjdglpj1Lk76L1vhYgLSYCs5EwguKIOFJjVILXwTDDnv4np5uw==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "1df51be7-32c0-4467-95cd-62c0833a49d2", false, "Pato" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "9393ea61-cd44-4ef4-8593-286465d2a5ac", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEFGAmRRA+NDJzg+8bc75ATPcqTf3cq1SSS7F0yatBwfOW9vKa/xSYhJk2Rx1VhpY/Q==", null, false, null, null, "3022217c-0d14-486a-99e1-68aa566ef4be", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "df5f1183-fd0b-49ac-a7a7-859187cc3f8f", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEK8MZ5JM8H2WgnvIkmhxVkEzVLhs1SxzxQotdr7W22IS0pn/W4+XKhAngmon0KH3KA==", null, false, null, null, "8e57c631-c5e0-43a7-b51c-b2a8c3dc05c1", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "e17d266d-18e9-40a5-890a-87330384020f", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBpAF4xseSzM1KgrC8GPufAoqxkGTp2ufDfB/oHdJKwBG1GQT9FoXjVwnaRjYVdMBQ==", null, false, null, null, "9147c756-a815-4db3-a935-ed38b36bc16c", false, "admin" },
                    { "9b0f37ab-5f26-41d0-b6d5-2b81b045b46f", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "bc3672c0-a27d-4f12-9d74-1cb1a7fadb9f", new DateTime(2022, 12, 2, 9, 57, 48, 555, DateTimeKind.Local).AddTicks(5275), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEMZmYlGYPUN2p1OGRDtVvEjB2GPDBKwL2AtmRPlKOIgPzdeU4yvkbs71l0DniuSN/Q==", "8790985467", false, null, "123456789", "f6d7eaef-f00d-4b37-895f-c2a68a77ec79", false, "JoanaM@mymail.com" },
                    { "e94548ba-dafc-44be-9e41-dc7d71b7c588", 0, true, null, "e6c22c8b-2050-4437-acb4-a749fba24573", new DateTime(2022, 12, 2, 9, 57, 48, 501, DateTimeKind.Local).AddTicks(2607), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEChzVPCr1WKjxKDbIo63Rw1gOxutplgL8DmXKVjB0WDnvUCm/igpZHE6eQVqmVVzCg==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "20e137cd-49b4-4c36-af59-fe07d7e4a746", false, "NikosiT@mymail.com" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillMUID", "Balance", "CreatedDate", "MinimumPayment", "PolicyDueDate", "PolicyMUID", "Status" },
                values: new object[,]
                {
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1992), 283.99000000000001, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1990), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "status" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2003), 449.08999999999997, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2001), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "status" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1998), 129.09, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1996), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "status" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1986), 123.98999999999999, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1983), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "status" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqMUID", "Answer", "Question" },
                values: new object[,]
                {
                    { new Guid("104473af-8427-4d40-825f-867a318e1b75"), "Somerset, NJ", "Where Is our company based out of?" },
                    { new Guid("14870cdd-8987-45b2-8aef-39e32af04c83"), "That is your initial role when you first register.  An Admin will approve your account and set you to your appropriate role.", "Why is my role listed as pending?" },
                    { new Guid("d65cc7a0-1582-4501-b1fd-b01e96b17dcc"), "Your policy must first be approved by an Admin, please check your policy again in a little while.", "Why is my policy listed as pending?" }
                });

            migrationBuilder.InsertData(
                table: "GroupRoomMessages",
                columns: new[] { "GroupRoomMessageMUID", "CreatedDate", "FirstName", "GroupRoomMUID", "LastName", "Message", "SenderMUID" },
                values: new object[,]
                {
                    { new Guid("4db427d8-8084-4987-9783-ef1154a0627b"), new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2116), "Leona", new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Wilson", "Sure, What would you like to know?", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce") },
                    { new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a"), new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2108), "Eric", new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "Daley", "Good Morning!", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1") },
                    { new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237"), new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2103), "Patrick", new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Leon", "Hello, How Are you?", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb") },
                    { new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d"), new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2113), "Nikosi", new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "Thom", "I have a question About My Policy", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176") }
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
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), "123", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2060), "123498732", "check Image", 9870, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2062), "credit", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2057), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), "123", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2042), "123498732", "check Image", 345, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2046), "credit", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2039), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), "123", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2051), "123498732", "check Image", 4532, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2054), "credit", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2048), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), "123", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2032), "123498732", "check Image", 123, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2036), "debit", new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(2026), "Jillian", "Flowers", "visa", "2345432", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyMUID", "AnnualLimitOfCoverage", "CustomerMUID", "Deductible", "NameOfPolicy", "OutOfPocketLimit", "Pending", "PolicyEnd_Date", "PolicyOwner", "PolicyPaidOffAmount", "PolicyPaymentisDue", "PolicyStart_Date", "PolicyTotalAmount", "ProductMUID" },
                values: new object[,]
                {
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 500.98000000000002, "Employee Individual Health", 2099.9899999999998, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1867), "Leona wilson", 0.0, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1865), 150000.0, new Guid("b980874f-4978-4c19-b941-c66f1df8052d") },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1861), "Nikosi Thom", 0.0, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1859), 35000.0, new Guid("0ed8ff6d-fc5e-4a8f-ac54-109cdbeb27ea") },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1845), "Patrick Leon", 0.0, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1808), 35000.0, new Guid("79b3d532-56bd-4ec8-811c-ade2445088cb") },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1855), "Eric Daley", 0.0, false, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1852), 35000.0, new Guid("337e2116-7448-4d4c-84c1-7bef1fe8bfdb") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductMUID", "AnnualLimitOfCoverage", "Deductible", "Description", "OutOfPocketLimit", "PolicyPaidOffAmount", "PolicyTotalAmount", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("0ed8ff6d-fc5e-4a8f-ac54-109cdbeb27ea"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 0.0, 2000.0, 789.0, "Eye Emerald" },
                    { new Guid("337e2116-7448-4d4c-84c1-7bef1fe8bfdb"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 0.0, 150000.0, 3343.0, "Health Platinum" },
                    { new Guid("79b3d532-56bd-4ec8-811c-ade2445088cb"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 0.0, 10000.0, 2343.0, "DentalGold" },
                    { new Guid("b980874f-4978-4c19-b941-c66f1df8052d"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 0.0, 100000.0, 1200.98, "Employee Individual Health" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionMUID", "CustomerMUID", "PaymentAmount", "PaymentDate", "PolicyMUID", "isPaymentComplete" },
                values: new object[,]
                {
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1954), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1901), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1896), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 12, 2, 9, 57, 48, 445, DateTimeKind.Local).AddTicks(1950), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "422d4e7c-5e6b-4e87-98b6-63f8111381e9", "161f8c40-6362-4725-b74d-21c627686d91" },
                    { "422d4e7c-5e6b-4e87-98b6-63f8111381e9", "2db7ddd2-579e-4975-870b-b111412db610" },
                    { "e7d78896-ddb6-46af-a773-0213a09ef40c", "477bef17-5d7a-4a10-b59f-b6b6ff801264" },
                    { "422d4e7c-5e6b-4e87-98b6-63f8111381e9", "4c26a4cf-1364-4ed6-b8e6-8e1e23c1794e" },
                    { "e7d78896-ddb6-46af-a773-0213a09ef40c", "5e7d78de-76fb-479e-a2e1-d8886e46b311" },
                    { "e7d78896-ddb6-46af-a773-0213a09ef40c", "8769b938-a65f-4141-9e40-70beca51e382" },
                    { "e7d78896-ddb6-46af-a773-0213a09ef40c", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "422d4e7c-5e6b-4e87-98b6-63f8111381e9", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "de8f69bf-23e2-4cd8-ab79-5248c31e4eae", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "422d4e7c-5e6b-4e87-98b6-63f8111381e9", "9b0f37ab-5f26-41d0-b6d5-2b81b045b46f" },
                    { "e7d78896-ddb6-46af-a773-0213a09ef40c", "e94548ba-dafc-44be-9e41-dc7d71b7c588" }
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
