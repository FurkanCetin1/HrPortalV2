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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // veritabanına varsayılan üye rollerini ekliyoruz
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Admin", ConcurrencyStamp = "Admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Company", ConcurrencyStamp = "Company", NormalizedName = "COMPANY" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Candidate", ConcurrencyStamp = "Candidate", NormalizedName = "CANDIDATE" });
            modelBuilder.Entity<HrPortalV2.Models.Sector>().HasData(new HrPortalV2.Models.Sector { Id = "1", Name = "Eğitim", CreateDate=DateTime.Now, CreatedBy="username", UpdateDate=DateTime.Now, UpdatedBy="username", IPAddress="127.0.0.1" });

        }
    }
}
