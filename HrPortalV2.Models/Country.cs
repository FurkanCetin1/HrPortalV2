using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Country:BaseEntity
    {
        [Display(Name = "Ad")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
