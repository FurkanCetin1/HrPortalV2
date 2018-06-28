using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Resume:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string MobilePhone { get; set; } //
        public string Email { get; set; } //
        public int TotalExperience { get; set; }
        public bool IsCurrentlyWorking { get; set; }
        public bool IsSeekingJob { get; set; }
        public string LastCompany { get; set; }
        public string LastPosition { get; set; }
        public MilitaryStatus? MilitaryStatus { get; set; }
        public string LastEducation { get; set; }
        public string LastDepartment { get; set; }
        public int GraduationYear { get; set; }
        public string ForeignLanguages { get; set; }
        public virtual ICollection<ResumeFile> ResumeFiles { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
        public string OccupationId { get; set; }
        [ForeignKey("OccupationId")]
        public Occupation Occupation { get; set; }
    }
}
