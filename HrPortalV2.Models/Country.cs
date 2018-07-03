using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Country:BaseEntity
    {
        [Display(Name = "Ad")]
        public string Name { get; set; }
    }
}
