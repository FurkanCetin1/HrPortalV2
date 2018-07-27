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
        [StringLength(200, ErrorMessage = "Firma adı en fazla 200 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Firma Adı gereklidir.")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Ülke")]
        [Required(ErrorMessage = "Ülke gereklidir.")]
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        [Display(Name = "Ülke")]
        public Country Country { get; set; }
        [Display(Name = "Şehir")]
        [Required(ErrorMessage = "Şehir gereklidir.")]
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public City City {get; set;}
        [Display(Name = "İlçe")]
        [Required(ErrorMessage = "İlçe gereklidir.")]
        public string CountyId { get; set; }
        [ForeignKey("CountyId")]
        [Display(Name = "İlçe")]
        public County County { get; set; }
        [Display(Name = "Adres")]
        [StringLength(4000, ErrorMessage = "Adres en fazla 4000 karakter uzunluğunda olabilir.")]
        public string Address { get; set; }
        [Display(Name = "Sektör")]
        [Required(ErrorMessage = "Sektör gereklidir.")]
        public string SectorId { get; set; }
        [ForeignKey("SectorId")]
        [Display(Name = "Sektör")]
        public Sector Sector { get; set; }
        [Display(Name = "Onaylandı mı?")]
        public bool IsApproved { get; set; }
        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        public ICollection<Job> Jobs { get; set; }

        [Display(Name="Telefon")]
        [Required(ErrorMessage = "Telefon gereklidir.")]
        [StringLength(20, ErrorMessage = "Telefon en fazla 20 karakter uzunluğunda olabilir.")]
        [Phone(ErrorMessage = "Geçersiz telefon numarası!")]
        public string Phone { get; set; }
        [Display(Name="E-Posta")]
        [Required(ErrorMessage = "E-posta gereklidir.")]
        [StringLength(200, ErrorMessage = "E-posta en fazla 200 karakter uzunluğunda olabilir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi!")]
        public string Email { get; set; }
        [Display(Name="Yetkili Adı")]
        [Required(ErrorMessage = "Yetkili adı gereklidir.")]
        [StringLength(200, ErrorMessage ="Yetkili adı en fazla 200 karakter uzunluğunda olabilir.")]
        public string ContactName { get; set; }

        [Display(Name="Logo")]
        [StringLength(200, ErrorMessage = "Logo dosya adı en fazla 200 karakter uzunluğunda olabilir.")]
        public string Logo { get; set; }
        [Display(Name="Web Sitesi")]
        [StringLength(200, ErrorMessage = "Web sitesi adresi en fazla 200 karakter uzunluğunda olabilir.")]
        public string Website { get; set; }

    }
}