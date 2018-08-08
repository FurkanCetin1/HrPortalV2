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
        [Required(ErrorMessage = "Özgeçmiş adı gereklidir.")]
        [StringLength(200, ErrorMessage = "Özgeçmiş adı en fazla 200 karakter uzunluğunda olabilir.")]
        public string ResumeName { get; set; }
        [Display(Name="Ad")]
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Ad alanı en fazla 100 karakter uzunluğunda olabilir.")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Soyad alanı en fazla 100 karakter uzunluğunda olabilir.")]
        public string LastName { get; set; }
        [Display(Name = "Fotoğraf")]
        [StringLength(200, ErrorMessage = "Fotoğraf dosya adı en fazla 200 karakter uzunluğunda olabilir.")]
        public string Photo { get; set; }
        [Display(Name = "Cinsiyet")]
        [Required(ErrorMessage = "Cinsiyet gereklidir.")]
        public Gender Gender { get; set; }
        [Display(Name = "Medeni Durum")]
        [Required(ErrorMessage = "Medeni durum gereklidir.")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Cep Telefonu")]
        [Required(ErrorMessage = "Cep telefonu gereklidir.")]
        [StringLength(20, ErrorMessage = "Cep telefonu en az 20 karakter uzunluğunda olabilir.")]
        [Phone(ErrorMessage = "Geçersiz telefon numarası!")]
        public string MobilePhone { get; set; } 
        [Display(Name = "E-Posta")]
        [Required(ErrorMessage = "E-posta gereklidir.")]
        [StringLength(200, ErrorMessage = "E-posta en fazla 200 karakter uzunluğunda olabilir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi!")]
        public string Email { get; set; } 
        [Display(Name = "Toplam Deneyim (Yıl)")]
        [Required(ErrorMessage = "Toplam deneyim gereklidir.")]
        [Range(0,50, ErrorMessage = "Toplam deneyim 0 ila 50 yıl arasında olabilir.")]
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
        [Display(Name = "Askerlik Durumu")]
        public MilitaryStatus? MilitaryStatus { get; set; }
        [Display(Name = "Mezun Olduğu Okul")]
        [Required(ErrorMessage = "Mezun olduğu okul gereklidir.")]
        [StringLength(200, ErrorMessage = "Mezun olduğu okul en fazla 200 karakter uzunluğunda olabilir.")]
        public string LastEducation { get; set; }
        [Display(Name = "Mezun Olduğu Bölüm")]
        [Required(ErrorMessage = "Mezun olduğu bölüm gereklidir.")]
        [StringLength(200, ErrorMessage = "Mezun olduğu bölüm en fazla 200 karakter uzunluğunda olabilir.")]
        public string LastDepartment { get; set; }
        [Display(Name = "Mezuniyet Yılı")]
        [Range(1920, 2018, ErrorMessage = "Mezuniyet yılı 1920 ila 2018 yılları arasında olabilir.")]
        public int? GraduationYear { get; set; }
        [Display(Name = "Yabancı Diller")]
        [StringLength(200, ErrorMessage = "Yabancı diller en fazla 200 karakter uzunluğunda olabilir.")]
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
        [Required(ErrorMessage = "Meslek gereklidir.")]
        public string OccupationId { get; set; }
        [Display(Name = "Meslek")]
        [ForeignKey("OccupationId")]
        public Occupation Occupation { get; set; }
        [Display(Name = "Hedef")]
        [StringLength(4000, ErrorMessage = "Hedef alanı en fazla 4000 karakter uzunluğunda olabilir.")]
        public string Objective { get; set; }
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
        public City City { get; set; }
        [Display(Name = "İlçe")]
        [Required(ErrorMessage = "İlçe gereklidir.")]
        public string CountyId { get; set; }
        [ForeignKey("CountyId")]
        [Display(Name = "İlçe")]
        public County County{ get; set; }
        [Display(Name = "Adres")]
        [StringLength(1000, ErrorMessage = "Adres en fazla 1000 karakter uzunluğunda olabilir.")]
        public City Address { get; set; }
        [Display(Name = "Projeler")]
        public string Projects { get; set; }
        [Display(Name = "Yetkinlikler")]
        public string Skills { get; set; }
        [Display(Name = "Hobiler")]
        [StringLength(4000, ErrorMessage = "Hobiler en fazla 4000 karakter uzunluğunda olabilir.")]
        public string Hobbies { get; set; }
        [Display(Name = "Sürücü Belgesi")]
        [StringLength(20, ErrorMessage = "Sürücü belgesi en fazla 20 karakter uzunluğunda olabilir.")]
        public string DrivingLicense { get; set; }
        [Display(Name = "Seminer ve Kurslar")]
        public string Courses { get; set; }
        [StringLength(100, ErrorMessage = "Blog en fazla 100 karakter uzunluğunda olabilir.")]
        public string Blog { get; set; }
        [StringLength(100, ErrorMessage = "LinkedIn en fazla 100 karakter uzunluğunda olabilir.")]
        public string LinkedIn { get; set; }
        [StringLength(100, ErrorMessage = "GitHub en fazla 100 karakter uzunluğunda olabilir.")]
        public string GitHub { get; set; }
        [StringLength(100, ErrorMessage = "Dribbble en fazla 100 karakter uzunluğunda olabilir.")]
        public string Dribbble { get; set; }
        [StringLength(100, ErrorMessage = "Behance en fazla 100 karakter uzunluğunda olabilir.")]
        public string Behance { get; set; }
        [StringLength(100, ErrorMessage = "Youtube en fazla 100 karakter uzunluğunda olabilir.")]
        public string Youtube { get; set; }
        [StringLength(100, ErrorMessage = "Instagram en fazla 100 karakter uzunluğunda olabilir.")]
        public string Instagram { get; set; }
        [StringLength(100, ErrorMessage = "Facebook en fazla 100 karakter uzunluğunda olabilir.")]
        public string Facebook { get; set; }
        [StringLength(100, ErrorMessage = "Twitter en fazla 100 karakter uzunluğunda olabilir.")]
        public string Twitter { get; set; }
    }
}
