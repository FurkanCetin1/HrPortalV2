using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
