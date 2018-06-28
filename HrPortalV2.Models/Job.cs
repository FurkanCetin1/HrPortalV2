using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Job:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
    }
}
