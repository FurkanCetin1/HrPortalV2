using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_County_CountyId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_County_Cities_CityId",
                table: "County");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_County_CountyId",
                table: "Resumes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_County",
                table: "County");

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

            migrationBuilder.RenameTable(
                name: "County",
                newName: "Counties");

            migrationBuilder.RenameIndex(
                name: "IX_County_CityId",
                table: "Counties",
                newName: "IX_Counties_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Counties",
                table: "Counties",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e267130a-07af-4dce-8faa-35c8ef940d08", "Admin", "Admin", "ADMIN" },
                    { "9adae30d-2675-4c34-825e-209a56de3693", "Company", "Company", "COMPANY" },
                    { "1fbfa9f5-c7e7-47dc-8f8f-c3ce32c95b0a", "Candidate", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13e2e21e-4d77-4a96-9d05-46310c13f41c", 0, "1", "IdentityUser", "admin@bilisimegitim.com", true, true, null, "ADMIN@BILISIMEGITIM.COM", "ADMIN@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "admin@bilisimegitim.com" },
                    { "b0fb090d-941d-4eb4-99dc-04a33c324e1a", 0, "1", "IdentityUser", "firma@bilisimegitim.com", true, true, null, "FIRMA@BILISIMEGITIM.COM", "FIRMA@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "firma@bilisimegitim.com" },
                    { "f36ba8e6-bccb-403a-9317-5f1e87710890", 0, "1", "IdentityUser", "aday@bilisimegitim.com", true, true, null, "ADAY@BILISIMEGITIM.COM", "ADAY@BILISIMEGITIM.COM", "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", null, false, "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", false, "aday@bilisimegitim.com" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "a6369df0-db5d-4968-a217-dba1e21cc3fd", new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Türkiye", new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "05c5ff6c-1076-4bbd-9abb-decc6aca14c2", new DateTime(2018, 8, 8, 14, 18, 49, 97, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Yazılım Uzmanı", new DateTime(2018, 8, 8, 14, 18, 49, 97, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 8, 14, 18, 49, 95, DateTimeKind.Local), new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "13e2e21e-4d77-4a96-9d05-46310c13f41c", "e267130a-07af-4dce-8faa-35c8ef940d08" },
                    { "b0fb090d-941d-4eb4-99dc-04a33c324e1a", "9adae30d-2675-4c34-825e-209a56de3693" },
                    { "f36ba8e6-bccb-403a-9317-5f1e87710890", "1fbfa9f5-c7e7-47dc-8f8f-c3ce32c95b0a" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "eeefe588-9989-42ed-ac76-eae097e46351", "a6369df0-db5d-4968-a217-dba1e21cc3fd", new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "İstanbul", new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "CityId", "CreateDate", "CreatedBy", "IPAddress", "Name", "UpdateDate", "UpdatedBy" },
                values: new object[] { "ee410819-b7f1-456d-9f00-1a735518b4be", "eeefe588-9989-42ed-ac76-eae097e46351", new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local), "admin@bilisimegitim.com", "127.0.0.1", "Kadıköy", new DateTime(2018, 8, 8, 14, 18, 49, 96, DateTimeKind.Local), "admin@bilisimegitim.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Counties_CountyId",
                table: "Companies",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Counties_Cities_CityId",
                table: "Counties",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Counties_CountyId",
                table: "Resumes",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Counties_CountyId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Counties_Cities_CityId",
                table: "Counties");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Counties_CountyId",
                table: "Resumes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Counties",
                table: "Counties");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "13e2e21e-4d77-4a96-9d05-46310c13f41c", "e267130a-07af-4dce-8faa-35c8ef940d08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b0fb090d-941d-4eb4-99dc-04a33c324e1a", "9adae30d-2675-4c34-825e-209a56de3693" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f36ba8e6-bccb-403a-9317-5f1e87710890", "1fbfa9f5-c7e7-47dc-8f8f-c3ce32c95b0a" });

            migrationBuilder.DeleteData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: "ee410819-b7f1-456d-9f00-1a735518b4be");

            migrationBuilder.DeleteData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: "05c5ff6c-1076-4bbd-9abb-decc6aca14c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1fbfa9f5-c7e7-47dc-8f8f-c3ce32c95b0a", "Candidate" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9adae30d-2675-4c34-825e-209a56de3693", "Company" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e267130a-07af-4dce-8faa-35c8ef940d08", "Admin" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "13e2e21e-4d77-4a96-9d05-46310c13f41c", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b0fb090d-941d-4eb4-99dc-04a33c324e1a", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f36ba8e6-bccb-403a-9317-5f1e87710890", "1" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "eeefe588-9989-42ed-ac76-eae097e46351");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "a6369df0-db5d-4968-a217-dba1e21cc3fd");

            migrationBuilder.RenameTable(
                name: "Counties",
                newName: "County");

            migrationBuilder.RenameIndex(
                name: "IX_Counties_CityId",
                table: "County",
                newName: "IX_County_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_County",
                table: "County",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_County_CountyId",
                table: "Companies",
                column: "CountyId",
                principalTable: "County",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_County_Cities_CityId",
                table: "County",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_County_CountyId",
                table: "Resumes",
                column: "CountyId",
                principalTable: "County",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
