using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Message:BaseEntity
    {
        [Display(Name = "Kimden")]
        [Required(ErrorMessage = "Kimden alanı gereklidir.")]
        [StringLength(200)]
        public string From { get; set; } // companyId or resumeId
        [Display(Name = "Kimden")]
        [Required(ErrorMessage = "Kimden alanı gereklidir.")]
        [StringLength(200)]
        public string FromName { get; set; }
        [Display(Name = "Kime")]
        [Required(ErrorMessage = "Kime alanı gereklidir.")]
        [StringLength(200)]
        public string To { get; set; } // companyId or resumeId
        [Display(Name = "Kime")]
        [Required(ErrorMessage = "Kime alanı gereklidir.")]
        [StringLength(200)]
        public string ToName { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Mesaj başlığı gereklidir.")]
        [StringLength(200, ErrorMessage = "Mesaj başlığı en fazla 200 karakter uzunluğunda olabilir.")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Mesaj açıklaması gereklidir.")]
        public string Description { get; set; }
        [Display(Name = "Okundu mu ?")]
        public bool IsRead { get; set; }
        [Display(Name = "Onaylandı mı ?")]
        public bool IsApproved { get; set; }
    }
}
