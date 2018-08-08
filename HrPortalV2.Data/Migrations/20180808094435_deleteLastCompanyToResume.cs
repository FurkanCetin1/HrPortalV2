using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class deleteLastCompanyToResume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "421c368a-73e5-4794-8855-2fb23eb1ebb2", "79528a2a-f286-416c-80b2-5e46ba2ee43e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "50e0f211-54d4-4901-b02d-007c5aa0b17e", "c7d8a353-2f9e-4568-998a-326ecb882ec7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bae7d4e6-bb56-4b38-914d-eb03b73a0d74", "3fabd825-5783-4299-a790-88eeb345889f" });

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: "39a51c6b-cdc3-4a43-b246-00355c78f1c3");

            migrationBuilder.DeleteData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: "2648a60f-c97d-444e-9201-337cff8b42c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3fabd825-5783-4299-a790-88eeb345889f", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "79528a2a-f286-416c-80b2-5e46ba2ee43e", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c7d8a353-2f9e-4568-998a-326ecb882ec7", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "421c368a-73e5-4794-8855-2fb23eb1ebb2", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "50e0f211-54d4-4901-b02d-007c5aa0b17e", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bae7d4e6-bb56-4b38-914d-eb03b73a0d74", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "27595331-3265-4708-87d2-df8031c4edf4");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "c488608e-30b0-413c-bf5f-a59cc15bddb4");

            migrationBuilder.DropColumn(
                name: "LastCompany",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "LastPosition",
                table: "Resumes");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "LastCompany",
                table: "Resumes",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastPosition",
                table: "Resumes",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7d8a353-2f9e-4568-998a-326ecb882ec7", "Admin", "Admin", "ADMIN" },
                    { "3fabd825-5783-4299-a790-88eeb345889f", "Company", "Company", "COMPANY" },
                    { "79528a2a-f286-416c-80b2-5e46ba2ee43e", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50e0f211-54d4-4901-b02d-007c5aa0b17e", 0, "1", "IdentityUser", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "bae7d4e6-bb56-4b38-914d-eb03b73a0d74", 0, "1", "IdentityUser", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "421c368a-73e5-4794-8855-2fb23eb1ebb2", 0, "1", "IdentityUser", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "c488608e-30b0-413c-bf5f-a59cc15bddb4", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "2648a60f-c97d-444e-9201-337cff8b42c4", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Yazılım Uzmanı", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 7, 15, 29, 13, 505, DateTimeKind.Local), new DateTime(2018, 8, 7, 15, 29, 13, 505, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "50e0f211-54d4-4901-b02d-007c5aa0b17e", "c7d8a353-2f9e-4568-998a-326ecb882ec7" },
                    { "bae7d4e6-bb56-4b38-914d-eb03b73a0d74", "3fabd825-5783-4299-a790-88eeb345889f" },
                    { "421c368a-73e5-4794-8855-2fb23eb1ebb2", "79528a2a-f286-416c-80b2-5e46ba2ee43e" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "27595331-3265-4708-87d2-df8031c4edf4", "c488608e-30b0-413c-bf5f-a59cc15bddb4", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "39a51c6b-cdc3-4a43-b246-00355c78f1c3", "27595331-3265-4708-87d2-df8031c4edf4", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 8, 7, 15, 29, 13, 506, DateTimeKind.Local), "admin@bilisimegitim.com" });
        }
    }
}
