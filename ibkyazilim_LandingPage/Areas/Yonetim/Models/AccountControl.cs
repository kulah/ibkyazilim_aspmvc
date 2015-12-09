using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ibkyazilim_LandingPage.Areas.Yonetim.Models
{
    public class AccountControl
    {
        [Key]
        [Display(Name="ID")]
        public int ID { get; set; }
        
        [Display(Name = "Durum")]
        public string DURUM { get; set; }

        [Display(Name = "Ad")]
        public string AD { get; set; }

        [Display(Name = "Soyad")]
        public string SOYAD { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string KULLANICIADI { get; set; }

        [Display(Name = "Parola")]
        public string PAROLA { get; set; }

        [Display(Name = "E-Mail")]
        public string EMAIL{ get; set; }

        [Display(Name = "Administrator")]
        public string ADMIN { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime ETAR { get; set; }

        [Display(Name = "Değişiklik Tarihi")]
        public DateTime DTAR { get; set; }

        [Display(Name = "Online Durumu")]
        public string CEVRIMICIMI { get; set; }
        
    }
}