using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Occupation:BaseEntity
    {
        [Display(Name = "Meslek Adı")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
