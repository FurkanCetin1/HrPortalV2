using System;
using System.Collections.Generic;
using System.Text;

namespace HrPortalV2.Models
{
    public class Message:BaseEntity
    {
        public string From { get; set; } // companyId or resumeId
        public string To { get; set; } // companyId or resumeId
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public bool IsApproved { get; set; }
    }
}
