using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Message:BaseEntity
    {
        [Display(Name = "Kimden")]
        public string From { get; set; } // companyId or resumeId
        [Display(Name = "Kimden")]
        public string FromName { get; set; }
        [Display(Name = "Kime")]
        public string To { get; set; } // companyId or resumeId
        [Display(Name = "Kime")]
        public string ToName { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Okundu mu ?")]
        public bool IsRead { get; set; }
        [Display(Name = "Onaylandı mı ?")]
        public bool IsApproved { get; set; }
    }
}
