using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ibkyazilim_LandingPage.Areas.Yonetim.Models;

namespace ibkyazilim_LandingPage.DAL
{
    public class ibkyazilimContext:DbContext
    {
        public ibkyazilimContext() : base("ibkyazilimContext") { }

        public DbSet<GeriBildirim> GeriBildirims { get; set; }
        public DbSet<AccountControl> AccountControls { get; set; }

        public System.Data.Entity.DbSet<ibkyazilim_LandingPage.Areas.Yonetim.Models.FileUpload> FileUploads { get; set; }
    }
}