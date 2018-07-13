using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class ApplicationUser:IdentityUser
    {
        [StringLength(200)]
        [Display(Name = "Tam Ad")]
        public string FullName { get; set; }
        [StringLength(200)]
        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }
    }
}
