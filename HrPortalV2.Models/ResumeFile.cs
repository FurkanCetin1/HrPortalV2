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
        [Required(ErrorMessage = "Dosya adı gereklidir.")]
        [StringLength(200, ErrorMessage = "Dosya adı en fazla 200 karakter uzunluğunda olabilir.")]
        public string File { get; set; }
        [Display(Name = "Özgeçmiş")]
        [Required(ErrorMessage = "Özgeçmiş gereklidir.")]
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        public Resume Resume { get; set; }
    }
}
