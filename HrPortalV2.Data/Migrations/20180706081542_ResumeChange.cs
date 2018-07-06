using Microsoft.EntityFrameworkCore.Migrations;

namespace HrPortalV2.Data.Migrations
{
    public partial class ResumeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressId",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Behance",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Blog",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityId",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryId",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountyId",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dribble",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicense",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "Resumes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSubsidized",
                table: "Resumes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTravelDisabled",
                table: "Resumes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Objective",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Projects",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Resumes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UsingCigarette",
                table: "Resumes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Youtube",
                table: "Resumes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_AddressId",
                table: "Resumes",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CityId",
                table: "Resumes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CountryId",
                table: "Resumes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CountyId",
                table: "Resumes",
                column: "CountyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Cities_AddressId",
                table: "Resumes",
                column: "AddressId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Countries_CountryId",
                table: "Resumes",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_County_CountyId",
                table: "Resumes",
                column: "CountyId",
                principalTable: "County",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Cities_AddressId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Countries_CountryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_County_CountyId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_AddressId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_CityId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_CountryId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_CountyId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Behance",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Blog",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CountyId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Dribble",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "DrivingLicense",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "IsSubsidized",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "IsTravelDisabled",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Objective",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Projects",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "UsingCigarette",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Youtube",
                table: "Resumes");
        }
    }
}
