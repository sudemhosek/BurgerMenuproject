namespace project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig91 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.subscribers",
                c => new
                    {
                        subscribersid = c.Int(nullable: false, identity: true),
                        email = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.subscribersid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.subscribers");
        }
    }
}
