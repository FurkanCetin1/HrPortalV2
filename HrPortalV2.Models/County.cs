using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class County:BaseEntity
    {
        [Display(Name = "Ad")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Display(Name = "Şehir")]
        [Required]
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public City City { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
