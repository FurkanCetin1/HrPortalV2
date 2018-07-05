using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Sector:BaseEntity
    {
        [Display(Name = "Sektör Adı")]
        public string Name { get; set; }
    }
}
