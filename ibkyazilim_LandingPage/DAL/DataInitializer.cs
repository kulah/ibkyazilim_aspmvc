using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ibkyazilim_LandingPage.Areas.Yonetim.Models;


namespace ibkyazilim_LandingPage.DAL
{
    public class DataInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<ibkyazilimContext>
    {
        protected override void Seed(ibkyazilimContext context)
        {
          
        }
    }
}