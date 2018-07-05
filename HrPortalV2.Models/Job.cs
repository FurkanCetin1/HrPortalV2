using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Job:BaseEntity
    {
        [Display(Name ="İlan Başlığı")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Firma")]
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [Display(Name = "Firma")]
        public Company Company { get; set; }
        [Display(Name = "Yayın Tarihi")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Bitiş Tarihi")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
        [Display(Name = "Onaylandı mı?")]
        public bool IsApproved { get; set; }
        [Display(Name = "Aktif mi ?")]
        public bool IsActive { get; set; }
        [Display(Name = "Öne Çıkan")]
        public bool IsFeatured { get; set; }
        [Display(Name = "Sıra No")]
        public int Position { get; set; }
    }
}
