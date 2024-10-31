namespace project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contacts", "isread", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.contacts", "isread");
        }
    }
}
