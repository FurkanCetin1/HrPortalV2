using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class County:BaseEntity
    {
        public string Name { get; set; }
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
