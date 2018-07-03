using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class JobApplication:BaseEntity
    {
        [Display(Name = "Özgeçmiş")]
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        [Display(Name = "Özgeçmiş")]
        public Resume Resume { get; set; }
        [Display(Name = "İş ilanı")]
        public string JobId { get; set; }
        [ForeignKey("JobId")]
        [Display(Name = "İş ilanı")]
        public Job Job { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

    }
}
