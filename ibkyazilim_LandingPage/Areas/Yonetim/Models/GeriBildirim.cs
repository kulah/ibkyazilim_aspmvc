using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ibkyazilim_LandingPage.Areas.Yonetim.Models
{
    public class GeriBildirim
    {
        [Display(Name = "ID")]
        public int id { get; set; }
        
        [Display(Name = "Adı Soyadı")]
        public string adisoyadi { get; set; }

        [Display(Name = "E-Mail")]
        public string email { get; set; }

        [Display(Name = "Konu")]
        public string konu { get; set; }
        
        [Display(Name = "Mesaj")]
        public string iletilenmesaj { get; set; }

    }
}