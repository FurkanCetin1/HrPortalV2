using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HrPortalV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HrPortalV2.Models.ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<HrPortalV2.Models.City> Cities { get; set; }
        public DbSet<HrPortalV2.Models.Company> Companies { get; set; }
        public DbSet<HrPortalV2.Models.Country> Countries { get; set; }
        public DbSet<HrPortalV2.Models.Job> Jobs { get; set; }
        public DbSet<HrPortalV2.Models.JobApplication> JobApplications { get; set; }
        public DbSet<HrPortalV2.Models.Message> Messages { get; set; }
        public DbSet<HrPortalV2.Models.Occupation> Occupations { get; set; }
        public DbSet<HrPortalV2.Models.Resume> Resumes { get; set; }
        public DbSet<HrPortalV2.Models.ResumeFile> ResumeFiles { get; set; }
        public DbSet<HrPortalV2.Models.Sector> Sectors { get; set; }
        public DbSet<HrPortalV2.Models.Subscription> Subscription { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HrPortalV2.Models.Company>().HasOne(c => c.Country).WithMany(co => co.Companies).HasForeignKey(f => f.CountryId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HrPortalV2.Models.Company>().HasOne(c => c.City).WithMany(co => co.Companies).HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HrPortalV2.Models.Company>().HasOne(c => c.County).WithMany(co => co.Companies).HasForeignKey(f => f.CountyId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HrPortalV2.Models.Resume>().HasOne(c => c.Country).WithMany(co => co.Resumes).HasForeignKey(f => f.CountryId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HrPortalV2.Models.Resume>().HasOne(c => c.City).WithMany(co => co.Resumes).HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HrPortalV2.Models.Resume>().HasOne(c => c.County).WithMany(co => co.Resumes).HasForeignKey(f => f.CountyId).OnDelete(DeleteBehavior.Restrict);
            // create roles and users
            var adminRole = new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Admin", ConcurrencyStamp = "Admin", NormalizedName = "ADMIN" };
            var companyRole = new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Company", ConcurrencyStamp = "Company", NormalizedName = "COMPANY" };
            var candidateRole = new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Candidate", ConcurrencyStamp = "Candidate", NormalizedName = "CANDIDATE" };
            var adminUser = new IdentityUser { Id = Guid.NewGuid().ToString(), Email = "admin@bilisimegitim.com", NormalizedEmail = "ADMIN@BILISIMEGITIM.COM", UserName = "admin@bilisimegitim.com", NormalizedUserName = "ADMIN@BILISIMEGITIM.COM", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", ConcurrencyStamp = "1", AccessFailedCount = 0, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true };
            var companyUser = new IdentityUser { Id = Guid.NewGuid().ToString(), Email = "firma@bilisimegitim.com", NormalizedEmail = "FIRMA@BILISIMEGITIM.COM", UserName = "firma@bilisimegitim.com", NormalizedUserName = "FIRMA@BILISIMEGITIM.COM", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", ConcurrencyStamp = "1", AccessFailedCount = 0, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true };
            var candidateUser = new IdentityUser { Id = Guid.NewGuid().ToString(), Email = "aday@bilisimegitim.com", NormalizedEmail = "ADAY@BILISIMEGITIM.COM", UserName = "aday@bilisimegitim.com", NormalizedUserName = "ADAY@BILISIMEGITIM.COM", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEE6Wt5bONqJSCCeRsVu7w9gc+2z1D3f9JIiWbgoNpr8/eYHQK9hEScAP5Yv6Cbj8xg==", SecurityStamp = "JQ5JRGHZGCVI3BZPMNHFG2KOH63RGTDD", ConcurrencyStamp = "1", AccessFailedCount = 0, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true };

            // add roles
            modelBuilder.Entity<IdentityRole>().HasData(adminRole);
            modelBuilder.Entity<IdentityRole>().HasData(companyRole);
            modelBuilder.Entity<IdentityRole>().HasData(candidateRole);

            // add users
            modelBuilder.Entity<IdentityUser>().HasData(adminUser);
            modelBuilder.Entity<IdentityUser>().HasData(companyUser);
            modelBuilder.Entity<IdentityUser>().HasData(candidateUser);

            // add user roles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = adminUser.Id, RoleId = adminRole.Id });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = companyUser.Id, RoleId = companyRole.Id });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = candidateUser.Id, RoleId = candidateRole.Id });

            // add Eğitim sector
            modelBuilder.Entity<HrPortalV2.Models.Sector>().HasData(new HrPortalV2.Models.Sector { Id = "1", Name = "Eğitim", CreateDate=DateTime.Now, CreatedBy=adminUser.UserName, UpdateDate=DateTime.Now, UpdatedBy= adminUser.UserName, IPAddress="127.0.0.1" });

            // create sample country, city and county
            var turkeyCountry = new HrPortalV2.Models.Country { Id = Guid.NewGuid().ToString(), Name = "Türkiye", CreateDate = DateTime.Now, CreatedBy = adminUser.UserName, UpdateDate = DateTime.Now, UpdatedBy = adminUser.UserName, IPAddress = "127.0.0.1" };
            var istanbulCity = new HrPortalV2.Models.City { Id = Guid.NewGuid().ToString(), Name = "İstanbul", CountryId=turkeyCountry.Id, CreateDate = DateTime.Now, CreatedBy = adminUser.UserName, UpdateDate = DateTime.Now, UpdatedBy = adminUser.UserName, IPAddress = "127.0.0.1" };
            var kadikoyCounty = new HrPortalV2.Models.County { Id = Guid.NewGuid().ToString(), Name = "Kadıköy", CityId = istanbulCity.Id, CreateDate = DateTime.Now, CreatedBy = adminUser.UserName, UpdateDate = DateTime.Now, UpdatedBy = adminUser.UserName, IPAddress = "127.0.0.1" };

            // add sample country, city and county
            modelBuilder.Entity<HrPortalV2.Models.Country>().HasData(turkeyCountry);
            modelBuilder.Entity<HrPortalV2.Models.City>().HasData(istanbulCity);
            modelBuilder.Entity<HrPortalV2.Models.County>().HasData(kadikoyCounty);

            var yazilimOccupucation = new HrPortalV2.Models.Occupation { Id = Guid.NewGuid().ToString(), Name = "Yazılım Uzmanı", CreateDate = DateTime.Now, CreatedBy = adminUser.UserName, UpdateDate = DateTime.Now, UpdatedBy = adminUser.UserName, IPAddress = "127.0.0.1" };

            modelBuilder.Entity<HrPortalV2.Models.Occupation>().HasData(yazilimOccupucation);
        }
    }
}
