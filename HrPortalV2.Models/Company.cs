using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        public City City {get; set;}
        public string CountyId { get; set; }
        [ForeignKey("CountyId")]
        public County County { get; set; }
        public string Address { get; set; }
        public string SectorId { get; set; }
        [ForeignKey("SectorId")]
        public Sector Sector { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
    }
}