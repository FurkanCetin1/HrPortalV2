using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class ResumeFile:BaseEntity
    {
        [Display(Name = "Dosya")]
        public string File { get; set; }
        [Display(Name = "Özgeçmiş")]
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        public Resume Resume { get; set; }
    }
}
