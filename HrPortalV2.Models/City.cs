using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class City:BaseEntity
    {
        [Display(Name="Ad")]
        [StringLength(200)]
        [Required(ErrorMessage = "Şehir adı gereklidir.")]
        public string Name { get; set; }
        [Display(Name = "Ülke")]
        [Required(ErrorMessage = "Ülke gereklidir")]
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        [Display(Name = "Ülke")]
        public Country Country { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
