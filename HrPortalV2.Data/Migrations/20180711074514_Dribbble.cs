using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class Dribbble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Dribble",
                table: "Resumes",
                newName: "Dribbble");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c1de0f41-412e-492f-925b-dacdf4b8cfb9", "Admin", "Admin", "ADMIN" },
                    { "c30bbc28-5bfe-406f-889b-46bca142a32e", "Company", "Company", "COMPANY" },
                    { "2e851172-5863-442f-a448-b1f0d4662183", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d339904a-7d1d-492c-8916-224d86303b95", 0, "1", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "f4f404f9-2664-4cb3-965a-f281c79e2527", 0, "1", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "c42b8a5b-84e9-436a-8f1a-6eb44e567aba", 0, "1", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "db83e828-bdf1-4c1f-9e3b-8335613c3616", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "a7f21c37-7b11-401e-aac1-1a8ddbaaf5dc", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Yazılım Uzmanı", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 7, 11, 10, 45, 14, 33, DateTimeKind.Local), new DateTime(2018, 7, 11, 10, 45, 14, 33, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "d339904a-7d1d-492c-8916-224d86303b95", "c1de0f41-412e-492f-925b-dacdf4b8cfb9" },
                    { "f4f404f9-2664-4cb3-965a-f281c79e2527", "c30bbc28-5bfe-406f-889b-46bca142a32e" },
                    { "c42b8a5b-84e9-436a-8f1a-6eb44e567aba", "2e851172-5863-442f-a448-b1f0d4662183" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "3c5c1e90-0a3a-4a10-8506-e08ad06ca0a8", "db83e828-bdf1-4c1f-9e3b-8335613c3616", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "56c216e6-be50-4703-907b-4b0155c0772c", "3c5c1e90-0a3a-4a10-8506-e08ad06ca0a8", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), "admin@bilisimegitim.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c42b8a5b-84e9-436a-8f1a-6eb44e567aba", "2e851172-5863-442f-a448-b1f0d4662183" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d339904a-7d1d-492c-8916-224d86303b95", "c1de0f41-412e-492f-925b-dacdf4b8cfb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f4f404f9-2664-4cb3-965a-f281c79e2527", "c30bbc28-5bfe-406f-889b-46bca142a32e" });

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: "56c216e6-be50-4703-907b-4b0155c0772c");

            migrationBuilder.DeleteData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: "a7f21c37-7b11-401e-aac1-1a8ddbaaf5dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2e851172-5863-442f-a448-b1f0d4662183", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c1de0f41-412e-492f-925b-dacdf4b8cfb9", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c30bbc28-5bfe-406f-889b-46bca142a32e", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c42b8a5b-84e9-436a-8f1a-6eb44e567aba", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d339904a-7d1d-492c-8916-224d86303b95", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f4f404f9-2664-4cb3-965a-f281c79e2527", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3c5c1e90-0a3a-4a10-8506-e08ad06ca0a8");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "db83e828-bdf1-4c1f-9e3b-8335613c3616");

            migrationBuilder.RenameColumn(
                name: "Dribbble",
                table: "Resumes",
                newName: "Dribble");

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
    }
}
