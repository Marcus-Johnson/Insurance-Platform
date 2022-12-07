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
                    { "3a4e2665-6fa3-430f-a85c-81afaa31a3b3", "fd266964-9aaa-4ac9-8787-1662aca2c6c4", "Admin", "ADMIN" },
                    { "99026326-b0c8-424f-8513-87cdc85feb5c", "165f2e27-0996-4b89-8437-c8890dfe02e4", "Beneficiary", "BENEFICIARY" },
                    { "a8b70ba8-6638-4920-b02c-25cf0f39c9d8", "170df7a2-f3ec-4505-8bb7-24f4a206bfb3", "Customer", "CUSTOMER" },
                    { "a9fde55d-1d1c-48dc-b529-ee39393abc7b", "19995873-62d0-48d6-bfa9-372251295c3f", "Pending", "PENDING" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02bddd7c-b997-401b-8345-a57b9598b977", 0, true, null, "2e83d679-78a6-4b65-8f20-705fd9ad304a", new DateTime(2022, 12, 7, 9, 59, 27, 505, DateTimeKind.Local).AddTicks(2693), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAELVnDda7J7OVtTKJuLTtKk+qmvdFkHV6Y+C9WqECNNWlV7gl0KOC1718cGMpG6VfuQ==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "62d64289-a07d-4aac-a1f3-9258f7619646", false, "Pato" },
                    { "3eb05036-8354-4b5f-9e3d-c08ccf61eae3", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "36ed7000-aff4-4d42-a940-36c849e6b37b", new DateTime(2022, 12, 7, 9, 59, 27, 560, DateTimeKind.Local).AddTicks(7933), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEDOjZtfMJKHZbcNg77dpfhBQiKX2rwJdvS5rPFmn8cjdqnGzkrGjTIO5yXb6Iu/UaQ==", "8790985467", false, null, "123456789", "4e6fe1bf-6a25-4d87-9dd2-84e05bb8fca2", false, "BritneyG@mymail.com" },
                    { "43f2ffec-0dce-4cb6-b91f-b77cffbe2e3f", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "89d2d520-892d-4797-b4f4-b4db6ab02223", new DateTime(2022, 12, 7, 9, 59, 27, 540, DateTimeKind.Local).AddTicks(4390), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEI4HeFz9L2nATyF0GBGzzg1pamiGMrNR0BxhoSTw1YfxompiHO8p8z0lOiqU4IE3rA==", "8790985467", false, null, "123456789", "2fa4786d-085b-47c9-9bd3-5c7811cd4428", false, "AndreaB@mymail.com" },
                    { "7a4347d3-5a95-4ad5-8917-4eda1dc1361b", 0, true, null, "62b53b16-2a8b-4eba-ae02-80fad68a30d2", new DateTime(2022, 12, 7, 9, 59, 27, 513, DateTimeKind.Local).AddTicks(4781), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEK84uwkNLQFNRy9agCwm1m2SfDb0aQ5xaCqgVKPd41aVUlbU+uzqSuHXT3cZj4QGMQ==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "8b96cfe0-c4e0-441b-9d0b-6f62acbbd474", false, "EricD@mymail.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "06aad29e-582e-4ac5-b41e-f3f88f8400e5", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEMo239Y9Je3kzDuWByZlYjJTu3F1rXJ9DaWwQXrT+4FiWBw7/uUy/YByGlpZ35efKA==", null, false, null, null, "daa10c68-c773-4f76-b6cc-0bae4728d6fc", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "13a84992-fbb5-4d5d-823b-9c90bd473f76", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEC2gxf1p4+CThZPxmHXZ6DZ37npUMd/KHGiT83S4R1s76zJc+KAJ82yCqQVLwp505Q==", null, false, null, null, "69c1fcb6-2bd6-47b0-9cf5-9c7e833a5184", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "1cfd306e-df8b-436c-9a19-9879d38c9f84", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEN7LJQbuYKgSJwl+R0EWZNXFZsBwhudPq40XjPhBODKwPrxCknMcbZRsUJy0/9r2LA==", null, false, null, null, "c5aaaf6c-7150-4314-b1f4-d6dfb4833878", false, "admin" },
                    { "9f9f9ddb-55fc-45af-abde-e83ed3c90778", 0, true, null, "bf40522f-ea06-42eb-b4f2-a7420d555832", new DateTime(2022, 12, 7, 9, 59, 27, 531, DateTimeKind.Local).AddTicks(3289), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEJyQDGsBIM9cgE1Xb4Q1spuSzmr13/uCiveLvo9PoYDFLT055vxO4PhpFcPLGnpY/w==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "ca0c3856-76f3-44ee-8a93-184ac370f257", false, "LeonaW@mymail.com" },
                    { "b903da35-7582-4608-910b-6c1373e51a61", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "00de163c-55bd-4f2b-b429-4326a7654b89", new DateTime(2022, 12, 7, 9, 59, 27, 575, DateTimeKind.Local).AddTicks(94), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEKO8Gl3OHF7Ji/+Zy1KtWsl/9+jAX3GnO+GeA4+DBl8zCcXpIifzbZ5GPnKxx7vF9A==", "8790985467", false, null, "123456789", "63c8aa94-2575-48b9-b4f7-6e11713c7720", false, "JoanaM@mymail.com" },
                    { "d0dfe98b-f9c9-462d-9f6d-9c27885c1011", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "57c9796a-f6e7-4e3d-823b-e4c8266ddcad", new DateTime(2022, 12, 7, 9, 59, 27, 549, DateTimeKind.Local).AddTicks(1501), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEDWwNgukZXx8ifvcT//UYIDeusn+FjhAWnW4rRaatUUulUJwtU94hawYy3vMDSbKrQ==", "8790985467", false, null, "123456789", "413571e9-0146-4764-a028-630427b3d3c4", false, "CynthiaS@mymail.com" },
                    { "db90e895-0300-4c54-ad11-af8135acd764", 0, true, null, "6e7527f4-de5b-4297-80cf-00e5f58a00aa", new DateTime(2022, 12, 7, 9, 59, 27, 522, DateTimeKind.Local).AddTicks(6979), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEOb47rz9Q9kcN7B8GoX6hmtdPXQKoM2Vwp/PyAD8mzjVaW8LJgjXM4j4PXYGJVzVRA==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "91483123-0fa3-4e7a-a328-b628d6633c65", false, "NikosiT@mymail.com" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillMUID", "Balance", "CreatedDate", "MinimumPayment", "PolicyDueDate", "PolicyMUID", "Status" },
                values: new object[,]
                {
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6640), 283.99000000000001, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6638), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "Due" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6648), 449.08999999999997, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6647), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "Due" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6644), 129.09, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6642), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "Due" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6635), 123.98999999999999, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6632), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "Due" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqMUID", "Answer", "Question" },
                values: new object[,]
                {
                    { new Guid("d95a7e16-2f44-4702-8f7b-02e68c1961c8"), "Your policy must first be approved by an Admin, please check your policy again in a little while.", "Why is my policy listed as pending?" },
                    { new Guid("efd90b6e-4e27-4fe3-9995-150dd867ec14"), "That is your initial role when you first register.  An Admin will approve your account and set you to your appropriate role.", "Why is my role listed as pending?" },
                    { new Guid("ffdd7f7c-bbfe-4c96-b357-907de5f7614b"), "Somerset, NJ", "Where Is our company based out of?" }
                });

            migrationBuilder.InsertData(
                table: "GroupRoomMessages",
                columns: new[] { "GroupRoomMessageMUID", "CreatedDate", "FirstName", "GroupRoomMUID", "LastName", "Message", "SenderMUID" },
                values: new object[,]
                {
                    { new Guid("4db427d8-8084-4987-9783-ef1154a0627b"), new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6787), "Leona", new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Wilson", "Sure, What would you like to know?", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce") },
                    { new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a"), new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6735), "Eric", new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "Daley", "Good Morning!", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1") },
                    { new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237"), new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6731), "Patrick", new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Leon", "Hello, How Are you?", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb") },
                    { new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d"), new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6738), "Nikosi", new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "Thom", "I have a question About My Policy", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176") }
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
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), "123", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6698), "123498732", "check Image", 9870, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6701), "credit", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6696), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), "123", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6683), "123498732", "check Image", 345, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6687), "credit", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6681), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), "123", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6691), "123498732", "check Image", 4532, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6694), "credit", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6689), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), "123", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6675), "123498732", "check Image", 123, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6678), "debit", new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6671), "Jillian", "Flowers", "visa", "2345432", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyMUID", "AnnualLimitOfCoverage", "CustomerMUID", "Deductible", "NameOfPolicy", "OutOfPocketLimit", "Pending", "PolicyEnd_Date", "PolicyOwner", "PolicyPaidOffAmount", "PolicyPaymentisDue", "PolicyStart_Date", "PolicyTotalAmount", "ProductMUID" },
                values: new object[,]
                {
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 500.98000000000002, "Employee Individual Health", 2099.9899999999998, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6579), "Leona wilson", 0.0, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6577), 150000.0, new Guid("29fe2632-7666-49e3-a592-93437dcaf1ff") },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6574), "Nikosi Thom", 0.0, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6572), 35000.0, new Guid("7634969c-1f74-43f9-a6bd-7b89711c3e29") },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6562), "Patrick Leon", 0.0, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6535), 35000.0, new Guid("a75728c8-9b55-4e74-a5ee-674bb81076a4") },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6569), "Eric Daley", 0.0, false, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6567), 35000.0, new Guid("858ab7c0-ff96-4fee-a277-f19b2b64340c") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductMUID", "AnnualLimitOfCoverage", "Deductible", "Description", "OutOfPocketLimit", "PolicyPaidOffAmount", "PolicyTotalAmount", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("29fe2632-7666-49e3-a592-93437dcaf1ff"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 0.0, 100000.0, 1200.98, "Employee Individual Health" },
                    { new Guid("7634969c-1f74-43f9-a6bd-7b89711c3e29"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 0.0, 2000.0, 789.0, "Eye Emerald" },
                    { new Guid("858ab7c0-ff96-4fee-a277-f19b2b64340c"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 0.0, 150000.0, 3343.0, "Health Platinum" },
                    { new Guid("a75728c8-9b55-4e74-a5ee-674bb81076a4"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 0.0, 10000.0, 2343.0, "DentalGold" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionMUID", "CustomerMUID", "PaymentAmount", "PaymentDate", "PolicyMUID", "isPaymentComplete" },
                values: new object[,]
                {
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6612), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6607), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6603), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 12, 7, 9, 59, 27, 476, DateTimeKind.Local).AddTicks(6610), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a8b70ba8-6638-4920-b02c-25cf0f39c9d8", "02bddd7c-b997-401b-8345-a57b9598b977" },
                    { "99026326-b0c8-424f-8513-87cdc85feb5c", "3eb05036-8354-4b5f-9e3d-c08ccf61eae3" },
                    { "99026326-b0c8-424f-8513-87cdc85feb5c", "43f2ffec-0dce-4cb6-b91f-b77cffbe2e3f" },
                    { "a8b70ba8-6638-4920-b02c-25cf0f39c9d8", "7a4347d3-5a95-4ad5-8917-4eda1dc1361b" },
                    { "a8b70ba8-6638-4920-b02c-25cf0f39c9d8", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "99026326-b0c8-424f-8513-87cdc85feb5c", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "3a4e2665-6fa3-430f-a85c-81afaa31a3b3", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "a8b70ba8-6638-4920-b02c-25cf0f39c9d8", "9f9f9ddb-55fc-45af-abde-e83ed3c90778" },
                    { "99026326-b0c8-424f-8513-87cdc85feb5c", "b903da35-7582-4608-910b-6c1373e51a61" },
                    { "99026326-b0c8-424f-8513-87cdc85feb5c", "d0dfe98b-f9c9-462d-9f6d-9c27885c1011" },
                    { "a8b70ba8-6638-4920-b02c-25cf0f39c9d8", "db90e895-0300-4c54-ad11-af8135acd764" }
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
