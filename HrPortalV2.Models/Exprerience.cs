using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Exprerience:BaseEntity
    {
        [Display(Name = "Son Çalıştığı Firma")]
        [StringLength(200, ErrorMessage = "Çalıştığı firma en fazla 200 karakter uzunluğunda olabilir.")]
        public string Company { get; set; }
        [Display(Name = "Son Çalıştığı Pozisyon")]
        [StringLength(200, ErrorMessage = "Pozisyon en fazla 200 karakter uzunluğunda olabilir.")]
        public string Position { get; set; }
        [Display(Name = "Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Bitiş Tarihi")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Özgeçmiş")]
        public string ResumeId { get; set; }
        [ForeignKey("ResumeId")]
        [Display(Name = "Özgeçmiş")]
        public Resume Resume { get; set; }
    }
}
