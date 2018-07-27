using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Sector:BaseEntity
    {
        [Display(Name = "Sektör Adı")]
        [Required(ErrorMessage = "Sektör adı gereklidir.")]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
