using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ibkyazilim_LandingPage.Areas.Yonetim.Models
{
    public class FileUpload
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Durum")]
        public string DURUM { get; set; }

        [Display(Name = "Dosya Tipi")]
        public string FILETYPE { get; set; }

        [Display(Name = "Dosya Formatı")]
        public string FILEFORMAT { get; set; }


        [Display(Name = "Dosya Adı")]
        public string FILENAME { get; set; }
        public long FILE { get; set; }
    }
}