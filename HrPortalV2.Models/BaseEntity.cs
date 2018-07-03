using System;
using System.ComponentModel.DataAnnotations;

namespace HrPortalV2.Models
{
    public class BaseEntity
    {
        public string Id { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Oluşturan Kullanıcı")]
        public string CreatedBy { get; set; }
        [Display(Name = "Güncelleme Tarihi")]
        public DateTime UpdateDate { get; set; }
        [Display(Name = "Oluşturan Kullanıcı")]
        public string UpdatedBy { get; set; }
        [Display(Name = "Ip Adresi")]
        public string IPAddress { get; set; }
    }
}
