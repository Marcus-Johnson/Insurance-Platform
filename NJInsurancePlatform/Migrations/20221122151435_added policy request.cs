using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NJInsurancePlatform.Migrations
{
    public partial class addedpolicyrequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25577c99-b693-4183-8c68-3e1bdcebd303");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "0307e8f3-6e35-4482-beb0-557d5e067602" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "125dbdc6-1ee7-42e4-b95b-41d9d3796e88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "40e86f87-2521-46a8-920e-588f30e019c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "5e151217-a523-42ce-b5c4-57480c9b9d56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7ca7932-95f8-4198-bd73-0d7dc3f1420e", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "a6812865-5cef-4d6f-acfe-e2b231ec07c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "ab59cf90-ee4f-4f1b-8d23-d588adfc3e9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "b4cd1b2f-59bc-4408-b8e1-680f9797925c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "de219bb6-f7e3-4efd-9fb8-f27d2cae3923" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7ca7932-95f8-4198-bd73-0d7dc3f1420e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d78c4067-009c-4552-bd91-2351f1c4a0a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0307e8f3-6e35-4482-beb0-557d5e067602");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125dbdc6-1ee7-42e4-b95b-41d9d3796e88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40e86f87-2521-46a8-920e-588f30e019c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e151217-a523-42ce-b5c4-57480c9b9d56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6812865-5cef-4d6f-acfe-e2b231ec07c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab59cf90-ee4f-4f1b-8d23-d588adfc3e9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4cd1b2f-59bc-4408-b8e1-680f9797925c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de219bb6-f7e3-4efd-9fb8-f27d2cae3923");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "74b1f57f-1609-42b9-8438-870bbc37fe67", "Customer", "CUSTOMER" },
                    { "469a812a-dc44-4fb0-8437-efdb12f6ad38", "26a9f6c8-eac2-4dd7-b4b2-364fcb471b80", "Admin", "ADMIN" },
                    { "63419f5d-1aa3-4855-a9a3-d7038c6ea6e7", "e811e260-3b90-44e5-a2ad-908be3a3da2a", "Pending", "PENDING" },
                    { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "e5d2c3df-d865-458d-801a-ffd847e44029", "Beneficiary", "BENEFICIARY" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe0d8cef-fe98-4585-9caf-817ce68c70c7", "AQAAAAEAACcQAAAAEA5mvQ0anATxdvroPS3ZBD+Q9h9Ab1JBq6rhcpuq2VKWagPrt9nd/wKFZDPegKNmmw==", "f8906e28-1be0-4886-a55d-a1558c0212fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89219911-f6ba-46ef-9699-23e9e85821f1", "AQAAAAEAACcQAAAAEK3jVk10W+LEgIf9sOS5IROODJk2dKNYMqDjRQvaJzo0dBBx9NP58b3xZuoQe2FjRQ==", "a3edddd3-bd13-46ab-bf8b-7a4eec48f6d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82801642-b639-4df1-8842-97a41558b695", "AQAAAAEAACcQAAAAEEc2KuMeBtQxxA9I4jnDNDxZ0fxAQBdJOhUno3z1KfhtCnoEebHpEWOKUAcEzQGIZw==", "30021faf-55a8-4fb0-8d2f-6e1baf588a30" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08baab79-3fb7-4da3-835e-c0790db0fb0c", 0, true, null, "8c6f8f9d-40b8-41bd-82bb-b29be81aa951", new DateTime(2022, 11, 22, 10, 14, 34, 687, DateTimeKind.Local).AddTicks(6166), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEKIC82xI2jAoP0wTJ5fAyZQ3JtOQb9JCCKoDVwwpmUia3bWI4hHeAy40lu3Jq7GNlg==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "d51dd313-94b8-4656-aca0-13d96ef457a9", false, "NikosiT@mymail.com" },
                    { "09b11af0-e332-47c6-8857-a53e35e7b0e5", 0, true, null, "b2333880-36a4-43e9-8f40-e45296caef61", new DateTime(2022, 11, 22, 10, 14, 34, 699, DateTimeKind.Local).AddTicks(391), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEDodlYyIjC/+R8lksRgXCgILEgzKmz+kP3gyjMVC4cgBSlr4o55wmfMgGai94E9xAQ==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "51b0fd82-ca95-4a0d-a314-285ddef3cb85", false, "LeonaW@mymail.com" },
                    { "582b6b5a-e3e8-4fbf-9eec-1d1f57759f4f", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "141b0fdd-97e0-459f-9333-4090a0440919", new DateTime(2022, 11, 22, 10, 14, 34, 708, DateTimeKind.Local).AddTicks(7393), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEKC5uNaGnplCEBO0dlZ58v/kRVmaCdrWT9ozFzrJ5LABTGrnw1Scyf4vTINDNeYebg==", "8790985467", false, null, "123456789", "20c7fd44-0dc1-4922-8dcd-fe1b239d26ee", false, "AndreaB@mymail.com" },
                    { "708bc36e-060f-4162-b23c-d78a4aa482ad", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "4fdc9ba4-88e0-41d2-a23a-0dc97f40460c", new DateTime(2022, 11, 22, 10, 14, 34, 728, DateTimeKind.Local).AddTicks(3407), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEES1mWcscX5fbIGH6ock3Z1td0kCRH6abqbYx6urx+GjcPeX5kZd3AJwO3bJpE9MQw==", "8790985467", false, null, "123456789", "a11b088a-e04b-4809-b755-368ce074f299", false, "BritneyG@mymail.com" },
                    { "a8d97fa0-a27b-4431-9422-2ee1a8d86e21", 0, true, null, "205067f5-22fb-40af-91f4-0701e52ce8d0", new DateTime(2022, 11, 22, 10, 14, 34, 667, DateTimeKind.Local).AddTicks(9486), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEHjl16whxjDYafLwFfrNh1CIWrKriFeIr7mmrcTsIjP1eAfjVBxwmHu/U/Ku7CQUiA==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "6363d0b2-5f15-4ee4-b9e5-688b1d66a039", false, "Pato" },
                    { "b2d66bff-ebfb-46df-836d-80abd3c0c2a5", 0, true, null, "5b4cbd60-4973-4c32-979c-8e1506497737", new DateTime(2022, 11, 22, 10, 14, 34, 678, DateTimeKind.Local).AddTicks(8975), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEE1kDV3rYlVxcopypEF9UlSLHt5mhCW4wzCm1eEhU/KC8GeW/Htb3uFe6hhlClvgxA==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "95b4560b-c481-4b56-b62e-ab6074832483", false, "EricD@mymail.com" },
                    { "b872914d-512d-4317-988e-d175d2331b79", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "f26c9c22-7f0b-4139-818d-e8eac429c152", new DateTime(2022, 11, 22, 10, 14, 34, 718, DateTimeKind.Local).AddTicks(4128), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEEs2PhsHAmEayFjzLP4HJ12RewRCXoQqFGqMYnGrr0D5yUoZ5OGv0aNxuTOdF4mktQ==", "8790985467", false, null, "123456789", "9d594f7f-5b54-4146-bea2-e12586a757f3", false, "CynthiaS@mymail.com" },
                    { "cd8d4841-59ce-4a1d-b7d3-90cfd268f660", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "cec64649-4ced-481a-97e3-448267ffadb0", new DateTime(2022, 11, 22, 10, 14, 34, 736, DateTimeKind.Local).AddTicks(9718), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEAKTwT4T5e8RWffVPtTA5K9FUMmk336+9sQlRdQLa6Xf/N/NuRy8ARgp+4gRX0BHUw==", "8790985467", false, null, "123456789", "c469496d-2a88-4149-9915-36fb05c1f54b", false, "JoanaM@mymail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("417a8279-0227-43c4-8504-c4396860ada0"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3494), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3524), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("c28330de-a718-465b-9772-5b28ad6395e8"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3508), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("f46090ed-d574-4456-8e18-97150ff885ed"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3648), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3652), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3619), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3633), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3636), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3601), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3607), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3133), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 22, 10, 14, 34, 639, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "08baab79-3fb7-4da3-835e-c0790db0fb0c" },
                    { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "09b11af0-e332-47c6-8857-a53e35e7b0e5" },
                    { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "582b6b5a-e3e8-4fbf-9eec-1d1f57759f4f" },
                    { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "708bc36e-060f-4162-b23c-d78a4aa482ad" },
                    { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "469a812a-dc44-4fb0-8437-efdb12f6ad38", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "a8d97fa0-a27b-4431-9422-2ee1a8d86e21" },
                    { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "b2d66bff-ebfb-46df-836d-80abd3c0c2a5" },
                    { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "b872914d-512d-4317-988e-d175d2331b79" },
                    { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "cd8d4841-59ce-4a1d-b7d3-90cfd268f660" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyRequests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63419f5d-1aa3-4855-a9a3-d7038c6ea6e7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "08baab79-3fb7-4da3-835e-c0790db0fb0c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "09b11af0-e332-47c6-8857-a53e35e7b0e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "582b6b5a-e3e8-4fbf-9eec-1d1f57759f4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "708bc36e-060f-4162-b23c-d78a4aa482ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "469a812a-dc44-4fb0-8437-efdb12f6ad38", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "a8d97fa0-a27b-4431-9422-2ee1a8d86e21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9", "b2d66bff-ebfb-46df-836d-80abd3c0c2a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "b872914d-512d-4317-988e-d175d2331b79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c655842c-8a18-424c-b65b-0d4ce96fd2c5", "cd8d4841-59ce-4a1d-b7d3-90cfd268f660" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d5debc0-f21f-45e2-ada1-08c7ccbfa8e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "469a812a-dc44-4fb0-8437-efdb12f6ad38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c655842c-8a18-424c-b65b-0d4ce96fd2c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08baab79-3fb7-4da3-835e-c0790db0fb0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09b11af0-e332-47c6-8857-a53e35e7b0e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "582b6b5a-e3e8-4fbf-9eec-1d1f57759f4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "708bc36e-060f-4162-b23c-d78a4aa482ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d97fa0-a27b-4431-9422-2ee1a8d86e21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2d66bff-ebfb-46df-836d-80abd3c0c2a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b872914d-512d-4317-988e-d175d2331b79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd8d4841-59ce-4a1d-b7d3-90cfd268f660");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "d021d442-e207-4421-90ca-d06b9ab1ec9c", "Beneficiary", "BENEFICIARY" },
                    { "25577c99-b693-4183-8c68-3e1bdcebd303", "f9c9e090-66eb-4b30-86f3-eb3d0c7ee0e6", "Pending", "PENDING" },
                    { "a7ca7932-95f8-4198-bd73-0d7dc3f1420e", "4413ecf9-c87e-4062-9dbf-705ea1d16238", "Admin", "ADMIN" },
                    { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "27cb0409-9d5c-4648-b59e-36913e56fcc6", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c25aa18-fc5c-4782-9815-ba3a67fdac97", "AQAAAAEAACcQAAAAEO4Ir9R0LxGujzrH9IE20S3o30tW2CvMMdKtnZU5MovJrCYhyjEvhqzoG9BVD9PRow==", "75269e6c-07b7-4442-aad8-5024304e278f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40dd4f92-c30f-4716-8424-ac51a260cdc5", "AQAAAAEAACcQAAAAEBpPppybYWP+F75MIo6dYagQ0JRCbur2QFIRNz/9MDuSLHiG+O5ZgVVLC0ATJK5KYA==", "4aaa8e06-cc5e-446c-bf31-45b9e01f616b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5780d7-7a52-4519-8784-e0280345ad8c", "AQAAAAEAACcQAAAAEKYeTIH8mq0c+rjNcmZtNOn/+KZKv12ICSY62kakuoCTkK+VtZRZPoe49z9vT3VzEw==", "86d1fe0d-2edd-441e-97fa-72807e357f91" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0307e8f3-6e35-4482-beb0-557d5e067602", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "3dea3981-67b9-4418-b6bb-5a07f3c62ccd", new DateTime(2022, 11, 21, 20, 43, 16, 22, DateTimeKind.Local).AddTicks(3837), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEJwfGMKnisgtgwPYmIBeWv6T54LfdpRTuF8pfnXAou8XmCueRkt0t4xr0RwIz6OJRA==", "8790985467", false, null, "123456789", "76e4ff2c-0d50-49d4-a75b-74a84a150be1", false, "CynthiaS@mymail.com" },
                    { "125dbdc6-1ee7-42e4-b95b-41d9d3796e88", 0, true, null, "dcbf8af9-73e7-4c80-bb1c-ba5f876bda83", new DateTime(2022, 11, 21, 20, 43, 16, 20, DateTimeKind.Local).AddTicks(3087), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEK9RRasitIeCUDwY9WROId6FaNrPzpqE5d1G0IIz4cYMgvUCNxPMhIIJxE290B0WLQ==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "a343ab54-b392-4cef-b1dc-242d1dd421c0", false, "LeonaW@mymail.com" },
                    { "40e86f87-2521-46a8-920e-588f30e019c4", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "29ee84d7-7c82-4893-a07d-c6d5d9d72e65", new DateTime(2022, 11, 21, 20, 43, 16, 23, DateTimeKind.Local).AddTicks(5525), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEHZpIEpxjZ72ZMjsbDwQ/VLbPam+amluUZhIeA/ijL4egulkOycbxLe7f47o1TbpSQ==", "8790985467", false, null, "123456789", "79a48203-391f-439c-9dce-bb2a28aabed7", false, "BritneyG@mymail.com" },
                    { "5e151217-a523-42ce-b5c4-57480c9b9d56", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "75e5e574-935a-4435-9201-413d8f652b00", new DateTime(2022, 11, 21, 20, 43, 16, 24, DateTimeKind.Local).AddTicks(6100), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEOst5gzAI3PrHVHRiSZYqI4x9RB5xC3cu2fqHm9RT17ap3yKfAmyFzNBTrc2/IreIg==", "8790985467", false, null, "123456789", "ee993911-3ea0-4e28-8815-1beb3f8f9504", false, "JoanaM@mymail.com" },
                    { "a6812865-5cef-4d6f-acfe-e2b231ec07c9", 0, true, null, "e6a170a0-f641-494a-a8ba-6ea0c3780f18", new DateTime(2022, 11, 21, 20, 43, 16, 19, DateTimeKind.Local).AddTicks(2762), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAENblfMBaGCz/yc0wNnLSq9taYYY7gBbzsJk8nLgwcVGskywa8f6TI2SjnntkMFvTpg==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "17b1d1ce-fe3c-470d-98da-cab882cd42f8", false, "NikosiT@mymail.com" },
                    { "ab59cf90-ee4f-4f1b-8d23-d588adfc3e9f", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "26b186dd-87d9-42de-836b-08e43ed60cbb", new DateTime(2022, 11, 21, 20, 43, 16, 21, DateTimeKind.Local).AddTicks(3531), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEOBibAJsWosA8rGbgXlF9uLA6guvzjJXy1msMGZGKV+J4KM/SLSPk6b9n7/PFRTIYQ==", "8790985467", false, null, "123456789", "dd68f782-598e-4918-946e-42fdd912dc3c", false, "AndreaB@mymail.com" },
                    { "b4cd1b2f-59bc-4408-b8e1-680f9797925c", 0, true, null, "11e61691-9d56-43b9-9de5-59be1a566cdf", new DateTime(2022, 11, 21, 20, 43, 16, 17, DateTimeKind.Local).AddTicks(1771), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAED227LsuK2Vbdf++g3LF7Ek8iMQNIqPSuAeav/BNH3jlA45sp1GgiSXh55MZ+mWDqA==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "59c9f39e-7607-4d3e-b042-4b9da36c9664", false, "Pato" },
                    { "de219bb6-f7e3-4efd-9fb8-f27d2cae3923", 0, true, null, "057be2d2-3c19-4ad1-b49b-9f929b49a087", new DateTime(2022, 11, 21, 20, 43, 16, 18, DateTimeKind.Local).AddTicks(2254), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEK7jDPJbapEPsfv8XpaxFSJ0FsIGgP6dD35Led8CKlHCGLzmbPQdUXupFZCRDGNs+Q==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "472b7557-758f-4e07-8381-d330cfc35b9f", false, "EricD@mymail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("417a8279-0227-43c4-8504-c4396860ada0"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3068), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("c28330de-a718-465b-9772-5b28ad6395e8"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3072), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("f46090ed-d574-4456-8e18-97150ff885ed"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3063), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3129), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3116), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3118), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3104), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3107), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2879), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2868), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 20, 43, 16, 13, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "0307e8f3-6e35-4482-beb0-557d5e067602" },
                    { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "125dbdc6-1ee7-42e4-b95b-41d9d3796e88" },
                    { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "40e86f87-2521-46a8-920e-588f30e019c4" },
                    { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "5e151217-a523-42ce-b5c4-57480c9b9d56" },
                    { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "a7ca7932-95f8-4198-bd73-0d7dc3f1420e", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "a6812865-5cef-4d6f-acfe-e2b231ec07c9" },
                    { "1f6191fc-6ab0-4d8b-8795-fe9ffad47ba5", "ab59cf90-ee4f-4f1b-8d23-d588adfc3e9f" },
                    { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "b4cd1b2f-59bc-4408-b8e1-680f9797925c" },
                    { "d78c4067-009c-4552-bd91-2351f1c4a0a8", "de219bb6-f7e3-4efd-9fb8-f27d2cae3923" }
                });
        }
    }
}
