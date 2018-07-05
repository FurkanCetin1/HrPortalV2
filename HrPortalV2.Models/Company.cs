using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Company:BaseEntity
    {
        [Display(Name = "Firma Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Ülke")]
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        [Display(Name = "Ülke")]
        public Country Country { get; set; }
        [Display(Name = "Şehir")]
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public City City {get; set;}
        [Display(Name = "İlçe")]
        public string CountyId { get; set; }
        [ForeignKey("CountyId")]
        [Display(Name = "İlçe")]
        public County County { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Sektör")]
        public string SectorId { get; set; }
        [ForeignKey("SectorId")]
        [Display(Name = "Sektör")]
        public Sector Sector { get; set; }
        [Display(Name = "Onaylandı mı?")]
        public bool IsApproved { get; set; }
        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}