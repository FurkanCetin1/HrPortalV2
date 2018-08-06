using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public class Subscription:BaseEntity
    {
        [Display(Name="Ad")]
        [StringLength(200)]
        public string Name{ get; set; }
        [Display(Name="E-mail")]
        [StringLength(200)]
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
