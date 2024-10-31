namespace project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Img = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
