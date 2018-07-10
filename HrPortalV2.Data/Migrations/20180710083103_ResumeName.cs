using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class ResumeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "43bfb7b6-09f6-404d-a735-8f1a374f6790", "f8ce42fa-6799-4065-ad18-dec08e0e81d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6bccfe55-7156-41fc-8e0c-6b25b176942d", "19c132d7-ea08-4303-8fc9-ed5f3a6c376e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a7a08e21-bad6-440c-bf65-880398914d12", "421ca142-7cf0-4f99-b889-35c63ed887ef" });

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: "fdc8ea2c-5114-4fb8-9d9b-af681c30ff4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "19c132d7-ea08-4303-8fc9-ed5f3a6c376e", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "421ca142-7cf0-4f99-b889-35c63ed887ef", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f8ce42fa-6799-4065-ad18-dec08e0e81d6", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "43bfb7b6-09f6-404d-a735-8f1a374f6790", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6bccfe55-7156-41fc-8e0c-6b25b176942d", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a7a08e21-bad6-440c-bf65-880398914d12", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "10ac1d66-c08c-4e07-b96d-4e7d1dd11927");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4ee9f070-6818-41eb-b9a4-61c8c4200a13");

            migrationBuilder.AddColumn<string>(
                name: "ResumeName",
                table: "Resumes",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62dd0e36-6d24-4631-924c-3023ea4cf4c6", "Admin", "Admin", "ADMIN" },
                    { "540836c6-2254-4267-83ef-28169e1c8898", "Company", "Company", "COMPANY" },
                    { "5ba01aa3-5d01-4eda-88c5-7d4e9908307f", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48fc44b8-7911-44be-92e1-920a405899ca", 0, "1", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "43d329c0-945d-4858-8c05-c222e9060e22", 0, "1", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "578e3669-9a0c-4ad9-a0cc-839857077811", 0, "1", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "7dfa0cf6-864c-4e5e-b80f-bc3ad6225fa6", new DateTime(2018, 7, 10, 11, 31, 2, 952, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 7, 10, 11, 31, 2, 952, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 7, 10, 11, 31, 2, 951, DateTimeKind.Local), new DateTime(2018, 7, 10, 11, 31, 2, 952, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "48fc44b8-7911-44be-92e1-920a405899ca", "62dd0e36-6d24-4631-924c-3023ea4cf4c6" },
                    { "43d329c0-945d-4858-8c05-c222e9060e22", "540836c6-2254-4267-83ef-28169e1c8898" },
                    { "578e3669-9a0c-4ad9-a0cc-839857077811", "5ba01aa3-5d01-4eda-88c5-7d4e9908307f" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "59511c0a-c555-4648-a61a-4146e2e4020e", "7dfa0cf6-864c-4e5e-b80f-bc3ad6225fa6", new DateTime(2018, 7, 10, 11, 31, 2, 952, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 7, 10, 11, 31, 2, 952, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "1a79670c-2a17-47ba-b5eb-a01542ee3bb8", "59511c0a-c555-4648-a61a-4146e2e4020e", new DateTime(2018, 7, 10, 11, 31, 2, 953, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 7, 10, 11, 31, 2, 953, DateTimeKind.Local), "admin@bilisimegitim.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "43d329c0-945d-4858-8c05-c222e9060e22", "540836c6-2254-4267-83ef-28169e1c8898" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48fc44b8-7911-44be-92e1-920a405899ca", "62dd0e36-6d24-4631-924c-3023ea4cf4c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "578e3669-9a0c-4ad9-a0cc-839857077811", "5ba01aa3-5d01-4eda-88c5-7d4e9908307f" });

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: "1a79670c-2a17-47ba-b5eb-a01542ee3bb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "540836c6-2254-4267-83ef-28169e1c8898", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5ba01aa3-5d01-4eda-88c5-7d4e9908307f", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "62dd0e36-6d24-4631-924c-3023ea4cf4c6", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "43d329c0-945d-4858-8c05-c222e9060e22", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "48fc44b8-7911-44be-92e1-920a405899ca", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "578e3669-9a0c-4ad9-a0cc-839857077811", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "59511c0a-c555-4648-a61a-4146e2e4020e");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7dfa0cf6-864c-4e5e-b80f-bc3ad6225fa6");

            migrationBuilder.DropColumn(
                name: "ResumeName",
                table: "Resumes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19c132d7-ea08-4303-8fc9-ed5f3a6c376e", "Admin", "Admin", "ADMIN" },
                    { "f8ce42fa-6799-4065-ad18-dec08e0e81d6", "Company", "Company", "COMPANY" },
                    { "421ca142-7cf0-4f99-b889-35c63ed887ef", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6bccfe55-7156-41fc-8e0c-6b25b176942d", 0, "1", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "43bfb7b6-09f6-404d-a735-8f1a374f6790", 0, "1", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "a7a08e21-bad6-440c-bf65-880398914d12", 0, "1", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "4ee9f070-6818-41eb-b9a4-61c8c4200a13", new DateTime(2018, 7, 10, 10, 46, 54, 376, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 7, 10, 10, 46, 54, 376, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 7, 10, 10, 46, 54, 375, DateTimeKind.Local), new DateTime(2018, 7, 10, 10, 46, 54, 376, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "6bccfe55-7156-41fc-8e0c-6b25b176942d", "19c132d7-ea08-4303-8fc9-ed5f3a6c376e" },
                    { "43bfb7b6-09f6-404d-a735-8f1a374f6790", "f8ce42fa-6799-4065-ad18-dec08e0e81d6" },
                    { "a7a08e21-bad6-440c-bf65-880398914d12", "421ca142-7cf0-4f99-b889-35c63ed887ef" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "10ac1d66-c08c-4e07-b96d-4e7d1dd11927", "4ee9f070-6818-41eb-b9a4-61c8c4200a13", new DateTime(2018, 7, 10, 10, 46, 54, 376, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 7, 10, 10, 46, 54, 376, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "fdc8ea2c-5114-4fb8-9d9b-af681c30ff4b", "10ac1d66-c08c-4e07-b96d-4e7d1dd11927", new DateTime(2018, 7, 10, 10, 46, 54, 377, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 7, 10, 10, 46, 54, 377, DateTimeKind.Local), "admin@bilisimegitim.com" });
        }
    }
}
