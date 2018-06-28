using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class ResumeFile:BaseEntity
    {
        public string File { get; set; }
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        public Resume Resume { get; set; }
    }
}
