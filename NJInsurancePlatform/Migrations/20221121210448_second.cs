using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NJInsurancePlatform.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d82696b-3c27-4c82-bf15-6386226ccc01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ca4d4ce-772f-4e88-809e-383f542aab82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "633f41bc-d373-40a1-8ae1-93769887e917");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "806c0ed5-0aae-4324-8b89-11951ee26ce1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a64e623f-ed75-4a01-8dc6-cffbff65944b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bae29f56-7ee1-46d2-bc48-82d1fa444626");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c896277f-2fac-42a4-91da-47d27f4416a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8e071a2-ccee-489e-a8f6-ce76abb2ca72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "GroupRooms");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "ec96d811-e555-460a-9b01-1535a25b4980", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8147ef3c-5858-4aa6-9f81-56cfad51a831", "Customer", "CUSTOMER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "07a60ca9-b3c5-4991-b888-93f0bde1138a", "Beneficiary", "BENEFICIARY" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e2bfc0b-3d8d-4574-a666-cc06d3e81d85", "AQAAAAEAACcQAAAAENR/ZJWMsItq1vW9ToqGBi41fLEIQOsPWW57pP6Uk9NYkat57RyB/Z7Tnjhd6CPCkw==", "fd7e99f1-5aa0-4d45-9f93-7907de7737e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae268fc6-e8f6-4a44-9f2d-74e8504bb9a4", "AQAAAAEAACcQAAAAEPIF5J3wf20AhGquY5a7W6xpxFlDq+hcjrsLfbItploq6sv0RhS2RReDZ+K8zdfqfg==", "47044c32-4acc-4a20-8d5f-a3132e670d50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca38f298-3d10-40ee-85f1-b9fa663e1a36", "AQAAAAEAACcQAAAAEPYoWqga6xseIqTTiuGmTQ3g85xBgjlRLTtyYkhNoL9ZCmnFKfM/Om0cO4tGVwxcoQ==", "ff3b6029-d046-4fe0-8b27-28a2f0578ba5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d82696b-3c27-4c82-bf15-6386226ccc01", 0, true, null, "c13e1c09-ffab-4504-9c64-73e57ed58fe0", new DateTime(2022, 11, 18, 6, 1, 57, 477, DateTimeKind.Local).AddTicks(7561), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEBItpk6b1U0STeYclMid873/COZKDWLnEVjfM9Lepwapo79j3mF0bLkqO2/YEBo8RA==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "78bdb81b-473c-42d3-abfd-5b1a60ef5d4f", false, "EricD@mymail.com" },
                    { "4ca4d4ce-772f-4e88-809e-383f542aab82", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "a8d7227a-945a-4f91-86a4-58c5475477ad", new DateTime(2022, 11, 18, 6, 1, 57, 518, DateTimeKind.Local).AddTicks(4513), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEHFcocgjXhb2JeR3LdeCcDHaDeX5F/hJ5olulL8gHnCrjfPuh57JrKcFvWey2vp0FQ==", "8790985467", false, null, "123456789", "fa68c5cd-bf21-4f12-b06f-42763b852e62", false, "BritneyG@mymail.com" },
                    { "633f41bc-d373-40a1-8ae1-93769887e917", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "e0592385-b500-4032-a980-ca5896cad804", new DateTime(2022, 11, 18, 6, 1, 57, 502, DateTimeKind.Local).AddTicks(4941), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEA7b3KMmO83Uxi/t7BW60FV67AlA2lApskuUEAFt9wyjOrcdA3VJYDFW2tl2WSxZhQ==", "8790985467", false, null, "123456789", "c28ba99f-626b-4ad1-a38c-f41f28588d7f", false, "AndreaB@mymail.com" },
                    { "806c0ed5-0aae-4324-8b89-11951ee26ce1", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "eb78bcea-c86f-456f-afe4-6ea3efeb1514", new DateTime(2022, 11, 18, 6, 1, 57, 526, DateTimeKind.Local).AddTicks(1942), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAECWQK9u3aBP5QD9Th1bfU6DaOOLNUopJKyu7BT97xAYVzoxVd5UMecepXPUNe6nvtg==", "8790985467", false, null, "123456789", "41eec1c5-974f-43a6-9462-31ca7dcfaa73", false, "JoanaM@mymail.com" },
                    { "a64e623f-ed75-4a01-8dc6-cffbff65944b", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "276ab47b-a236-477f-8c7d-f568a8b08c88", new DateTime(2022, 11, 18, 6, 1, 57, 510, DateTimeKind.Local).AddTicks(3193), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEITZq8/41qSSeDStPmNahQprGSd9+mQk0+Rarj5dgYRAZNICStojcYaZTyXSlsT42A==", "8790985467", false, null, "123456789", "0516131b-5f6f-4e87-8126-52517895743b", false, "CynthiaS@mymail.com" },
                    { "bae29f56-7ee1-46d2-bc48-82d1fa444626", 0, true, null, "d4b90fa4-6e53-47ae-ae7a-5f62bd7db910", new DateTime(2022, 11, 18, 6, 1, 57, 486, DateTimeKind.Local).AddTicks(4543), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAEEPHC6xbzaJhwhBMeWBAgJGtKWzCHO7dI2Jeeu22DiJDl1WsQItG0BmYo/q+8AhhiA==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "921fe809-4b88-4913-ad3d-6d0ca7279768", false, "NikosiT@mymail.com" },
                    { "c896277f-2fac-42a4-91da-47d27f4416a8", 0, true, null, "b776921a-f872-47e9-be38-3fbf9a53ce6c", new DateTime(2022, 11, 18, 6, 1, 57, 494, DateTimeKind.Local).AddTicks(3391), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAECUZRCOH9wORl/npZAypjUEwHOdQzK38Ly2tSLJ08iCOlT8CcavYZEbA/Sv7uzSFoQ==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "56e07966-6850-46aa-a5f5-df7bed6cc1bc", false, "LeonaW@mymail.com" },
                    { "d8e071a2-ccee-489e-a8f6-ce76abb2ca72", 0, true, null, "05e89e50-85d8-4f8f-8b20-54644f7cf9a1", new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3984), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEGnCcL+zkzckzRUNB4g5BRENUx+F4wgra8CSkjFWwIUMXfl5yEKthmut+GKX6c/bmw==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "05ff91df-0779-412c-8704-da74df53460f", false, "Pato" }
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("417a8279-0227-43c4-8504-c4396860ada0"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3848), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3857), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("c28330de-a718-465b-9772-5b28ad6395e8"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3853), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillMUID",
                keyValue: new Guid("f46090ed-d574-4456-8e18-97150ff885ed"),
                columns: new[] { "CreatedDate", "PolicyDueDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3843), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3902), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3904), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3887), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3895), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3897), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentMUID",
                keyValue: new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"),
                columns: new[] { "CardExpireDate", "CreatedDate", "PaidDate" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3879), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3882), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3784), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3779), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Policies",
                keyColumn: "PolicyMUID",
                keyValue: new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"),
                columns: new[] { "PolicyEnd_Date", "PolicyStart_Date" },
                values: new object[] { new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionMUID",
                keyValue: new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"),
                column: "PaymentDate",
                value: new DateTime(2022, 11, 18, 6, 1, 57, 468, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }
    }
}
