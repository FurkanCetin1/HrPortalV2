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
        public string Name { get; set; }
        [Display(Name = "Şehir")]
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public City City { get; set; }
    }
}
