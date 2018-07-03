﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Job:BaseEntity
    {
        [Display(Name ="Başlık")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Firma")]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [Display(Name = "Firma")]
        public Company Company { get; set; }
        [Display(Name = "Yayın Tarihi")]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
        [Display(Name = "Yayınlandı mı?")]
        public bool IsApproved { get; set; }
        [Display(Name = "Aktiv mi ?")]
        public bool IsActive { get; set; }
    }
}
