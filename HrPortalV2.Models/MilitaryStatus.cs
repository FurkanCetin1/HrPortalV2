using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public enum MilitaryStatus
    {
        [Display(Name = "Yapılmadı")]
        NotDone = 1,
        [Display(Name = "Yapıldı")]
        Done = 2,
        [Display(Name = "Tecilli")]
        Postponed = 3,
        [Display(Name = "Muaf")]
        Exempt = 4
    }
}
