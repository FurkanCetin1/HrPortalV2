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
        [Required(ErrorMessage = "Özgeçmiş gereklidir.")]
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        [Display(Name = "Özgeçmiş")]
        public Resume Resume { get; set; }
        [Display(Name = "İş ilanı")]
        [Required(ErrorMessage = "İş ilanı gereklidir.")]
        public string JobId { get; set; }
        [ForeignKey("JobId")]
        [Display(Name = "İş ilanı")]
        public Job Job { get; set; }
        [Display(Name = "Başlık")]
        [StringLength(200, ErrorMessage = "Başvuru başlığı en fazla 200 karakter uzunluğunda olabilir.")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

    }
}
