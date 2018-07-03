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
        public string Name { get; set; }
        [Display(Name = "Ülke")]
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        [Display(Name = "Ülke")]
        public Country Country { get; set; }
    }
}
