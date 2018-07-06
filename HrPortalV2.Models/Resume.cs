using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Resume:BaseEntity
    {
        [Display(Name="Ad")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }
        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }
        [Display(Name = "Medeni Durum")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Cep Telefonu")]
        public string MobilePhone { get; set; } //
        [Display(Name = "E-Posta")]
        public string Email { get; set; } //
        [Display(Name = "Toplam Deneyim (Yıl)")]
        public int TotalExperience { get; set; }
        [Display(Name = "Şu Anda Çalışıyor Mu?")]
        public bool IsCurrentlyWorking { get; set; }
        [Display(Name = "İş Arıyor Mu?")]
        public bool IsSeekingJob { get; set; }
        [Display(Name = "Son Çalıştığı Firma")]
        public string LastCompany { get; set; }
        [Display(Name = "Son Çalıştığı Pozisyon")]
        public string LastPosition { get; set; }
        [Display(Name = "Askerlik Durumu")]
        public MilitaryStatus? MilitaryStatus { get; set; }
        [Display(Name = "Mezun Olduğu Okul")]
        public string LastEducation { get; set; }
        [Display(Name = "Mezun Olduğu Bölüm")]
        public string LastDepartment { get; set; }
        [Display(Name = "Mezuniyet Yılı")]
        public int GraduationYear { get; set; }
        [Display(Name = "Yabancı Diller")]
        public string ForeignLanguages { get; set; }
        [Display(Name = "Özgeçmiş Dosyaları")]
        public virtual ICollection<ResumeFile> ResumeFiles { get; set; }
        [Display(Name = "Onaylandı Mı?")]
        public bool IsApproved { get; set; }
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "İş Başvuruları")]
        public virtual ICollection<JobApplication> JobApplications { get; set; }
        [Display(Name = "Meslek")]
        public string OccupationId { get; set; }
        [Display(Name = "Meslek")]
        [ForeignKey("OccupationId")]
        public Occupation Occupation { get; set; }
    }
}
