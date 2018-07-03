using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HrPortalV2.Models
{
    public enum MaritalStatus
    {
        [Display(Name = "Bekar")]
        Single = 1,
        [Display(Name = "Evli")]
        Married = 2
    }
}
