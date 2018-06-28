using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class JobApplication:BaseEntity
    {
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        public Resume Resume { get; set; }
        public string JobId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
