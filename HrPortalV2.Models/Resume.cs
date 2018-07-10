using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrPortalV2.Models
{
    public class Resume:BaseEntity
    {
        [Display(Name = "Özgeçmiş Adı")]
        public string ResumeName { get; set; }
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
        public string MobilePhone { get; set; } 
        [Display(Name = "E-Posta")]
        public string Email { get; set; } 
        [Display(Name = "Toplam Deneyim (Yıl)")]
        public int TotalExperience { get; set; }
        [Display(Name = "Sigara Kullanıyor Mu?")]
        public bool UsingCigarette{ get; set; }
        [Display(Name = "Seyahat Engeli Var Mı?")]
        public bool IsTravelDisabled { get; set; }
        [Display(Name = "Engelli Mi")]
        public bool IsDisabled{ get; set; }
        [Display(Name = "Teşvikli Mi?")]
        public bool IsSubsidized { get; set; }
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
        [Display(Name = "Hedef")]
        public string Objective { get; set; }
        [Display(Name = "Ülke")]
        public string CountryId { get; set; }
        [ForeignKey("CountryId")]
        [Display(Name = "Ülke")]
        public Country Country { get; set; }
        [Display(Name = "Şehir")]
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public City City { get; set; }
        [Display(Name = "İlçe")]
        public string CountyId { get; set; }
        [ForeignKey("CountyId")]
        [Display(Name = "İlçe")]
        public County County{ get; set; }
        [Display(Name = "Adres")]
        public City Address { get; set; }
        [Display(Name = "Projeler")]
        public string Projects { get; set; }
        [Display(Name = "Yetkinlikler")]
        public string Skills { get; set; }
        [Display(Name = "Hobiler")]
        public string Hobbies { get; set; }
        [Display(Name = "Sürücü Belgesi")]
        public string DrivingLicense { get; set; }
        [Display(Name = "Seminer ve Kurslar")]
        public string Courses { get; set; }

        public string Blog { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string Dribble { get; set; }
        public string Behance { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
    }
}
