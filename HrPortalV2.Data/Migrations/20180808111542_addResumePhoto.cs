using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class addResumePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "10fa501a-dda8-463c-9166-409cbe68493c", "f83a1b42-b8fa-4036-9947-c2b70683d20e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cddd01bc-06ba-4f5f-a770-60e807cf9fc5", "54ccfe77-fea9-4673-b1d3-71d81975d837" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fd80b2a0-8db1-4cec-94e6-27cb239d2de1", "1e85fb7c-0b43-48d8-835b-fae3a9cbe91e" });

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: "f18ae5e6-9c76-4b5d-abfa-5f2b6f1af57c");

            migrationBuilder.DeleteData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: "4684c875-df5d-4f6a-90c1-4a4451a7e7b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1e85fb7c-0b43-48d8-835b-fae3a9cbe91e", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "54ccfe77-fea9-4673-b1d3-71d81975d837", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f83a1b42-b8fa-4036-9947-c2b70683d20e", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "10fa501a-dda8-463c-9166-409cbe68493c", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cddd01bc-06ba-4f5f-a770-60e807cf9fc5", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fd80b2a0-8db1-4cec-94e6-27cb239d2de1", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "63945ec4-d8c1-477f-9722-f1c269d5b720");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "44fa95c9-c817-4fd1-a7ee-91dec619db94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1234997a-3e23-4495-9c13-511266f44b18", "Admin", "Admin", "ADMIN" },
                    { "8989785b-5696-48a9-bf2a-3947faf54973", "Company", "Company", "COMPANY" },
                    { "5ce4aa19-7013-4d3f-930b-072f6803e329", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b2ce2f47-5394-4922-8ad8-9564a38e1d80", 0, "1", "IdentityUser", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "c63a5654-1d99-409f-a05f-19b3d9caa33b", 0, "1", "IdentityUser", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "95ac0dd6-77a1-45c4-98be-950c0e3ffe45", 0, "1", "IdentityUser", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "67a5ef08-be4a-4766-b25e-8c4bbc53783d", new DateTime(2018, 8, 8, 14, 15, 42, 242, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 8, 8, 14, 15, 42, 242, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "65218abd-beaf-4144-85d1-24d4f806c201", new DateTime(2018, 8, 8, 14, 15, 42, 243, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Yazılım Uzmanı", new DateTime(2018, 8, 8, 14, 15, 42, 243, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 8, 14, 15, 42, 239, DateTimeKind.Local), new DateTime(2018, 8, 8, 14, 15, 42, 241, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b2ce2f47-5394-4922-8ad8-9564a38e1d80", "1234997a-3e23-4495-9c13-511266f44b18" },
                    { "c63a5654-1d99-409f-a05f-19b3d9caa33b", "8989785b-5696-48a9-bf2a-3947faf54973" },
                    { "95ac0dd6-77a1-45c4-98be-950c0e3ffe45", "5ce4aa19-7013-4d3f-930b-072f6803e329" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "d6318f4e-56d0-4004-bfd5-b4db31262a83", "67a5ef08-be4a-4766-b25e-8c4bbc53783d", new DateTime(2018, 8, 8, 14, 15, 42, 243, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 8, 8, 14, 15, 42, 243, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "90a856c8-e898-4dcb-b291-bcb66f697ea6", "d6318f4e-56d0-4004-bfd5-b4db31262a83", new DateTime(2018, 8, 8, 14, 15, 42, 243, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 8, 8, 14, 15, 42, 243, DateTimeKind.Local), "admin@bilisimegitim.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95ac0dd6-77a1-45c4-98be-950c0e3ffe45", "5ce4aa19-7013-4d3f-930b-072f6803e329" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b2ce2f47-5394-4922-8ad8-9564a38e1d80", "1234997a-3e23-4495-9c13-511266f44b18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c63a5654-1d99-409f-a05f-19b3d9caa33b", "8989785b-5696-48a9-bf2a-3947faf54973" });

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: "90a856c8-e898-4dcb-b291-bcb66f697ea6");

            migrationBuilder.DeleteData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: "65218abd-beaf-4144-85d1-24d4f806c201");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1234997a-3e23-4495-9c13-511266f44b18", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5ce4aa19-7013-4d3f-930b-072f6803e329", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8989785b-5696-48a9-bf2a-3947faf54973", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "95ac0dd6-77a1-45c4-98be-950c0e3ffe45", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b2ce2f47-5394-4922-8ad8-9564a38e1d80", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c63a5654-1d99-409f-a05f-19b3d9caa33b", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "d6318f4e-56d0-4004-bfd5-b4db31262a83");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "67a5ef08-be4a-4766-b25e-8c4bbc53783d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e85fb7c-0b43-48d8-835b-fae3a9cbe91e", "Admin", "Admin", "ADMIN" },
                    { "f83a1b42-b8fa-4036-9947-c2b70683d20e", "Company", "Company", "COMPANY" },
                    { "54ccfe77-fea9-4673-b1d3-71d81975d837", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fd80b2a0-8db1-4cec-94e6-27cb239d2de1", 0, "1", "IdentityUser", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "10fa501a-dda8-463c-9166-409cbe68493c", 0, "1", "IdentityUser", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "cddd01bc-06ba-4f5f-a770-60e807cf9fc5", 0, "1", "IdentityUser", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "44fa95c9-c817-4fd1-a7ee-91dec619db94", new DateTime(2018, 8, 8, 12, 44, 34, 414, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 8, 8, 12, 44, 34, 414, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "4684c875-df5d-4f6a-90c1-4a4451a7e7b8", new DateTime(2018, 8, 8, 12, 44, 34, 415, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Yazılım Uzmanı", new DateTime(2018, 8, 8, 12, 44, 34, 415, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 8, 12, 44, 34, 412, DateTimeKind.Local), new DateTime(2018, 8, 8, 12, 44, 34, 413, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "fd80b2a0-8db1-4cec-94e6-27cb239d2de1", "1e85fb7c-0b43-48d8-835b-fae3a9cbe91e" },
                    { "10fa501a-dda8-463c-9166-409cbe68493c", "f83a1b42-b8fa-4036-9947-c2b70683d20e" },
                    { "cddd01bc-06ba-4f5f-a770-60e807cf9fc5", "54ccfe77-fea9-4673-b1d3-71d81975d837" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "63945ec4-d8c1-477f-9722-f1c269d5b720", "44fa95c9-c817-4fd1-a7ee-91dec619db94", new DateTime(2018, 8, 8, 12, 44, 34, 414, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 8, 8, 12, 44, 34, 414, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "f18ae5e6-9c76-4b5d-abfa-5f2b6f1af57c", "63945ec4-d8c1-477f-9722-f1c269d5b720", new DateTime(2018, 8, 8, 12, 44, 34, 414, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 8, 8, 12, 44, 34, 414, DateTimeKind.Local), "admin@bilisimegitim.com" });
        }
    }
}
