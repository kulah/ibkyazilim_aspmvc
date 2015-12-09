namespace ibkyazilim_LandingPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ibkyazilimContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountControls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DURUM = c.String(),
                        AD = c.String(),
                        SOYAD = c.String(),
                        KULLANICIADI = c.String(),
                        PAROLA = c.String(),
                        EMAIL = c.String(),
                        ADMIN = c.String(),
                        ETAR = c.DateTime(nullable: false),
                        DTAR = c.DateTime(nullable: false),
                        CEVRIMICIMI = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GeriBildirims",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        adisoyadi = c.String(),
                        email = c.String(),
                        konu = c.String(),
                        iletilenmesaj = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GeriBildirims");
            DropTable("dbo.AccountControls");
        }
    }
}
