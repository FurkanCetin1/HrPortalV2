﻿// <auto-generated />
using System;
using HrPortalV2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HrPortalV2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180711074514_Dribbble")]
    partial class Dribbble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrPortalV2.Models.City", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = "3c5c1e90-0a3a-4a10-8506-e08ad06ca0a8", CountryId = "db83e828-bdf1-4c1f-9e3b-8335613c3616", CreateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "İstanbul", UpdateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.Company", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CityId");

                    b.Property<string>("ContactName");

                    b.Property<string>("CountryId");

                    b.Property<string>("CountyId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("IPAddress");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("Logo");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("SectorId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CountyId");

                    b.HasIndex("SectorId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HrPortalV2.Models.Country", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = "db83e828-bdf1-4c1f-9e3b-8335613c3616", CreateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Türkiye", UpdateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.County", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("County");

                    b.HasData(
                        new { Id = "56c216e6-be50-4703-907b-4b0155c0772c", CityId = "3c5c1e90-0a3a-4a10-8506-e08ad06ca0a8", CreateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Kadıköy", UpdateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.Job", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("IPAddress");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsFeatured");

                    b.Property<int>("Position");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("HrPortalV2.Models.JobApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("IPAddress");

                    b.Property<string>("JobId");

                    b.Property<string>("ResumeId");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("ResumeId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("HrPortalV2.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("From");

                    b.Property<string>("FromName");

                    b.Property<string>("IPAddress");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsRead");

                    b.Property<string>("Title");

                    b.Property<string>("To");

                    b.Property<string>("ToName");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HrPortalV2.Models.Occupation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Occupations");

                    b.HasData(
                        new { Id = "a7f21c37-7b11-401e-aac1-1a8ddbaaf5dc", CreateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Yazılım Uzmanı", UpdateDate = new DateTime(2018, 7, 11, 10, 45, 14, 34, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("HrPortalV2.Models.Resume", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressId");

                    b.Property<string>("Behance");

                    b.Property<string>("Blog");

                    b.Property<string>("CityId");

                    b.Property<string>("CountryId");

                    b.Property<string>("CountyId");

                    b.Property<string>("Courses");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Dribbble");

                    b.Property<string>("DrivingLicense");

                    b.Property<string>("Email");

                    b.Property<string>("Facebook");

                    b.Property<string>("FirstName");

                    b.Property<string>("ForeignLanguages");

                    b.Property<int>("Gender");

                    b.Property<string>("GitHub");

                    b.Property<int>("GraduationYear");

                    b.Property<string>("Hobbies");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Instagram");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsCurrentlyWorking");

                    b.Property<bool>("IsDisabled");

                    b.Property<bool>("IsSeekingJob");

                    b.Property<bool>("IsSubsidized");

                    b.Property<bool>("IsTravelDisabled");

                    b.Property<string>("LastCompany");

                    b.Property<string>("LastDepartment");

                    b.Property<string>("LastEducation");

                    b.Property<string>("LastName");

                    b.Property<string>("LastPosition");

                    b.Property<string>("LinkedIn");

                    b.Property<int>("MaritalStatus");

                    b.Property<int?>("MilitaryStatus");

                    b.Property<string>("MobilePhone");

                    b.Property<string>("Objective");

                    b.Property<string>("OccupationId");

                    b.Property<string>("Photo");

                    b.Property<string>("Projects");

                    b.Property<string>("ResumeName");

                    b.Property<string>("Skills");

                    b.Property<int>("TotalExperience");

                    b.Property<string>("Twitter");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<bool>("UsingCigarette");

                    b.Property<string>("Youtube");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CountyId");

                    b.HasIndex("OccupationId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("HrPortalV2.Models.ResumeFile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("File");

                    b.Property<string>("IPAddress");

                    b.Property<string>("ResumeId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("ResumeFiles");
                });

            modelBuilder.Entity("HrPortalV2.Models.Sector", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Sectors");

                    b.HasData(
                        new { Id = "1", CreateDate = new DateTime(2018, 7, 11, 10, 45, 14, 33, DateTimeKind.Local), CreatedBy = "admin@bilisimegitim.com", IPAddress = "127.0.0.1", Name = "Eğitim", UpdateDate = new DateTime(2018, 7, 11, 10, 45, 14, 33, DateTimeKind.Local), UpdatedBy = "admin@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "c1de0f41-412e-492f-925b-dacdf4b8cfb9", ConcurrencyStamp = "Admin", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = "c30bbc28-5bfe-406f-889b-46bca142a32e", ConcurrencyStamp = "Company", Name = "Company", NormalizedName = "COMPANY" },
                        new { Id = "2e851172-5863-442f-a448-b1f0d4662183", ConcurrencyStamp = "Candidate", Name = "Candidate", NormalizedName = "CANDIDATE" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "d339904a-7d1d-492c-8916-224d86303b95", AccessFailedCount = 0, ConcurrencyStamp = "1", Email = "admin@bilisimegitim.com", EmailConfirmed = true, LockoutEnabled = true, NormalizedEmail = "ADMIN@BILISIMEGITIM.COM", NormalizedUserName = "ADMIN@BILISIMEGITIM.COM", PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", PhoneNumberConfirmed = false, SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", TwoFactorEnabled = false, UserName = "admin@bilisimegitim.com" },
                        new { Id = "f4f404f9-2664-4cb3-965a-f281c79e2527", AccessFailedCount = 0, ConcurrencyStamp = "1", Email = "firma@bilisimegitim.com", EmailConfirmed = true, LockoutEnabled = true, NormalizedEmail = "FIRMA@BILISIMEGITIM.COM", NormalizedUserName = "FIRMA@BILISIMEGITIM.COM", PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", PhoneNumberConfirmed = false, SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", TwoFactorEnabled = false, UserName = "firma@bilisimegitim.com" },
                        new { Id = "c42b8a5b-84e9-436a-8f1a-6eb44e567aba", AccessFailedCount = 0, ConcurrencyStamp = "1", Email = "aday@bilisimegitim.com", EmailConfirmed = true, LockoutEnabled = true, NormalizedEmail = "ADAY@BILISIMEGITIM.COM", NormalizedUserName = "ADAY@BILISIMEGITIM.COM", PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", PhoneNumberConfirmed = false, SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", TwoFactorEnabled = false, UserName = "aday@bilisimegitim.com" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "d339904a-7d1d-492c-8916-224d86303b95", RoleId = "c1de0f41-412e-492f-925b-dacdf4b8cfb9" },
                        new { UserId = "f4f404f9-2664-4cb3-965a-f281c79e2527", RoleId = "c30bbc28-5bfe-406f-889b-46bca142a32e" },
                        new { UserId = "c42b8a5b-84e9-436a-8f1a-6eb44e567aba", RoleId = "2e851172-5863-442f-a448-b1f0d4662183" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HrPortalV2.Models.City", b =>
                {
                    b.HasOne("HrPortalV2.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("HrPortalV2.Models.Company", b =>
                {
                    b.HasOne("HrPortalV2.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("HrPortalV2.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("HrPortalV2.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId");

                    b.HasOne("HrPortalV2.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId");
                });

            modelBuilder.Entity("HrPortalV2.Models.County", b =>
                {
                    b.HasOne("HrPortalV2.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("HrPortalV2.Models.Job", b =>
                {
                    b.HasOne("HrPortalV2.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("HrPortalV2.Models.JobApplication", b =>
                {
                    b.HasOne("HrPortalV2.Models.Job", "Job")
                        .WithMany("JobApplications")
                        .HasForeignKey("JobId");

                    b.HasOne("HrPortalV2.Models.Resume", "Resume")
                        .WithMany("JobApplications")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HrPortalV2.Models.Resume", b =>
                {
                    b.HasOne("HrPortalV2.Models.City", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("HrPortalV2.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("HrPortalV2.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("HrPortalV2.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId");

                    b.HasOne("HrPortalV2.Models.Occupation", "Occupation")
                        .WithMany()
                        .HasForeignKey("OccupationId");
                });

            modelBuilder.Entity("HrPortalV2.Models.ResumeFile", b =>
                {
                    b.HasOne("HrPortalV2.Models.Resume", "Resume")
                        .WithMany("ResumeFiles")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}