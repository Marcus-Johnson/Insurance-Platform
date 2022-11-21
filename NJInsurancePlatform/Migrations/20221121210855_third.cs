using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NJInsurancePlatform.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912a8751-e6a0-46d6-8546-786e0c4813d7", "6eb8b32f-4e50-4a80-a068-4b028b0ecc88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912a8751-e6a0-46d6-8546-786e0c4813d7", "8619e534-87af-43d2-8348-2e9ebaf3d6fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912a8751-e6a0-46d6-8546-786e0c4813d7", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25685cf8-540b-484d-b157-af99716a8efb", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "9e2f4d97-184b-472a-b1fa-d2363d0c3888" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "a26abc68-11ee-40e9-81d2-88080259d85f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912a8751-e6a0-46d6-8546-786e0c4813d7", "a3c8907b-d386-4deb-a0af-0c0685c0fae7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "bc87d4d0-5a7d-4f7a-97a1-74838ffef246" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "912a8751-e6a0-46d6-8546-786e0c4813d7", "d40890f8-e589-4c21-8fcb-a1fa40cdcf9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "fd758d91-8cd7-41b6-a5e1-20f4da066059" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25685cf8-540b-484d-b157-af99716a8efb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "912a8751-e6a0-46d6-8546-786e0c4813d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d249fd3f-45d8-47bd-9aa3-26932ef2a036");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eb8b32f-4e50-4a80-a068-4b028b0ecc88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8619e534-87af-43d2-8348-2e9ebaf3d6fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e2f4d97-184b-472a-b1fa-d2363d0c3888");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a26abc68-11ee-40e9-81d2-88080259d85f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3c8907b-d386-4deb-a0af-0c0685c0fae7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc87d4d0-5a7d-4f7a-97a1-74838ffef246");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40890f8-e589-4c21-8fcb-a1fa40cdcf9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd758d91-8cd7-41b6-a5e1-20f4da066059");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eca1571-7b24-45e4-b954-16ba4f784a24", "8413e49c-2041-4692-b538-9ddf25c004a6", "Customer", "CUSTOMER" },
                    { "21e7a712-103a-4380-9db2-6419a1d3ca69", "2a77721d-eec7-457c-8abc-f3bee0a38a7e", "Admin", "ADMIN" },
                    { "df5396bf-8c29-4dc8-9f10-78eccc312115", "17e6a517-9435-416f-bb10-2412deb07eee", "Beneficiary", "BENEFICIARY" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9942605c-a104-4fe4-a5d1-590a9acedc9c", "AQAAAAEAACcQAAAAEDhH6lXjcWLjGOEb/Qm4Ffghqlrk1lg3VFWVM2XE2vE+Oh+EC8yj91bkkXAMJIx/3w==", "088ccc6c-b85c-4ce6-8337-71a263bc29f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f85f8df-ed42-4c2a-9eb7-78a4bf4e67f3", "AQAAAAEAACcQAAAAELtf8j14zvL4MthTc6WMP9PDube1JfVc0qPcVUyoNfRKKggInT/0RGk+dNLHt+Yv3Q==", "1675eedd-6a48-434a-88f0-f55526337ac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a0f680a-4c17-4bdf-8435-aadd3046f591", "AQAAAAEAACcQAAAAEFNRE1sRQ2EV08GcICRV87+ItN3P7dKpsXqy+i5+QpxcTtwGrfAtImnPojjobL3SIQ==", "c979451e-91e8-4a4e-bbfd-1ad4166ae372" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "411a0591-2fd5-46f1-adc9-18127005cf4c", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "39beaa05-d956-47ea-b83e-07225358669c", new DateTime(2022, 11, 21, 16, 8, 53, 738, DateTimeKind.Local).AddTicks(6411), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEEepZnuDgwpWAqx+3V3nsFFqgs+ihRN9dH64QaeCOEuN/cOPKVucB9Y2T2vQY7dXIg==", "8790985467", false, null, "123456789", "1c334180-9c81-41f3-89d3-834db585b7ab", false, "CynthiaS@mymail.com" },
                    { "50c95d93-c8f0-474c-bc34-327a17b2ae10", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "74294538-1a9e-4d6c-9e48-6f01e5715c8c", new DateTime(2022, 11, 21, 16, 8, 53, 754, DateTimeKind.Local).AddTicks(2527), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEFe1zAW7MSVyfIr9FkfK2zn8pa4Kyn5UAL6nfFNTyQABXVHKsPNiRQTLhJnUH4aKQg==", "8790985467", false, null, "123456789", "35c98702-9eea-486a-81e2-8ab295df28e9", false, "BritneyG@mymail.com" },
                    { "a7e3720c-ad69-4298-85de-c4321f223d31", 0, true, null, "a0267f76-8291-4f14-ab64-c881ebfa1cd0", new DateTime(2022, 11, 21, 16, 8, 53, 713, DateTimeKind.Local).AddTicks(9480), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEJ6loa+AtsL+Am4FHZ3qRSW2Uf2TNsi66hv8d4hvK1glH25keUYFxTLTxTKpyFbw+A==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "ca09d32c-7a0d-4a38-a4e8-033cee2a3e26", false, "LeonaW@mymail.com" },
                    { "ab64114a-9654-479d-9861-582593ab731c", 0, true, null, "45755027-6caa-449b-818c-980e5d3a5dea", new DateTime(2022, 11, 21, 16, 8, 53, 701, DateTimeKind.Local).AddTicks(1755), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEAMMT34ZfS+qUmXttW2E6bmSUlu68jWXun7APJN00QmKYl4ecUyi3qo6Ndyk6JMArg==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "41d94379-db81-4f2a-8ec5-dcf132eec0ab", false, "NikosiT@mymail.com" },
                    { "e09bbfb2-7753-420f-a26d-763707980ae7", 0, true, null, "33fb9cb5-ee52-453c-8232-14b9b593bbc6", new DateTime(2022, 11, 21, 16, 8, 53, 688, DateTimeKind.Local).AddTicks(967), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAELkk8Yt5lpVD3yAFbQbxAdlItfiFW7sGkEQqQllfaVL0kJpSxBdRBNex8IAimC1T2w==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "2922bced-1b5f-42cb-87b8-225975d0e245", false, "EricD@mymail.com" },
                    { "f7fbb3c0-7071-4bc7-bc99-318ed16f5ada", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "340a4865-f7d5-45db-af5c-cad42f3de890", new DateTime(2022, 11, 21, 16, 8, 53, 768, DateTimeKind.Local).AddTicks(5257), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEHx9gA76t4we2i53LklTu6KTAkqT1ShZBrha8+rjwV9V5ptS4KosU25OACtru1vUSA==", "8790985467", false, null, "123456789", "0d0bffbc-03e9-43ca-9180-a9ef2a7b1b7e", false, "JoanaM@mymail.com" },
                    { "fc6bacd0-c50a-461e-9bd4-41a646a31ddf", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "721a6b24-873d-42c4-ae5a-5406986a9bdb", new DateTime(2022, 11, 21, 16, 8, 53, 724, DateTimeKind.Local).AddTicks(9831), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAECdvqUPOgus4s7qZsPzsL7PzW3OleKRrc+Vm6BMM7aLRKvq2d1JgV2wF/s6rJ2Lfeg==", "8790985467", false, null, "123456789", "21274632-e7cd-4e4d-9584-9d30875de873", false, "AndreaB@mymail.com" },
                    { "ff4e5421-687f-4ed0-9b74-d9851dddef0e", 0, true, null, "aab310c7-ff13-4449-8c14-1ae8d0744f10", new DateTime(2022, 11, 21, 16, 8, 53, 672, DateTimeKind.Local).AddTicks(2024), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAELINMbSMU0Tma2+qC5UZ9SEmOuDayEk2oQlHj2s1l6+g9iKYjWL2mtuQsFsKoE+29Q==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "70ef44cf-e92b-49b8-8e3e-4e96e758735c", false, "Pato" }
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("417a8279-0227-43c4-8504-c4396860ada0"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7774), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7784), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("c28330de-a718-465b-9772-5b28ad6395e8"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7779), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("f46090ed-d574-4456-8e18-97150ff885ed"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7767), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7853), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7855), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7835), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7839), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7845), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7847), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7824), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7828), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6844), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6833), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6815), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6825), new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 8, 53, 627, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "df5396bf-8c29-4dc8-9f10-78eccc312115", "411a0591-2fd5-46f1-adc9-18127005cf4c" },
                    { "df5396bf-8c29-4dc8-9f10-78eccc312115", "50c95d93-c8f0-474c-bc34-327a17b2ae10" },
                    { "0eca1571-7b24-45e4-b954-16ba4f784a24", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "df5396bf-8c29-4dc8-9f10-78eccc312115", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "21e7a712-103a-4380-9db2-6419a1d3ca69", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "0eca1571-7b24-45e4-b954-16ba4f784a24", "a7e3720c-ad69-4298-85de-c4321f223d31" },
                    { "0eca1571-7b24-45e4-b954-16ba4f784a24", "ab64114a-9654-479d-9861-582593ab731c" },
                    { "0eca1571-7b24-45e4-b954-16ba4f784a24", "e09bbfb2-7753-420f-a26d-763707980ae7" },
                    { "df5396bf-8c29-4dc8-9f10-78eccc312115", "f7fbb3c0-7071-4bc7-bc99-318ed16f5ada" },
                    { "df5396bf-8c29-4dc8-9f10-78eccc312115", "fc6bacd0-c50a-461e-9bd4-41a646a31ddf" },
                    { "0eca1571-7b24-45e4-b954-16ba4f784a24", "ff4e5421-687f-4ed0-9b74-d9851dddef0e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df5396bf-8c29-4dc8-9f10-78eccc312115", "411a0591-2fd5-46f1-adc9-18127005cf4c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df5396bf-8c29-4dc8-9f10-78eccc312115", "50c95d93-c8f0-474c-bc34-327a17b2ae10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eca1571-7b24-45e4-b954-16ba4f784a24", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df5396bf-8c29-4dc8-9f10-78eccc312115", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21e7a712-103a-4380-9db2-6419a1d3ca69", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eca1571-7b24-45e4-b954-16ba4f784a24", "a7e3720c-ad69-4298-85de-c4321f223d31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eca1571-7b24-45e4-b954-16ba4f784a24", "ab64114a-9654-479d-9861-582593ab731c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eca1571-7b24-45e4-b954-16ba4f784a24", "e09bbfb2-7753-420f-a26d-763707980ae7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df5396bf-8c29-4dc8-9f10-78eccc312115", "f7fbb3c0-7071-4bc7-bc99-318ed16f5ada" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df5396bf-8c29-4dc8-9f10-78eccc312115", "fc6bacd0-c50a-461e-9bd4-41a646a31ddf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eca1571-7b24-45e4-b954-16ba4f784a24", "ff4e5421-687f-4ed0-9b74-d9851dddef0e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eca1571-7b24-45e4-b954-16ba4f784a24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21e7a712-103a-4380-9db2-6419a1d3ca69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df5396bf-8c29-4dc8-9f10-78eccc312115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "411a0591-2fd5-46f1-adc9-18127005cf4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50c95d93-c8f0-474c-bc34-327a17b2ae10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7e3720c-ad69-4298-85de-c4321f223d31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab64114a-9654-479d-9861-582593ab731c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e09bbfb2-7753-420f-a26d-763707980ae7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7fbb3c0-7071-4bc7-bc99-318ed16f5ada");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc6bacd0-c50a-461e-9bd4-41a646a31ddf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff4e5421-687f-4ed0-9b74-d9851dddef0e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25685cf8-540b-484d-b157-af99716a8efb", "632f1b6c-cf26-424a-9896-ec7251cbc881", "Admin", "ADMIN" },
                    { "912a8751-e6a0-46d6-8546-786e0c4813d7", "20c53369-9e41-4bb0-b516-31264ca68e96", "Customer", "CUSTOMER" },
                    { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "72813c3f-b7bb-4bc1-93f0-59551146f1b7", "Beneficiary", "BENEFICIARY" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c46d0538-057b-4397-af50-b255bfeb284b", "AQAAAAEAACcQAAAAEMKiZW8D76Q4Y4/Hu+WEWq3trcOy8A6IEUhbb8DZI958whWK2dzkBFar/OKyeYsr0w==", "096a1019-dbec-42f1-92d9-2295b784cf85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a52fec-de70-41f1-8794-ce0d1aaa737b", "AQAAAAEAACcQAAAAEGWcYhTkcf3r9yxrKvQp43Z4BDnXUb2morifFaeNEYWW5k2AUQIsVVPwsjYqBNoutg==", "eac5a8bb-b79e-4764-8777-e95e0fd71bf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82497e6b-9905-4d74-8253-89a07ec63644", "AQAAAAEAACcQAAAAEGN4SpYkslqNVmZ9uRPuJcUhwA4hGzwr0XAS/tMLs80sw4Fl2NjXqzWFdJcq3vwqRg==", "26d62d56-eed4-4d09-8b62-ac61366269a5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6eb8b32f-4e50-4a80-a068-4b028b0ecc88", 0, true, null, "a87e25cb-b712-45b0-9d8e-d98fc78c94e2", new DateTime(2022, 11, 21, 16, 4, 47, 548, DateTimeKind.Local).AddTicks(6227), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEH30eYsW75mvuilrzCXAFHlKwHQuk5T8K1USAAygozKhm+ISGHI6CTJCAQCGL0U49Q==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "8ddd1ab6-33c2-46ed-befe-41eb1a6f0d71", false, "LeonaW@mymail.com" },
                    { "8619e534-87af-43d2-8348-2e9ebaf3d6fd", 0, true, null, "3efb05f1-c1ab-4d76-b24e-bd5a6dd5c49d", new DateTime(2022, 11, 21, 16, 4, 47, 503, DateTimeKind.Local).AddTicks(449), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEItNYT/b4tc4MKSL3XnbpEXs+z6CiX1m9S3iXtwYWICct/1mZugX+BxanOapXZbxBA==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "ae9a513b-aebb-42fe-ab53-9497d98b1e2e", false, "Pato" },
                    { "9e2f4d97-184b-472a-b1fa-d2363d0c3888", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "318daa59-ff31-4254-8fce-15ebb8eda60f", new DateTime(2022, 11, 21, 16, 4, 47, 606, DateTimeKind.Local).AddTicks(4771), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEGL6qkmCClYzSrVhft/mWljirw4k+pSzacm7scagPKc/olGnTPAlSfrsGQFWGuCFJA==", "8790985467", false, null, "123456789", "9a51ed53-c0d7-4844-bc46-28c15a70e805", false, "JoanaM@mymail.com" },
                    { "a26abc68-11ee-40e9-81d2-88080259d85f", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "85ed38fc-b6a3-4e63-9865-4ee8085dae4e", new DateTime(2022, 11, 21, 16, 4, 47, 577, DateTimeKind.Local).AddTicks(6125), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEBOybAt75M1eleshyUjkoNp/6eWzC7blajlNvrV1+BS/TbYh/N/wQ1aRH0n3ROXVog==", "8790985467", false, null, "123456789", "bf86f9db-4453-4558-a616-97346f8fbea9", false, "CynthiaS@mymail.com" },
                    { "a3c8907b-d386-4deb-a0af-0c0685c0fae7", 0, true, null, "06196ed2-7076-44ef-8bc6-b9d8c2a21b23", new DateTime(2022, 11, 21, 16, 4, 47, 534, DateTimeKind.Local).AddTicks(7298), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEBgL8bIKhcxrulEwdOJnXlO3hQmrWqNbK8LLu9BWNvZTeaIBG7NR9KLhYboRUorwwQ==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "cff96800-e005-4098-bfde-bafe5dd2de16", false, "NikosiT@mymail.com" },
                    { "bc87d4d0-5a7d-4f7a-97a1-74838ffef246", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "975f330f-a769-4478-8cbe-d3eb36f2cfce", new DateTime(2022, 11, 21, 16, 4, 47, 588, DateTimeKind.Local).AddTicks(7174), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEJXWRVLP8Lbq+6LRiO+2kKFdedIOL+V+fJ003BdQDMG6v4N4+bJCa+ivfc35xQwTDA==", "8790985467", false, null, "123456789", "dc964be6-61cd-4328-96ea-d96a329691a8", false, "BritneyG@mymail.com" },
                    { "d40890f8-e589-4c21-8fcb-a1fa40cdcf9d", 0, true, null, "074dd417-db8c-42bb-8757-a3cf23c66d87", new DateTime(2022, 11, 21, 16, 4, 47, 521, DateTimeKind.Local).AddTicks(6147), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAECQE3uzZAqdUQ+qm67yH4CE0jSkWAlCQMQ4qNS4ZLP1riCG839BdU+ZlFEsJWEbLeg==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "57cd7dd7-3dc3-4d19-b7bd-7911d9cea993", false, "EricD@mymail.com" },
                    { "fd758d91-8cd7-41b6-a5e1-20f4da066059", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "48577a7f-b8d8-45c7-9e4f-a25b50e686cf", new DateTime(2022, 11, 21, 16, 4, 47, 562, DateTimeKind.Local).AddTicks(4641), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAED0aPHyaHfIaBpgLjEPWGLyPRglkt9aJA4cF5PZOnOYgp262C4e5Wi5HszEiY4ke/A==", "8790985467", false, null, "123456789", "39b29a60-42e8-4148-a4fd-3c7abb6769be", false, "AndreaB@mymail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("417a8279-0227-43c4-8504-c4396860ada0"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2846), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("c28330de-a718-465b-9772-5b28ad6395e8"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2851), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("f46090ed-d574-4456-8e18-97150ff885ed"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2899), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2902), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2602), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2597), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2584), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 21, 16, 4, 47, 456, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "912a8751-e6a0-46d6-8546-786e0c4813d7", "6eb8b32f-4e50-4a80-a068-4b028b0ecc88" },
                    { "912a8751-e6a0-46d6-8546-786e0c4813d7", "8619e534-87af-43d2-8348-2e9ebaf3d6fd" },
                    { "912a8751-e6a0-46d6-8546-786e0c4813d7", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "25685cf8-540b-484d-b157-af99716a8efb", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "9e2f4d97-184b-472a-b1fa-d2363d0c3888" },
                    { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "a26abc68-11ee-40e9-81d2-88080259d85f" },
                    { "912a8751-e6a0-46d6-8546-786e0c4813d7", "a3c8907b-d386-4deb-a0af-0c0685c0fae7" },
                    { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "bc87d4d0-5a7d-4f7a-97a1-74838ffef246" },
                    { "912a8751-e6a0-46d6-8546-786e0c4813d7", "d40890f8-e589-4c21-8fcb-a1fa40cdcf9d" },
                    { "d249fd3f-45d8-47bd-9aa3-26932ef2a036", "fd758d91-8cd7-41b6-a5e1-20f4da066059" }
                });
        }
    }
}
